// <copyright file="ConnectionSettingDtoXmlSerializerProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Linq;
    using EnsureThat;
    using Framework.Xml.Serialization;
    using Ninject.Activation;
    using Overseer.Common.Infrastructure;

    public sealed class ConnectionSettingDtoXmlSerializerProvider : Provider<XmlSerializer<ConnectionSettingDto>>
    {
        private readonly AppDomain _appDomain;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingDtoXmlSerializerProvider" /> class.
        /// </summary>
        /// <param name="appDomain">The application domain.</param>
        public ConnectionSettingDtoXmlSerializerProvider(AppDomain appDomain)
        {
            EnsureArg.IsNotNull(appDomain);

            _appDomain = appDomain;
        }

        /// <inheritdoc />
        protected override XmlSerializer<ConnectionSettingDto> CreateInstance(IContext context)
        {
            var extraTypes = _appDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => !type.IsAbstract && typeof(ConnectionSettingDto).IsAssignableFrom(type))
                .ToArray();

            return new XmlSerializer<ConnectionSettingDto>(extraTypes);
        }
    }
}
