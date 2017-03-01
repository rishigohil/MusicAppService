using MusicAppApi.Areas.Helper;
using MusicAppApi.Areas.MockData;
using MusicAppApi.DbModel;
using MusicAppApi.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace MusicAppApi.Managers
{
    /// <summary>
    /// This class contains Core functions to fetch or add data into the Database.
    /// </summary>
    public class CoreManager
    {
        #region --Track Methods--

        /// <summary>
        /// Gets the tracks.
        /// </summary>
        /// <returns>List of track records</returns>
        public List<TracksViewModel> GetTracks()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                
                //Gets all data from the tracks table as TracksViewModel.
                var query = db.tracks.Select(x => new TracksViewModel()
                {
                    Id = x.Id,
                    Path = x.Path,
                    Title = x.Title,
                    Artist = x.Artist,
                    Genre = x.Genre,
                    Year = x.Year,
                    DateAdded = x.DateAdded,
                    Duration = x.Duration,
                    Gain = x.Gain,
                    Peak = x.Peak,
                    PlaybackError = x.PlaybackError,
                    RandomFactor = x.RandomFactor
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        /// <summary>
        /// Gets the track sets.
        /// </summary>
        /// <returns>List of Track set records</returns>
        public List<TrackSetsViewModel> GetTrackSets()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                
                //Gets TrackSets information by joining from Tracks and Tracks_TrackSets tables.
                var query = db.TrackSets.Include("Tracks_TrackSets").Select(b => new TrackSetsViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Description = b.Description,
                    Tracks = (from t in db.tracks
                              where b.Tracks_TrackSets.Select(x => x.TrackId).Contains(t.Id)
                              select new TracksViewModel() {
                                  Id = t.Id,
                                  Path = t.Path,
                                  Artist = t.Artist,
                                  Genre = t.Genre,
                                  Year = t.Year,
                                  DateAdded = t.DateAdded,
                                  Duration = t.Duration,
                                  Gain = t.Gain,
                                  Peak = t.Peak,
                                  PlaybackError = t.PlaybackError,
                                  RandomFactor = t.RandomFactor
                              }).ToList()
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        /// <summary>
        /// Gets the dates added information.
        /// </summary>
        /// <returns>Returns the list of tracks with ID & Dates Added info.</returns>
        public List<DatesAdded> GetDatesAddedInfo()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                
                //Gets dates added info for tracks.
                var query = db.tracks.Select(a => new DatesAdded()
                {
                    Id = a.Id,
                    DateAdded = a.DateAdded
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        /// <summary>
        /// Gets the genre information.
        /// </summary>
        /// <returns>Returns the list of tracks with its genre information and ID.</returns>
        public List<Genre> GetGenreInfo()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                //Gets genres of tracks as Genre ViewModel.
                var query = db.tracks.AsEnumerable().Select(a => new Genre()
                {
                    Id = a.Id,
                    text = string.IsNullOrEmpty(a.Genre) ? "N/A" : a.Genre
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        /// <summary>
        /// Gets the decade information.
        /// </summary>
        /// <returns></returns>
        public List<Genre> GetDecadeInfo()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                //Gets the decade information and calls upon the custom 
                //function in Corehelper which returns the specified text as per data.
                var query = db.tracks.AsEnumerable().Select(a => new Genre()
                {
                    Id = a.Id,
                    text = (a.Year == null) ? "N/A" : CoreHelper.GetDecade(a.Year)
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        /// <summary>
        /// Adds the track.
        /// </summary>
        /// <param name="track">The track.</param>
        public int AddTrack(track track)
        {
            using (var db = new musicdbEntities())
            {
                db.tracks.Add(track);
                db.SaveChanges();

                return track.Id;
            }
        }

        /// <summary>
        /// Gets the tracks played.
        /// </summary>
        /// <returns>Mock Data</returns>
        public List<TrackPlayed> GetTracksPlayed()
        {
            //Mock Data
            return MockDataContainer.GenTrackPlayedData();
        }


        /// <summary>
        /// Gets the playlist.
        /// </summary>
        /// <returns>Mock Data</returns>
        public List<PlaylistInfo> GetPlaylist()
        {
            //Mock Data
            return MockDataContainer.GenPlaylistInfo();
        }

        /// <summary>
        /// Gets the track track sets mock data.
        /// </summary>
        /// <returns></returns>
        public List<TracksTrackSetsViewModel> GetTrackTrackSets()
        {
            //Mock Data
            return MockDataContainer.GetTrackTrackSetsMockData();
        }

        /// <summary>
        /// Gets the track and outputs data.
        /// </summary>
        /// <returns>List of tracks and outputs data</returns>
        public List<TracksOutputsViewModel> GetTracksOutputs()
        {
            //Mock Data
            return MockDataContainer.GetTracksOutputsData();
        }
        #endregion

        #region --Output Methods--

        /// <summary>
        /// Gets the outputs.
        /// </summary>
        /// <returns>Returns list of Output records</returns>
        public List<OutputViewModel> GetOutputs()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                var query = db.Outputs.Select(a => new OutputViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    Sets = a.Conditions.Select(b => b.TrackSet).ToList(),
                    ConditionIds = a.Conditions.Select(c => c.Id).ToList()
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        #endregion

        #region --Conditions Methods--

        /// <summary>
        /// Gets the conditions.
        /// </summary>
        /// <returns>Returns list of Condition records</returns>
        public List<ConditionsViewModel> GetConditions()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                var query = db.Conditions.Include("TrackSets").Select(x => new ConditionsViewModel()
                {
                    Id = x.Id,
                    Name = (from ts in db.Tracks_TrackSets
                            join t in db.tracks on ts.TrackId equals t.Id
                            where ts.TrackSetId == x.TrackSetId
                            select t.Title).FirstOrDefault(),
                    TrackSetId = x.TrackSetId,
                    OutputId = x.OutputId,
                    AbsoluteStartDate = x.AbsoluteStartDate,
                    AbsoluteEndDate = x.AbsoluteEndDate,
                    AnnualStartDate = x.AnnualStartDate,
                    AnnualEndDate = x.AnnualEndDate,
                    DaysOfWeek = x.DaysOfWeek,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    Priority = x.Priority
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        #endregion

        #region --Play Methods--

        /// <summary>
        /// Gets the conditions.
        /// </summary>
        /// <returns>Returns list of Condition records</returns>
        public List<PlayViewModel> GetPlays()
        {
            using (var db = new musicdbEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                var query = db.Plays.Select(x => new PlayViewModel()
                {
                    Id = x.Id,
                    TrackId = x.TrackId,
                    OutputId = x.OutputId,
                    Time = x.TimePlayed
                }).ToList();

                if (query == null || query.Count == 0)
                {
                    return null;
                }
                return query;
            }
        }

        #endregion
    }
}