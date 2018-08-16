// <copyright file="IOSDirectory.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    /// <summary>
    /// Represents the OS file system; portions for working with directories.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public interface IOSDirectory
    {
        /// <summary>
        /// Creates a directory, if it doesn't already exist.
        /// </summary>
        /// <param name="path">The directory path.</param>
        void Create(string path);

        /// <summary>
        /// Gets the current directory path.
        /// </summary>
        /// <returns>The current directory path.</returns>
        string GetCurrent();
    }
}
