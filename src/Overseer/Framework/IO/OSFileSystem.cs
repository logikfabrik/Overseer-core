// <copyright file="OSFileSystem.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.IO;
    using EnsureThat;

    /// <summary>
    /// The OS file system.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    // ReSharper disable once InconsistentNaming
    public class OSFileSystem : IOSFileSystem
    {
        private readonly IOSDirectory _osDirectory;
        private readonly IOSFile _osFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="OSFileSystem" /> class.
        /// </summary>
        /// <param name="osDirectory">The OS file system; portions for working with directories.</param>
        /// <param name="osFile">The OS file system; portions for working with files.</param>
        public OSFileSystem(IOSDirectory osDirectory, IOSFile osFile)
        {
            EnsureArg.IsNotNull(osDirectory);
            EnsureArg.IsNotNull(osFile);

            _osDirectory = osDirectory;
            _osFile = osFile;
        }

        /// <inheritdoc />
        public void WriteUTF8File(string path, string data)
        {
            if (!Path.IsPathRooted(path))
            {
                path = Path.Combine(_osDirectory.GetCurrent(), path);
            }

            _osDirectory.Create(Path.GetDirectoryName(path));

            _osFile.WriteUTF8(path, data);
        }

        /// <inheritdoc />
        public string ReadUTF8File(string path)
        {
            if (!Path.IsPathRooted(path))
            {
                path = Path.Combine(_osDirectory.GetCurrent(), path);
            }

            return !_osFile.Exists(path) ? null : _osFile.ReadUTF8(path);
        }
    }
}
