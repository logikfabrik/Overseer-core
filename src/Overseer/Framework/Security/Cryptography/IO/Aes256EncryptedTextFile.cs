// <copyright file="Aes256EncryptedTextFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.Security.Cryptography.IO
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using EnsureThat;
    using Overseer.Framework.IO;

    /// <summary>
    /// An AES encrypted text file, using a 256 bit key and a 128 bit IV.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public class Aes256EncryptedTextFile : TextFile
    {
        private const int KeySizeInBits = 256;
        private const int KeySizeInBytes = KeySizeInBits / 8;

        private readonly byte[] _key;

        /// <summary>
        /// Initializes a new instance of the <see cref="Aes256EncryptedTextFile" /> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="path">The path to the file to read from and write to.</param>
        /// <param name="key">The secret 256 bit key for the AES algorithm.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public Aes256EncryptedTextFile(IFileSystem fileSystem, string path, byte[] key)
            : base(fileSystem, path)
        {
            EnsureArg.IsNotNull(key);
            EnsureArg.Is(key.Length, KeySizeInBytes, nameof(key));

            _key = new byte[KeySizeInBytes];

            key.CopyTo(_key, 0);
        }

        /// <inheritdoc />
        public override string Read()
        {
            var encryptedText = base.Read();

            return Decrypt(encryptedText);
        }

        /// <inheritdoc />
        public override void Write(string text)
        {
            var encryptedText = Encrypt(text);

            base.Write(encryptedText);
        }

        private string Encrypt(string unencryptedText)
        {
            var data = Encoding.UTF8.GetBytes(unencryptedText);

            using (var algorithm = GetAlgorithm(Salt.Generate(16)))
            {
                using (var encryptor = algorithm.CreateEncryptor())
                {
                    var encryptedData = encryptor.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(encryptedData);
                }
            }
        }

        private string Decrypt(string encryptedText)
        {
            var data = Convert.FromBase64String(encryptedText);

            var iv = new byte[16];

            Array.Copy(data, iv, 16);

            using (var algorithm = GetAlgorithm(iv))
            {
                using (var decryptor = algorithm.CreateDecryptor())
                {
                    var decryptedData = decryptor.TransformFinalBlock(data, 16, data.Length);

                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
        }

        private Aes GetAlgorithm(byte[] iv)
        {
            var algorithm = new AesManaged
            {
                KeySize = KeySizeInBits,
                Key = _key,
                IV = iv,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            return algorithm;
        }
    }
}
