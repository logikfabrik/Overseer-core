// <copyright file="XmlSerializer{T}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.Xml.Serialization
{
    using System;
    using System.IO;
    using EnsureThat;

    /// <summary>
    /// Serializes and deserializes objects into and from XML documents.
    /// </summary>
    /// <typeparam name="T">The object type.</typeparam>
    public class XmlSerializer<T>
    {
        private readonly Type[] _extraTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlSerializer{T}" /> class.
        /// </summary>
        /// <param name="extraTypes">The extra types.</param>
        public XmlSerializer(Type[] extraTypes)
        {
            EnsureArg.IsNotNull(extraTypes);

            _extraTypes = extraTypes;
        }

        /// <summary>
        /// Deserializes the specified data from XML.
        /// </summary>
        /// <param name="data">The data to deserialize from XML.</param>
        /// <returns>The deserialized data.</returns>
        public T Deserialize(string data)
        {
            EnsureArg.IsNotNullOrEmpty(data);

            using (var reader = new StringReader(data))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), _extraTypes);

                return (T)serializer.Deserialize(reader);
            }
        }

        /// <summary>
        /// Serializes the specified data into XML.
        /// </summary>
        /// <param name="data">The data to serialize into XML.</param>
        /// <returns>The serialized data.</returns>
        public string Serialize(T data)
        {
            using (var writer = new StringWriter())
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), _extraTypes);

                serializer.Serialize(writer, data);

                return writer.ToString();
            }
        }
    }
}
