// <copyright file="XmlFile{T}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.Xml.Serialization.IO
{
    using EnsureThat;
    using Overseer.Framework.IO;

    /// <summary>
    /// An XML file for reading and writing.
    /// </summary>
    /// <typeparam name="T">The type of the object to read and write.</typeparam>
    // ReSharper disable once InheritdocConsiderUsage
    public class XmlFile<T> : IFile<T[]>
    {
        private readonly XmlSerializer<T[]> _xmlSerializer;
        private readonly IFile<string> _file;

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlFile{T}" /> class.
        /// </summary>
        /// <param name="xmlSerializer">The XML serializer.</param>
        /// <param name="file">The file.</param>
        public XmlFile(XmlSerializer<T[]> xmlSerializer, IFile<string> file)
        {
            EnsureArg.IsNotNull(xmlSerializer);
            EnsureArg.IsNotNull(file);

            _xmlSerializer = xmlSerializer;
            _file = file;
        }

        /// <inheritdoc />
        public T[] Read()
        {
            var xml = _file.Read();

            return xml == null ? new T[] { } : _xmlSerializer.Deserialize(xml);
        }

        /// <inheritdoc />
        public void Write(T[] data)
        {
            var xml = _xmlSerializer.Serialize(data);

            _file.Write(xml);
        }
    }
}
