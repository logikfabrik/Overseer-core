// <copyright file="Branch.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a VCS branch.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Branch : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Branch" /> class.
        /// </summary>
        /// <param name="name">The VCS branch name.</param>
        private Branch(string name)
        {
            Name = name ?? string.Empty;
        }

        /// <summary>
        /// Gets the VCS branch name.
        /// </summary>
        /// <value>
        /// The VCS branch name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="Branch" /> class.
        /// </summary>
        /// <param name="name">The VCS branch name.</param>
        /// <returns>A new instance of the <see cref="Branch" /> class.</returns>
        public static Branch Create(string name)
        {
            return new Branch(name);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Name.Equals(((User)obj).Name);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
