using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Tracks view model
    /// </summary>
    public class TracksViewModel
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public Nullable<short> Year { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<long> Duration { get; set; }
        public Nullable<decimal> Gain { get; set; }
        public Nullable<decimal> Peak { get; set; }
        public Nullable<bool> PlaybackError { get; set; }
        public Nullable<int> RandomFactor { get; set; }
    }
}