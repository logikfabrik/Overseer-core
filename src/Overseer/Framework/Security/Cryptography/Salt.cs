// <copyright file="Salt.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.Security.Cryptography
{
    using System.Security.Cryptography;
    using EnsureThat;

    /// <summary>
    /// Utility for generating salts.
    /// </summary>
    public static class Salt
    {
        /// <summary>
        /// Generates a salt of the specified size.
        /// </summary>
        /// <param name="size">The size, in bytes, of the salt to generate.</param>
        /// <returns>The generated salt.</returns>
        public static byte[] Generate(int size)
        {
            EnsureArg.Is(size % 8, 0, nameof(size));

            var salt = new byte[size];

            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }
    }
}
