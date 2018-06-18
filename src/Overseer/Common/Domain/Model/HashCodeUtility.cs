// <copyright file="HashCodeUtility.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public static class HashCodeUtility
    {
        public static int GetHashCode(IEnumerable<object> objs)
        {
            unchecked
            {
                return objs.Aggregate(17, (current, obj) => (current * 23) + (obj != null ? obj.GetHashCode() : 0));
            }
        }
    }
}
