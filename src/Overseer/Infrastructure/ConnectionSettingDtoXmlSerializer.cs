// <copyright file="ConnectionSettingDtoXmlSerializer.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Linq;
    using Framework.Xml.Serialization;
    using Overseer.Common.Infrastructure;

    internal sealed class ConnectionSettingDtoXmlSerializer : XmlSerializer<ConnectionSettingDto[]>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingDtoXmlSerializer" /> class.
        /// </summary>
        /// <param name="appDomain">The application domain.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public ConnectionSettingDtoXmlSerializer(AppDomain appDomain)
            : base(GetExtraTypes(appDomain))
        {
        }

        private static Type[] GetExtraTypes(AppDomain appDomain)
        {
            return appDomain
                .GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => !type.IsAbstract && typeof(ConnectionSettingDto).IsAssignableFrom(type))
                .ToArray();
        }
    }
}
