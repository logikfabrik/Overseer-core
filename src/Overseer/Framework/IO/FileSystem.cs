// <copyright file="FileSystem.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.IO;

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
            return File.ReadAllText(path);
        }

        /// <inheritdoc />
        public void WriteFileText(string path, string text)
        {
            File.WriteAllText(path, text);
        }

        /// <inheritdoc />
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
    }
}
