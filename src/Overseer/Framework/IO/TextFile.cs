// <copyright file="TextFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.IO;
    using EnsureThat;

    /// <inheritdoc />
    public class TextFile : ITextFile
    {
        private readonly IFileSystem _fileSystem;
        private readonly string _path;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextFile" /> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="path">The path to the file to read from and write to.</param>
        public TextFile(IFileSystem fileSystem, string path)
        {
            EnsureArg.IsNotNull(fileSystem);
            EnsureArg.IsNotNullOrEmpty(path);

            _fileSystem = fileSystem;
            _path = path;
        }

        /// <inheritdoc />
        public virtual string Read()
        {
            return _fileSystem.FileExists(_path) ? _fileSystem.ReadFileText(_path) : null;
        }

        /// <inheritdoc />
        public virtual void Write(string text)
        {
            _fileSystem.CreateDirectory(Path.GetDirectoryName(_path));
            _fileSystem.WriteFileText(_path, text);
        }
    }
}