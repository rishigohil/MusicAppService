using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Track Played View Model
    /// </summary>
    public class TrackPlayed
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the return code.
        /// </summary>
        /// <value>
        /// The return code.
        /// </value>
        public int ReturnCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TrackPlayed"/> is success.
        /// </summary>
        /// <value>
        ///   <c>true</c> if success; otherwise, <c>false</c>.
        /// </value>
        public bool Success { get; set; }
    }
}