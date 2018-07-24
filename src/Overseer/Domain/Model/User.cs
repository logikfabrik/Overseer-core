// <copyright file="User.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model
{
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// A CI/CD/VCS user.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class User : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="name">The CI/CD/VCS user name.</param>
        private User(string name)
        {
            EnsureArg.IsNotNullOrEmpty(name);

            Name = name;
        }

        /// <summary>
        /// Gets the CI/CD/VCS user name.
        /// </summary>
        /// <value>
        /// The CI/CD/VCS user name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="name">The CI/CD/VCS user name.</param>
        /// <returns>A new instance of the <see cref="User" /> class.</returns>
        public static User Create(string name)
        {
            return new User(name);
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
