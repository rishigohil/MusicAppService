using MusicAppApi.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Output View model.
    /// </summary>
    public class OutputViewModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the track sets.
        /// </summary>
        /// <value>
        /// The sets.
        /// </value>
        public List<TrackSet> Sets { get; set; }

        /// <summary>
        /// Gets or sets the condition ids.
        /// </summary>
        /// <value>
        /// The condition ids.
        /// </value>
        public List<int> ConditionIds { get; set; }
    }
}