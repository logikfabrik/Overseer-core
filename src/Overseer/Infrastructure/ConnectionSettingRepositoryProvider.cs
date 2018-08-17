// <copyright file="ConnectionSettingRepositoryProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using System.Linq;
    using Domain.Model.ConnectionSettings;
    using Framework.IO;
    using Framework.Security.Cryptography.IO;
    using Framework.Xml.Serialization;
    using Framework.Xml.Serialization.IO;
    using Ninject;
    using Ninject.Activation;
    using Overseer.Common.Infrastructure;

    internal sealed class ConnectionSettingRepositoryProvider : Provider<IConnectionSettingRepository>
    {
        /// <inheritdoc />
        protected override IConnectionSettingRepository CreateInstance(IContext context)
        {
            var osFileSystem = context.Kernel.Get<IOSFileSystem>();

            var passphrase = new Passphrase(new UTF8File(osFileSystem, "test"));

            // var passphraseHash = passphrase.GetHash();

            var passphraseHash = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 };

            var file = new Aes256EncryptedUTF8File(osFileSystem, "ConnectionSettings.xml", passphraseHash);

            var xmlSerializer = new XmlSerializer<ConnectionSettingDto[]>(AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => !type.IsAbstract && typeof(ConnectionSettingDto).IsAssignableFrom(type))
                .ToArray());

            var xmlFile = new XmlFile<ConnectionSettingDto>(xmlSerializer, file);

            var toConnectionSettingDtoMapperFactory = context.Kernel.Get<IToConnectionSettingDtoMapperFactory>();
            var toConnectionSettingMapperFactory = context.Kernel.Get<IToConnectionSettingMapperFactory>();

            return new ConnectionSettingRepository(xmlFile, toConnectionSettingDtoMapperFactory, toConnectionSettingMapperFactory);
        }
    }
}
