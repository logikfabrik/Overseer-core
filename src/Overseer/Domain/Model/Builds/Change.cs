// <copyright file="Change.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Domain.Model.Builds
{
    using System;
    using System.Linq;
    using EnsureThat;
    using Overseer.Common.Domain.Model;

    /// <summary>
    /// Represents a VCS change.
    /// </summary>
    // ReSharper disable once InheritdocConsiderUsage
    public sealed class Change : IValueType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Change" /> class.
        /// </summary>
        /// <param name="id">The VCS identifier.</param>
        /// <param name="changeTime">The date and time the change was made.</param>
        /// <param name="changedBy">Whoever made the change.</param>
        /// <param name="message">A message, if any.</param>
        private Change(string id, DateTime changeTime, User changedBy, string message)
        {
            EnsureArg.IsNotNullOrEmpty(id);
            EnsureArg.IsNotNull(changedBy);

            Id = id;
            ChangeTime = changeTime;
            ChangedBy = changedBy;
            Message = message ?? string.Empty;
        }

        /// <summary>
        /// Gets the VCS identifier.
        /// </summary>
        /// <value>
        /// The VCS identifier.
        /// </value>
        public string Id { get; }

        /// <summary>
        /// Gets the date and time the change was made.
        /// </summary>
        /// <value>
        /// The date and time the change was made.
        /// </value>
        public DateTime ChangeTime { get; }

        /// <summary>
        /// Gets whoever made the change.
        /// </summary>
        /// <value>
        /// Whoever made the change.
        /// </value>
        public User ChangedBy { get; }

        /// <summary>
        /// Gets the message, if any.
        /// </summary>
        /// <value>
        /// The message, if any.
        /// </value>
        public string Message { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="Change" /> class.
        /// </summary>
        /// <param name="id">The VCS identifier.</param>
        /// <param name="changeTime">The date and time the change was made.</param>
        /// <param name="changedBy">Whoever made the change.</param>
        /// <param name="message">A message, if any.</param>
        /// <returns>A new instance of the <see cref="Change" /> class.</returns>
        public Change Create(string id, DateTime changeTime, User changedBy, string message)
        {
            return new Change(id, changeTime, changedBy, message);
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

            var o = (Change)obj;

            return new object[]
            {
                Id,
                ChangeTime,
                ChangedBy,
                Message
            }.SequenceEqual(new object[]
            {
                o.Id,
                o.ChangeTime,
                o.ChangedBy,
                o.Message
            });
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCodeUtility.GetHashCode(new object[] { Id, ChangeTime, ChangedBy, Message });
        }
    }
}
