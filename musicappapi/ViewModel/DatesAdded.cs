using System;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Dates Added View model
    /// </summary>
    public class DatesAdded
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date added of the track.
        /// </summary>
        /// <value>
        /// The date added.
        /// </value>
        public DateTime? DateAdded { get; set; }
    }
}