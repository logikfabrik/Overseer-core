// <copyright file="OSFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.Text;

    /// <summary>
    /// The OS file system; portions for working with files.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    // ReSharper disable once InconsistentNaming
    public class OSFile : IOSFile
    {
        /// <inheritdoc />
        public bool Exists(string path)
        {
            return System.IO.File.Exists(path);
        }

        /// <inheritdoc />
        public string ReadUTF8(string path)
        {
            return System.IO.File.ReadAllText(path, Encoding.UTF8);
        }

        /// <inheritdoc />
        public byte[] Read(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        /// <inheritdoc />
        public void WriteUTF8(string path, string data)
        {
            System.IO.File.WriteAllText(path, data, Encoding.UTF8);
        }

        /// <inheritdoc />
        public void Write(string path, byte[] data)
        {
            System.IO.File.WriteAllBytes(path, data);
        }
    }
}
