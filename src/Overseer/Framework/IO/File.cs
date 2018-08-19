// <copyright file="File.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using EnsureThat;

    /// <summary>
    /// A file for reading and writing.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public class File : IFile<byte[]>
    {
        private readonly IOSFileSystem _osFileSystem;
        private readonly string _path;

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="osFileSystem">The OS file system.</param>
        /// <param name="path">The path to the file to read from and write to.</param>
        public File(IOSFileSystem osFileSystem, string path)
        {
            EnsureArg.IsNotNull(osFileSystem);
            EnsureArg.IsNotNullOrEmpty(path);

            _osFileSystem = osFileSystem;
            _path = path;
        }

        /// <inheritdoc />
        public byte[] Read()
        {
            return _osFileSystem.ReadFile(_path);
        }

        /// <inheritdoc />
        public void Write(byte[] data)
        {
            _osFileSystem.WriteFile(_path, data);
        }
    }
}
