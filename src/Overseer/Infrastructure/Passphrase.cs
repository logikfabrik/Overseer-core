// <copyright file="Passphrase.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using EnsureThat;
    using Framework.IO;
    using Framework.Security.Cryptography;

    internal sealed class Passphrase
    {
        private readonly IFile<string> _file;

        public Passphrase(IFile<string> file)
        {
            EnsureArg.IsNotNull(file);

            _file = file;
        }

        /// <summary>
        /// Gets the hash of the user-defined passphrase.
        /// </summary>
        /// <returns>The hash of the user-defined passphrase.</returns>
        public byte[] GetHash()
        {
            var data = _file.Read();

            if (data == null)
            {
                return null;
            }

            var passphraseHash = Convert.FromBase64String(data);

            return passphraseHash;
        }

        /// <summary>
        /// Sets the passphrase.
        /// </summary>
        /// <param name="passphrase">The passphrase.</param>
        public void Set(string passphrase)
        {
            var passphraseHash = Hash.Generate(passphrase, Salt.Generate(16), 32);

            var data = Convert.ToBase64String(passphraseHash);

            _file.Write(data);
        }
    }
}
