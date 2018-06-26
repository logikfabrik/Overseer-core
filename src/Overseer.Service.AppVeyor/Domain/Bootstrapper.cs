// <copyright file="Bootstrapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Domain
{
    using Overseer.Common.Domain;

    /// <inheritdoc />
    public sealed class Bootstrapper : IBootstrapper
    {
        /// <inheritdoc />
        public void Run()
        {
            Model.Services.Service.Create();
        }
    }
}
