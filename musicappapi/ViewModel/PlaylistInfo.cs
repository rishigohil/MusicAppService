using System;
using System.Collections.Generic;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Platlist Info View Model
    /// </summary>
    public class PlaylistInfo
    {
        /// <summary>
        /// Gets or sets the return.
        /// </summary>
        /// <value>
        /// The return.
        /// </value>
        public IEnumerable<PlaylistItem> Return { get; set; }

        /// <summary>
        /// Gets or sets the output identifier.
        /// </summary>
        /// <value>
        /// The output identifier.
        /// </value>
        public int OutputId { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        public int Limit { get; set; }
    }
}