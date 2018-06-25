// <copyright file="HashCode.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using EnsureThat;

    /// <summary>
    /// Utility for generating hash codes.
    /// </summary>
    public static class HashCode
    {
        /// <summary>
        /// Generates a hash code of the specified components.
        /// </summary>
        /// <param name="components">The components.</param>
        /// <returns>The generated hash code.</returns>
        public static int Generate(IEnumerable<object> components)
        {
            var c = components as object[] ?? components?.ToArray();

            EnsureArg.IsNotNull(c);

            unchecked
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                return c.Aggregate(17, (current, obj) => (current * 23) + (obj?.GetHashCode() ?? 0));
            }
        }
    }
}
