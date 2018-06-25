// <copyright file="Hash.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.Security.Cryptography
{
    using System.Security.Cryptography;
    using EnsureThat;

    /// <summary>
    /// Utility for generating hashes.
    /// </summary>
    public static class Hash
    {
        /// <summary>
        /// Generates a hash of the specified password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="salt">The salt to use when generating the hash.</param>
        /// <param name="size">The size, in bytes, of the hash to generate.</param>
        /// <returns>The generated hash.</returns>
        public static byte[] Generate(string password, byte[] salt, int size)
        {
            EnsureArg.IsNotNull(password);
            EnsureArg.IsNotNull(salt);
            EnsureArg.Is(salt.Length % 8, 0, nameof(salt));
            EnsureArg.Is(size % 8, 0, nameof(size));

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 10000);

            return rfc2898DeriveBytes.GetBytes(size);
        }
    }
}
