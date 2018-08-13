﻿// <copyright file="ConnectionSettingDtoFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using EnsureThat;
    using Framework.IO;
    using Framework.Xml.Serialization;
    using Overseer.Common.Infrastructure;

    internal sealed class ConnectionSettingDtoFile
    {
        private readonly XmlSerializer<ConnectionSettingDto[]> _xmlSerializer;
        private readonly ITextFile _textFile;

        public ConnectionSettingDtoFile(XmlSerializer<ConnectionSettingDto[]> xmlSerializer, ITextFile textFile)
        {
            EnsureArg.IsNotNull(xmlSerializer);
            EnsureArg.IsNotNull(textFile);

            _xmlSerializer = xmlSerializer;
            _textFile = textFile;
        }

        public ConnectionSettingDto[] Read()
        {
            var xml = _textFile.Read();

            return xml == null ? new ConnectionSettingDto[] { } : _xmlSerializer.Deserialize(xml);
        }

        public void Write(ConnectionSettingDto[] connectionSettings)
        {
            Ensure.That(connectionSettings).IsNotNull();

            var xml = _xmlSerializer.Serialize(connectionSettings);

            _textFile.Write(xml);
        }
    }
}
