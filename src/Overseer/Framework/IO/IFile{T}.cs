// <copyright file="IFile{T}.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    /// <summary>
    /// Represents a file for reading and writing.
    /// </summary>
    /// <typeparam name="T">The type of the object to read and write.</typeparam>
    public interface IFile<T>
    {
        /// <summary>
        /// Reads the data from the file.
        /// </summary>
        /// <returns>The read data.</returns>
        T Read();

        /// <summary>
        /// Writes the specified data to the file.
        /// </summary>
        /// <param name="data">The data to write.</param>
        void Write(T data);
    }
}