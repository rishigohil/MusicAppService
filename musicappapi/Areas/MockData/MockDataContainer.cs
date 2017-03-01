using MusicAppApi.ViewModel;
using System;
using System.Collections.Generic;

namespace MusicAppApi.Areas.MockData
{
    /// <summary>
    /// This class contains functions sending required Mock data.
    /// </summary>
    public static class MockDataContainer
    {
        /// <summary>
        /// Generates the track played mock data.
        /// </summary>
        /// <returns></returns>
        public static List<TrackPlayed> GenTrackPlayedData()
        {
            var result = new List<TrackPlayed>()
            {
                new TrackPlayed() {
                    Id = 2,
                    ReturnCode = 1,
                    Success = true
                },
                new TrackPlayed() {
                    Id = 3,
                    ReturnCode = 2,
                    Success = false
                },
                new TrackPlayed() {
                    Id = 4,
                    ReturnCode = 3,
                    Success = true
                },
                new TrackPlayed() {
                    Id = 5,
                    ReturnCode = 4,
                    Success = false
                }
            };

            return result;
        }

        /// <summary>
        /// Generates the playlist mock data.
        /// </summary>
        /// <returns></returns>
        public static List<PlaylistInfo> GenPlaylistInfo()
        {
            var result = new List<PlaylistInfo>()
            {
                new PlaylistInfo()
                {
                    Limit = 2,
                    OutputId = 1,
                    Return = new List<PlaylistItem>()
                    {
                        new PlaylistItem() { Id=2 }
                    },
                    TimeZone = TimeZone.CurrentTimeZone
                },
                new PlaylistInfo()
                {
                    Limit = 3,
                    OutputId = 2,
                    Return = new List<PlaylistItem>()
                    {
                        new PlaylistItem() { Id=3 }
                    },
                    TimeZone = TimeZone.CurrentTimeZone
                }
            };

            return result;
        }

        /// <summary>
        /// Gets the track track sets mock data.
        /// </summary>
        /// <returns></returns>
        public static List<TracksTrackSetsViewModel> GetTrackTrackSetsMockData() {
            var result = new List<TracksTrackSetsViewModel>()
            {
                new TracksTrackSetsViewModel()
                {
                    TrackId = 2,
                    TrackSetId = 3
                },
                new TracksTrackSetsViewModel()
                {
                    TrackId = 3,
                    TrackSetId = 4
                },
                new TracksTrackSetsViewModel()
                {
                    TrackId = 4,
                    TrackSetId = 5
                }
            };

            return result;
        }

        /// <summary>
        /// Gets the tracks outputs data.
        /// </summary>
        /// <returns></returns>
        public static List<TracksOutputsViewModel> GetTracksOutputsData()
        {
            var result = new List<TracksOutputsViewModel>()
            {
                new TracksOutputsViewModel()
                {
                    TrackId = 2,
                    OutputId = 3,
                    LastPlayed = DateTime.Now
                },
                new TracksOutputsViewModel()
                {
                    TrackId = 3,
                    OutputId = 4,
                    LastPlayed = DateTime.Now.AddDays(-2)
                },
                new TracksOutputsViewModel()
                {
                    TrackId = 4,
                    OutputId = 5,
                    LastPlayed = DateTime.Now.AddDays(-3)
                }
            };

            return result;
        }
    }
}