// <copyright file="AssemblyConstraintInstanceProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Ninject.Extensions.Factory;

    /// <summary>
    /// An instance provider constrained to creating instances within the same assembly as its specified argument.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class AssemblyConstraintInstanceProvider : StandardInstanceProvider
    {
        /// <inheritdoc />
        protected override Type GetType(MethodInfo methodInfo, object[] arguments)
        {
            var assembly = arguments[0].GetType().Assembly;

            return assembly.GetTypes().Single(type => methodInfo.ReturnType.IsAssignableFrom(type));
        }
    }
}
