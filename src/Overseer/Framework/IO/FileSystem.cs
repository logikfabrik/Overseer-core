// <copyright file="FileSystem.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.IO;
    using System.Text;

    /// <inheritdoc />
    public class FileSystem : IFileSystem
    {
        /// <inheritdoc />
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        /// <inheritdoc />
        public string ReadFileText(string path)
        {
            return File.ReadAllText(path, Encoding.UTF8);
        }

        /// <inheritdoc />
        public void WriteFileText(string path, string text)
        {
            File.WriteAllText(path, text, Encoding.UTF8);
        }

        /// <inheritdoc />
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
