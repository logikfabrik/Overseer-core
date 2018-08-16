// <copyright file="Aes256EncryptedUTF8TextFile.cs" company="Logikfabrik">
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
    /// An AES encrypted UTF-8 text file, using a 256 bit key and a 128 bit IV.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    // ReSharper disable once InconsistentNaming
    public class Aes256EncryptedUTF8TextFile : UTF8TextFile
    {
        private const int KeySizeInBits = 256;
        private const int KeySizeInBytes = KeySizeInBits / 8;

        // ReSharper disable once InconsistentNaming
        private const int IVInBits = 128;

        // ReSharper disable once InconsistentNaming
        private const int IVInBytes = IVInBits / 8;

        private readonly byte[] _key;

        /// <summary>
        /// Initializes a new instance of the <see cref="Aes256EncryptedUTF8TextFile" /> class.
        /// </summary>
        /// <param name="osFileSystem">The OS file system.</param>
        /// <param name="path">The path to the file to read from and write to.</param>
        /// <param name="key">The secret 256 bit key for the AES algorithm.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public Aes256EncryptedUTF8TextFile(IOSFileSystem osFileSystem, string path, byte[] key)
            : base(osFileSystem, path)
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
            var data = unencryptedText != null ? Encoding.UTF8.GetBytes(unencryptedText) : new byte[] { };

            var iv = Salt.Generate(IVInBytes);

            using (var algorithm = GetAlgorithm(iv))
            {
                using (var encryptor = algorithm.CreateEncryptor())
                {
                    var encryptedData = encryptor.TransformFinalBlock(data, 0, data.Length);

                    var ivAndEncryptedData = new byte[iv.Length + encryptedData.Length];

                    Buffer.BlockCopy(iv, 0, ivAndEncryptedData, 0, iv.Length);
                    Buffer.BlockCopy(encryptedData, 0, ivAndEncryptedData, iv.Length, encryptedData.Length);

                    return Convert.ToBase64String(ivAndEncryptedData);
                }
            }
        }

        private string Decrypt(string encryptedText)
        {
            var data = encryptedText != null ? Convert.FromBase64String(encryptedText) : default(byte[]);

            if (data == null || data.Length < IVInBytes)
            {
                return null;
            }

            var iv = new byte[IVInBytes];

            Buffer.BlockCopy(data, 0, iv, 0, iv.Length);

            using (var algorithm = GetAlgorithm(iv))
            {
                using (var decryptor = algorithm.CreateDecryptor())
                {
                    var decryptedData = decryptor.TransformFinalBlock(data, IVInBytes, data.Length - IVInBytes);

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
