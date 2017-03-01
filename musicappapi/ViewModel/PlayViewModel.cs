using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Play table view model.
    /// </summary>
    public class PlayViewModel
    {
        public int Id { get; set; }
        public Nullable<int> TrackId { get; set; }
        public Nullable<int> OutputId { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
    }
}