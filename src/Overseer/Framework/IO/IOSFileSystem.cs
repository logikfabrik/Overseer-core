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
        string ReadUTF8File(string path);

        byte[] ReadFile(string path);

        void WriteUTF8File(string path, string data);

        void WriteFile(string path, byte[] data);
    }
}
