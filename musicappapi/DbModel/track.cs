//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicAppApi.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class track
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public track()
        {
            this.Plays = new HashSet<Play>();
            this.Tracks_Outputs = new HashSet<Tracks_Outputs>();
            this.Tracks_TrackSets = new HashSet<Tracks_TrackSets>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Play> Plays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracks_Outputs> Tracks_Outputs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracks_TrackSets> Tracks_TrackSets { get; set; }
    }
}
