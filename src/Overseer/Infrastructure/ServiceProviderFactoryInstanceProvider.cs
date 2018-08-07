// <copyright file="ServiceProviderFactoryInstanceProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Ninject.Extensions.Factory;

    internal sealed class ServiceProviderFactoryInstanceProvider : StandardInstanceProvider
    {
        /// <inheritdoc />
        protected override Type GetType(MethodInfo methodInfo, object[] arguments)
        {
            var assembly = arguments[0].GetType().Assembly;

            return assembly.GetTypes().Single(type => typeof(Common.Infrastructure.IServiceProvider).IsAssignableFrom(type));
        }
    }
}
