using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.Spotify
{
    /// <summary>
    /// <c>SpotifyAccessToken</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/general/guides/authorization/</seealso>
    public class SpotifyAccessToken
    {
        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/general/guides/authorization/</seealso>
        [EpicAkSPropertyNameAliasAttribute("access_token")]
        public string? AccessToken { get; set; }

        /// <value>
        /// <c>TokenType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/general/guides/authorization/</seealso>
        [EpicAkSPropertyNameAliasAttribute("token_type")]
        public string? TokenType { get; set; }

        /// <value>
        /// <c>TokenType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/general/guides/authorization/</seealso>
        [EpicAkSPropertyNameAliasAttribute("scope")]
        public string? Scope { get; set; }

        /// <value>
        /// <c>TokenType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/general/guides/authorization/</seealso>
        [EpicAkSPropertyNameAliasAttribute("expires_in")]
        public string? ExpiresIn { get; set; }

        /// <value>
        /// <c>TokenType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/general/guides/authorization/</seealso>
        [EpicAkSPropertyNameAliasAttribute("refresh_token")]
        public string? RefreshToken { get; set; }
    }

    /// <summary>
    /// <c>AlbumObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class AlbumObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("album_type")]
        public string? AlbumType { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("artists")]
        public ArtistObject[]? Artists { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_ids")]
        public ExternalIdObject? ExternalIds { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("genres")]
        public string[]? Genres { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("label")]
        public string? Label { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public AlbumRestrictionObject? Restrictions { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public SimplifiedTrackObject[]? Tracks { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>AlbumRestrictionObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class AlbumRestrictionObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }
    }

    /// <summary>
    /// <c>ArtistObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ArtistObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("genres")]
        public string[]? Genres { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>AudioFeaturesObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class AudioFeaturesObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("acousticness")]
        public float Acousticness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("analysis_url")]
        public string? AnalysisUrl { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("danceability")]
        public float Danceability { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("energy")]
        public float Energy { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("instrumentalness")]
        public float Instrumentalness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("key")]
        public int Key { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("liveness")]
        public float Liveness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("loudness")]
        public float Loudness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("mode")]
        public int Mode { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("speechiness")]
        public float Speechiness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("tempo")]
        public float Tempo { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("time_signature")]
        public int TimeSignature { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("track_href")]
        public string? TrackHref { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("valence")]
        public float Valence { get; set; }
    }

    /// <summary>
    /// <c>CategoryObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class CategoryObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("icons")]
        public ImageObject[]? Icons { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// <c>ContextObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ContextObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>CopyrightObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class CopyrightObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("text")]
        public string? Text { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }
    }

    /// <summary>
    /// <c>CurrentlyPlayingContextObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class CurrentlyPlayingContextObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("actions")]
        public DisallowsObject? Actions { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("device")]
        public DeviceObject? Device { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_playing")]
        public bool IsPlaying { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("item")]
        public object? Item { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("progress_ms")]
        public int ProgressMs { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("repeat_state")]
        public string? RepeatState { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("shuffle_state")]
        public string? ShuffleState { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("timestamp")]
        public int Timestamp { get; set; }
    }

    /// <summary>
    /// <c>CurrentlyPlayingObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class CurrentlyPlayingObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_playing")]
        public bool IsPlaying { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("item")]
        public object? Item { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("progress_ms")]
        public int ProgressMs { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("timestamp")]
        public int Timestamp { get; set; }
    }

    /// <summary>
    /// <c>CursorObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class CursorObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("after")]
        public string? After { get; set; }
    }

    /// <summary>
    /// <c>CursorPagingObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class CursorPagingObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("cursors")]
        public CursorObject? Cursors { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("items")]
        public Object[]? Items { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("limit")]
        public int Limit { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("next")]
        public string? Next { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// <c>DeviceObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class DeviceObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_active")]
        public bool IsActive { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_private_session")]
        public bool IsPrivateSession { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_restricted")]
        public bool IsRestricted { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("volume_percent")]
        public int VolumePercent { get; set; }
    }

    /// <summary>
    /// <c>DevicesObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class DevicesObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("devices")]
        public DeviceObject[]? Devices { get; set; }
    }

    /// <summary>
    /// <c>DisallowsObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class DisallowsObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("interrupting_playback")]
        public bool InterruptingPlayback { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("pausing")]
        public bool Pausing { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("resuming")]
        public bool Resuming { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("seeking")]
        public bool Seeking { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("skipping_next")]
        public bool SkippingNext { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("skipping_prev")]
        public bool SkippingPrev { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("toggling_repeat_context")]
        public bool TogglingRepeatContext { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("toggling_repeat_track")]
        public bool TogglingRepeatTrack { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("toggling_shuffle")]
        public bool TogglingShuffle { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("transferring_playback")]
        public bool TransferringPlayback { get; set; }
    }

    /// <summary>
    /// <c>DisallowsObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class EpisodeObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("audio_preview_url")]
        public string? AudioPreviewUrl { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("language")]
        public string? Language { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("resume_point")]
        public ResumePointObject? ResumePoint { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("show")]
        public SimplifiedShowObject? Show { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>ErrorObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ErrorObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("message")]
        public string? Message { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("status")]
        public int Status { get; set; }
    }

    /// <summary>
    /// <c>ExplicitContentSettingsObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ExplicitContentSettingsObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("filter_enabled")]
        public bool FilterEnabled { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("filter_locked")]
        public bool FilterLocked { get; set; }
    }

    /// <summary>
    /// <c>ExternalIdObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ExternalIdObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("ean")]
        public string? Ean { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("isrc")]
        public string? Isrc { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("upc")]
        public string? Upc { get; set; }
    }

    /// <summary>
    /// <c>ExternalUrlObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ExternalUrlObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("spotify")]
        public string? Spotify { get; set; }
    }

    /// <summary>
    /// <c>FollowersObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class FollowersObject
    {

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// <c>ImageObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ImageObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("height")]
        public int Height { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("url")]
        public string? Url { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("width")]
        public int Width { get; set; }
    }

    /// <summary>
    /// <c>ImageObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class LinkedTrackObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>PagingObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PagingObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("items")]
        public Object[]? Items { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("limit")]
        public int Limit { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("next")]
        public string? Next { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("offset")]
        public int Offset { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("previous")]
        public string? Previous { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// <c>PlayHistoryObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PlayHistoryObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("played_at")]
        public string? PlayedAt { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("track")]
        public SimplifiedTrackObject? Track { get; set; }
    }

    /// <summary>
    /// <c>PlayerErrorObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PlayerErrorObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("message")]
        public string? Message { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("status")]
        public int Status { get; set; }
    }

    /// <summary>
    /// <c>PlaylistObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PlaylistObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("collaborative")]
        public bool Collaborative { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("owner")]
        public PublicUserObject? Owner { get; set; }


        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public PlaylistTrackObject[]? Tracks { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>PlaylistTrackObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PlaylistTrackObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("added_by")]
        public PublicUserObject? AddedBy { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("track")]
        public object? Track { get; set; }
    }

    /// <summary>
    /// <c>PlaylistTracksRefObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PlaylistTracksRefObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// <c>SpotifyUserObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SpotifyUserObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("country")]
        public string? Country { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("display_name")]
        public string? DisplayName { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("email")]
        public string? Email { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("explicit_content")]
        public ExplicitContentSettingsObject? ExplicitContent { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("product")]
        public string? Product { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>PublicUserObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class PublicUserObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("display_name")]
        public string? DisplayName { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>RecommendationSeedObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class RecommendationSeedObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("afterFilteringSize")]
        public int AfterFilteringSize { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("afterRelinkingSize")]
        public int AfterRelinkingSize { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("initialPoolSize")]
        public int InitialPoolSize { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }
    }

    /// <summary>
    /// <c>RecommendationsObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class RecommendationsObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("seeds")]
        public RecommendationSeedObject[]? Seeds { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public SimplifiedTrackObject[]? Tracks { get; set; }
    }

    /// <summary>
    /// <c>ResumePointObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ResumePointObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("fully_played")]
        public bool FullyPlayed { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("resume_position_ms")]
        public int ResumePositionMs { get; set; }
    }

    /// <summary>
    /// <c>SavedAlbumObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SavedAlbumObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("album")]
        public AlbumObject? Album { get; set; }
    }

    /// <summary>
    /// <c>SavedShowObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SavedShowObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("show")]
        public SimplifiedShowObject? Show { get; set; }
    }

    /// <summary>
    /// <c>SavedTrackObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SavedTrackObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("track")]
        public TrackObject? Track { get; set; }
    }

    /// <summary>
    /// <c>ShowObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class ShowObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("episodes")]
        public SimplifiedEpisodeObject[]? Episodes { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("media_type")]
        public string? MediaType { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("publisher")]
        public string? Publisher { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>SimplifiedAlbumObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SimplifiedAlbumObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("album_group")]
        public string? AlbumGroup { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("album_type")]
        public string? AlbumType { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("artists")]
        public SimplifiedArtistObject[]? Artists { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public AlbumRestrictionObject? Restrictions { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>SimplifiedArtistObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SimplifiedArtistObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>SimplifiedEpisodeObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SimplifiedEpisodeObject
    {

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("audio_preview_url")]
        public string? AudioPreviewUrl { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("language")]
        public string? Language { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("resume_point")]
        public ResumePointObject? ResumePoint { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>SimplifiedPlaylistObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SimplifiedPlaylistObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("collaborative")]
        public bool Collaborative { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("owner")]
        public PublicUserObject? Owner { get; set; }


        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public PlaylistTracksRefObject? Tracks { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>SimplifiedShowObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SimplifiedShowObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }


        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("media_type")]
        public string? MediaType { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("publisher")]
        public string? Publisher { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>SimplifiedTrackObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class SimplifiedTrackObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("artists")]
        public SimplifiedArtistObject[]? Artists { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("disc_number")]
        public int DiscNumber { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("linked_from")]
        public LinkedTrackObject? LinkedFrom { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public TrackRestrictionObject? Restrictions { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("track_number")]
        public int TrackNumber { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>TrackObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class TrackObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("album")]
        public SimplifiedAlbumObject? Album { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("artists")]
        public ArtistObject[]? Artists { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("disc_number")]
        public int DiscNumber { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_ids")]
        public ExternalIdObject? ExternalIds { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("linked_from")]
        public TrackObject? LinkedFrom { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public TrackRestrictionObject? Restrictions { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("track_number")]
        public int TrackNumber { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    /// <summary>
    /// <c>TrackRestrictionObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class TrackRestrictionObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }
    }

    /// <summary>
    /// <c>TuneableTrackObject</c> Refer to docs URI link web page.
    /// </summary>
    /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
    public class TuneableTrackObject
    {
        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("acousticness")]
        public float Acousticness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("danceability")]
        public float Danceability { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("energy")]
        public float Energy { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("instrumentalness")]
        public float Instrumentalness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("key")]
        public int Key { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("liveness")]
        public float Liveness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("loudness")]
        public float Loudness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("mode")]
        public int Mode { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public float Popularity { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("speechiness")]
        public float Speechiness { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("tempo")]
        public float Tempo { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("time_signature")]
        public int TimeSignature { get; set; }

        /// <value>
        /// <c>AlbumType</c> Refer to docs URI link web page.
        /// </value>
        /// <seealso>https://developer.spotify.com/documentation/web-api/reference/#/</seealso>
        [EpicAkSPropertyNameAliasAttribute("valence")]
        public float Valence { get; set; }
    }
}
