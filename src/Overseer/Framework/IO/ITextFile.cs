﻿// <copyright file="ITextFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    /// <summary>
    /// Represents a text file.
    /// </summary>
    public interface ITextFile
    {
        /// <summary>
        /// Reads the file text.
        /// </summary>
        /// <returns>The file text.</returns>
        string Read();

        /// <summary>
        /// Writes the specified text to the file.
        /// </summary>
        /// <param name="text">The text to write.</param>
        void Write(string text);
    }
}
