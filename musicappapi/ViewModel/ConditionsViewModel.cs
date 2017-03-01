using System;

namespace MusicAppApi.ViewModel
{
    /// <summary>
    /// Conditions table View model
    /// </summary>
    public class ConditionsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> TrackSetId { get; set; }
        public Nullable<int> OutputId { get; set; }
        public Nullable<System.DateTime> AbsoluteStartDate { get; set; }
        public Nullable<System.DateTime> AbsoluteEndDate { get; set; }
        public Nullable<System.DateTime> AnnualStartDate { get; set; }
        public Nullable<System.DateTime> AnnualEndDate { get; set; }
        public Nullable<byte> DaysOfWeek { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<byte> Priority { get; set; }
    }
}