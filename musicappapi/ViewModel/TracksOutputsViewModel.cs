using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Tracks & Output information.
    /// </summary>
    public class TracksOutputsViewModel
    {
        /// <summary>
        /// Gets or sets the track identifier.
        /// </summary>
        /// <value>
        /// The track identifier.
        /// </value>
        public int TrackId { get; set; }

        /// <summary>
        /// Gets or sets the output identifier.
        /// </summary>
        /// <value>
        /// The output identifier.
        /// </value>
        public int OutputId { get; set; }

        /// <summary>
        /// Gets or sets the last played.
        /// </summary>
        /// <value>
        /// The last played data of a track.
        /// </value>
        public DateTime? LastPlayed { get; set; }
    }
}