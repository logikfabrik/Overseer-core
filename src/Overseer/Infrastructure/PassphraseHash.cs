// <copyright file="PassphraseHash.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Framework.Security.Cryptography;

    /// <summary>
    /// Utility for generating 256 bit passphrase hashes.
    /// </summary>
    internal static class PassphraseHash
    {
        /// <summary>
        /// Generates a hash of the specified passphrase.
        /// </summary>
        /// <param name="passphrase">The passphrase.</param>
        /// <returns>The generated passphrase hash.</returns>
        public static byte[] Generate(string passphrase)
        {
            return Hash.Generate(passphrase, Salt.Generate(16), 32);
        }
    }
}
