// <copyright file="IBootstrapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Common.Domain.Model
{
    /// <summary>
    /// Represents a bootstrapper for bootstrapping domain services, handles, and such.
    /// </summary>
    public interface IBootstrapper
    {
        /// <summary>
        /// Runs this bootstrapper.
        /// </summary>
        void Run();
    }
}
