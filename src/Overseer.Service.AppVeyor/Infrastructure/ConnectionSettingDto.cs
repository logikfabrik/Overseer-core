// <copyright file="ConnectionSettingDto.cs" company="Logikfabrik">
// Copyright (c) anton(at)logikfabrik.se. Licensed under the MIT license.
// </copyright>

namespace Overseer.Service.AppVeyor.Infrastructure
{
    using System.Xml.Serialization;

    /// <summary>
    /// DTO for settings for connecting to the AppVeyor CI/CD service.
    /// </summary>
    [XmlType("AppVeyor")]

    // ReSharper disable once InheritdocConsiderUsage
    public sealed class ConnectionSettingDto : Common.Infrastructure.ConnectionSettingDto
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }
    }
}
