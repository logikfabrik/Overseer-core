// <copyright file="IConnectionSettingDtoFile.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Infrastructure
{
    using Overseer.Common.Infrastructure;

    /// <summary>
    /// Represents a file for reading connection settings from and writing connection settings to.
    /// </summary>
    internal interface IConnectionSettingDtoFile
    {
        /// <summary>
        /// Reads connection settings from the file.
        /// </summary>
        /// <returns>The read connection settings.</returns>
        ConnectionSettingDto[] Read();

        /// <summary>
        /// Writes the specified connection settings to the file.
        /// </summary>
        /// <param name="connectionSettings">The connection settings to write.</param>
        void Write(ConnectionSettingDto[] connectionSettings);
    }
}