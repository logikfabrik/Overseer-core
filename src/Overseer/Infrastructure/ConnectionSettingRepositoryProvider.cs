// <copyright file="ConnectionSettingRepositoryProvider.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using System;
    using Domain.Model.ConnectionSettings;
    using Framework.IO;
    using Framework.Security.Cryptography.IO;
    using Ninject;
    using Ninject.Activation;

    internal sealed class ConnectionSettingRepositoryProvider : Provider<IConnectionSettingRepository>
    {
        protected override IConnectionSettingRepository CreateInstance(IContext context)
        {
            var connectionSettingDtoFile = new ConnectionSettingDtoFile(new ConnectionSettingDtoXmlSerializer(AppDomain.CurrentDomain), new Aes256EncryptedUTF8TextFile(context.Kernel.Get<IOSFileSystem>(), "ConnectionSettings.xml", new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 }));
            var toConnectionSettingDtoMapperFactory = context.Kernel.Get<IToConnectionSettingDtoMapperFactory>();
            var toConnectionSettingMapperFactory = context.Kernel.Get<IToConnectionSettingMapperFactory>();

            return new ConnectionSettingRepository(connectionSettingDtoFile, toConnectionSettingDtoMapperFactory, toConnectionSettingMapperFactory);
        }
    }
}
