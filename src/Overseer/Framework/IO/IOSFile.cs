// <copyright file="IOSFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    /// <summary>
    /// Represents the OS file system; portions for working with files.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public interface IOSFile
    {
        /// <summary>
        /// Determines whether the file exists.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns><c>true</c> if the file exists; otherwise, <c>false</c>.</returns>
        bool Exists(string path);

        /// <summary>
        /// Opens a file, reads the UTF-8 encoded text from the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The text.</returns>
        // ReSharper disable once InconsistentNaming
        string ReadUTF8(string path);

        /// <summary>
        /// Creates a file, writes the UTF-8 encoded text to the file, and then closes the file. If the file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <param name="text">The text.</param>
        // ReSharper disable once InconsistentNaming
        void WriteUTF8(string path, string text);
    }
}