// <copyright file="OSDirectory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    using System.IO;

    /// <summary>
    /// The OS file system; portions for working with directories.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    // ReSharper disable once InconsistentNaming
    public class OSDirectory : IOSDirectory
    {
        /// <inheritdoc />
        public void Create(string path)
        {
            Directory.CreateDirectory(path);
        }

        /// <inheritdoc />
        public string GetCurrent()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
