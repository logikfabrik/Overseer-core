// <copyright file="IOSFileSystem.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Framework.IO
{
    /// <summary>
    /// Represents the OS file system.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public interface IOSFileSystem
    {
        void WriteUTF8File(string path, string data);

        string ReadUTF8File(string path);
    }
}
