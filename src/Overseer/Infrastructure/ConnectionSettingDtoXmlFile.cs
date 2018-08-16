// <copyright file="ConnectionSettingDtoXmlFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using EnsureThat;
    using Framework.IO;
    using Framework.Xml.Serialization;
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// A file for reading and writing connection settings in XML.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    internal sealed class ConnectionSettingDtoXmlFile : IConnectionSettingDtoFile
    {
        private readonly XmlSerializer<ConnectionSettingDto[]> _xmlSerializer;
        private readonly ITextFile _textFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionSettingDtoXmlFile" /> class.
        /// </summary>
        /// <param name="xmlSerializer">The XML serializer to use to deserialize and serialize connection settings.</param>
        /// <param name="textFile">The text file to read connection settings from and write connection settings to.</param>
        public ConnectionSettingDtoXmlFile(XmlSerializer<ConnectionSettingDto[]> xmlSerializer, ITextFile textFile)
        {
            EnsureArg.IsNotNull(xmlSerializer);
            EnsureArg.IsNotNull(textFile);

            _xmlSerializer = xmlSerializer;
            _textFile = textFile;
        }

        /// <inheritdoc />
        public ConnectionSettingDto[] Read()
        {
            var xml = _textFile.Read();

            return xml == null ? new ConnectionSettingDto[] { } : _xmlSerializer.Deserialize(xml);
        }

        /// <inheritdoc />
        public void Write(ConnectionSettingDto[] connectionSettings)
        {
            Ensure.That(connectionSettings).IsNotNull();

            var xml = _xmlSerializer.Serialize(connectionSettings);

            _textFile.Write(xml);
        }
    }
}
