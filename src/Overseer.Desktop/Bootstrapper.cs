// <copyright file="Bootstrapper.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Desktop
{
    using System.Collections.Generic;
    using EnsureThat;
    using Overseer.Common.Domain;

    /// <summary>
    /// Represents a client bootstrapper for running library bootstrappers.
    /// </summary>
    public sealed class Bootstrapper
    {
        private readonly IEnumerable<IBootstrapper> _bootstrappers;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bootstrapper" /> class.
        /// </summary>
        /// <param name="bootstrappers">The library bootstrappers.</param>
        public Bootstrapper(IEnumerable<IBootstrapper> bootstrappers)
        {
            EnsureArg.IsNotNull(bootstrappers);

            _bootstrappers = bootstrappers;
        }

        /// <summary>
        /// Runs this bootstrapper.
        /// </summary>
        public void Run()
        {
            foreach (var bootstrapper in _bootstrappers)
            {
                bootstrapper.Run();
            }
        }
    }
}
