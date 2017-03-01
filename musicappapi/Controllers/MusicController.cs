using System;
using System.Web.Http;
using MusicAppApi.Managers;
using MusicAppApi.DbModel;

namespace MusicAppApi.Controllers
{
    /// <summary>
    /// All the API's for the Music Applications.
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("api/Music")]
    public class MusicController : ApiController
    {
        #region --Init--

        private CoreManager tracksManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicController"/> class.
        /// </summary>
        public MusicController()
        {
            tracksManager = new CoreManager();
        }

        #endregion

        #region --Tracks API's--

        /// <summary>
        /// Returns all tracks from database.
        /// </summary>
        /// <returns></returns>
        [Route("Tracks")]
        [HttpGet]
        public IHttpActionResult GetTracks()
        {
            try
            {
                var result = tracksManager.GetTracks();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        /// <summary>
        /// Gets the track sets.
        /// </summary>
        /// <returns>Returns the list of Track sets</returns>
        [Route("TrackSets")]
        [HttpGet]
        public IHttpActionResult GetTrackSets()
        {
            try
            {
                var result = tracksManager.GetTrackSets();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the dates added.
        /// </summary>
        /// <returns>Returns the list of tracks with Dates added and ID info.</returns>
        [Route("AddedDates")]
        [HttpGet]
        public IHttpActionResult GetDatesAdded()
        {
            try
            {
                var result = tracksManager.GetDatesAddedInfo();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the genres of tracks.
        /// </summary>
        /// <returns></returns>
        [Route("Genres")]
        [HttpGet]
        public IHttpActionResult GetGenres()
        {
            try
            {
                var result = tracksManager.GetGenreInfo();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the decades.
        /// </summary>
        /// <returns>Returns List of tracks containing decade and Id information</returns>
        [Route("Decades")]
        [HttpGet]
        public IHttpActionResult GetDecades()
        {
            try
            {
                var result = tracksManager.GetDecadeInfo();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the decades.
        /// </summary>
        /// <returns>Returns List of tracks containing decade and Id information</returns>
        [Route("Tracks/Add")]
        [HttpPost]
        public IHttpActionResult Addtrack([FromBody] track trackInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var addedId = tracksManager.AddTrack(trackInfo);
                return Ok(addedId);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the tracks played.
        /// </summary>
        /// <returns>List of tracks played. (Mock Data)</returns>
        [Route("TracksPlayed")]
        [HttpGet]
        public IHttpActionResult GetTracksPlayed()
        {
            try
            {
                var result = tracksManager.GetTracksPlayed();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the playlist.
        /// </summary>
        /// <returns>List of Playlists. (Mock Data)</returns>
        [Route("Playlists")]
        [HttpGet]
        public IHttpActionResult GetPlaylist()
        {
            try
            {
                var result = tracksManager.GetPlaylist();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the tracks track sets.
        /// </summary>
        /// <returns>List of tracks and tracksets. (Mock Data)</returns>
        [Route("Tracks/TrackSets")]
        [HttpGet]
        public IHttpActionResult GetTracksTrackSets()
        {
            try
            {
                var result = tracksManager.GetTrackTrackSets();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Gets the tracks track sets.
        /// </summary>
        /// <returns>List of tracks and tracksets</returns>
        [Route("Tracks/Outputs")]
        [HttpGet]
        public IHttpActionResult GetTracksOutputs()
        {
            try
            {
                var result = tracksManager.GetTracksOutputs();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        #endregion

        #region --Output API's--

        /// <summary>
        /// Gets the outputs.
        /// </summary>
        /// <returns>Returns the list of outputs.</returns>
        [Route("Outputs")]
        [HttpGet]
        public IHttpActionResult GetOutputs()
        {
            try
            {
                var result = tracksManager.GetOutputs();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        #endregion

        #region --Condition API's--

        /// <summary>
        /// Gets the conditions.
        /// </summary>
        /// <returns>Returns the list of conditions.</returns>
        [Route("Conditions")]
        [HttpGet]
        public IHttpActionResult GetConditions()
        {
            try
            {
                var result = tracksManager.GetConditions();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        #endregion

        #region --Play API's--

        /// <summary>
        /// Gets the plays.
        /// </summary>
        /// <returns>Returns the list of Plays.</returns>
        [Route("Play")]
        [HttpGet]
        public IHttpActionResult GetPlays()
        {
            try
            {
                var result = tracksManager.GetPlays();

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        #endregion
    }
}