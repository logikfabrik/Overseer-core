// <copyright file="UTF8File.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using EnsureThat;

    /// <summary>
    /// An UTF-8 file.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    // ReSharper disable once InconsistentNaming
    public class UTF8File : IFile<string>
    {
        private readonly IOSFileSystem _osFileSystem;
        private readonly string _path;

        /// <summary>
        /// Initializes a new instance of the <see cref="UTF8File" /> class.
        /// </summary>
        /// <param name="osFileSystem">The OS file system.</param>
        /// <param name="path">The path to the file to read from and write to.</param>
        public UTF8File(IOSFileSystem osFileSystem, string path)
        {
            EnsureArg.IsNotNull(osFileSystem);
            EnsureArg.IsNotNullOrEmpty(path);

            _osFileSystem = osFileSystem;
            _path = path;
        }

        /// <inheritdoc />
        public virtual string Read()
        {
            return _osFileSystem.ReadUTF8File(_path);
        }

        /// <inheritdoc />
        public virtual void Write(string data)
        {
            _osFileSystem.WriteUTF8File(_path, data);
        }
    }
}