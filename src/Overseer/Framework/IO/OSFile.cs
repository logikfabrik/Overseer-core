// <copyright file="OSFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.IO;
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
            return File.Exists(path);
        }

        /// <inheritdoc />
        public string ReadUTF8(string path)
        {
            return File.ReadAllText(path, Encoding.UTF8);
        }

        /// <inheritdoc />
        public void WriteUTF8(string path, string text)
        {
            File.WriteAllText(path, text, Encoding.UTF8);
        }
    }
}
