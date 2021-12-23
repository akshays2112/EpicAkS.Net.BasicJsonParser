using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.Spotify
{
    public class SpotifyAccessToken
    {
        [PropertyNameAliasAttribute("access_token")]
        public string? AccessToken { get; set; }

        [PropertyNameAliasAttribute("token_type")]
        public string? TokenType { get; set; }

        [PropertyNameAliasAttribute("scope")]
        public string? Scope { get; set; }

        [PropertyNameAliasAttribute("expires_in")]
        public string? ExpiresIn { get; set; }

        [PropertyNameAliasAttribute("refresh_token")]
        public string? RefreshToken { get; set; }
    }

    public class AlbumObject
    {
        [PropertyNameAliasAttribute("album_type")]
        public string? AlbumType { get; set; }

        [PropertyNameAliasAttribute("artists")]
        public ArtistObject[]? Artists { get; set; }

        [PropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [PropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        [PropertyNameAliasAttribute("external_ids")]
        public ExternalIdObject? ExternalIds { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("genres")]
        public string[]? Genres { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("label")]
        public string? Label { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        [PropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [PropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [PropertyNameAliasAttribute("restrictions")]
        public AlbumRestrictionObject? Restrictions { get; set; }

        [PropertyNameAliasAttribute("tracks")]
        public SimplifiedTrackObject[]? Tracks { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class AlbumRestrictionObject
    {
        [PropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }
    }

    public class ArtistObject
    {
        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [PropertyNameAliasAttribute("genres")]
        public string[]? Genres { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class AudioFeaturesObject
    {
        [PropertyNameAliasAttribute("acousticness")]
        public float Acousticness { get; set; }

        [PropertyNameAliasAttribute("analysis_url")]
        public string? AnalysisUrl { get; set; }

        [PropertyNameAliasAttribute("danceability")]
        public float Danceability { get; set; }

        [PropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        [PropertyNameAliasAttribute("energy")]
        public float Energy { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("instrumentalness")]
        public float Instrumentalness { get; set; }

        [PropertyNameAliasAttribute("key")]
        public int Key { get; set; }

        [PropertyNameAliasAttribute("liveness")]
        public float Liveness { get; set; }

        [PropertyNameAliasAttribute("loudness")]
        public float Loudness { get; set; }

        [PropertyNameAliasAttribute("mode")]
        public int Mode { get; set; }

        [PropertyNameAliasAttribute("speechiness")]
        public float Speechiness { get; set; }

        [PropertyNameAliasAttribute("tempo")]
        public float Tempo { get; set; }

        [PropertyNameAliasAttribute("time_signature")]
        public int TimeSignature { get; set; }

        [PropertyNameAliasAttribute("track_href")]
        public string? TrackHref { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }

        [PropertyNameAliasAttribute("valence")]
        public float Valence { get; set; }
    }

    public class CategoryObject
    {
        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("icons")]
        public ImageObject[]? Icons { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }
    }

    public class ContextObject
    {
        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class CopyrightObject
    {
        [PropertyNameAliasAttribute("text")]
        public string? Text { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }
    }

    public class CurrentlyPlayingContextObject
    {
        [PropertyNameAliasAttribute("actions")]
        public DisallowsObject? Actions { get; set; }

        [PropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        [PropertyNameAliasAttribute("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        [PropertyNameAliasAttribute("device")]
        public DeviceObject? Device { get; set; }

        [PropertyNameAliasAttribute("is_playing")]
        public bool IsPlaying { get; set; }

        [PropertyNameAliasAttribute("item")]
        public object? Item { get; set; }

        [PropertyNameAliasAttribute("progress_ms")]
        public int ProgressMs { get; set; }

        [PropertyNameAliasAttribute("repeat_state")]
        public string? RepeatState { get; set; }

        [PropertyNameAliasAttribute("shuffle_state")]
        public string? ShuffleState { get; set; }

        [PropertyNameAliasAttribute("timestamp")]
        public int Timestamp { get; set; }
    }

    public class CurrentlyPlayingObject
    {
        [PropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        [PropertyNameAliasAttribute("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        [PropertyNameAliasAttribute("is_playing")]
        public bool IsPlaying { get; set; }

        [PropertyNameAliasAttribute("item")]
        public object? Item { get; set; }

        [PropertyNameAliasAttribute("progress_ms")]
        public int ProgressMs { get; set; }

        [PropertyNameAliasAttribute("timestamp")]
        public int Timestamp { get; set; }
    }

    public class CursorObject
    {
        [PropertyNameAliasAttribute("after")]
        public string? After { get; set; }
    }

    public class CursorPagingObject
    {
        [PropertyNameAliasAttribute("cursors")]
        public CursorObject? Cursors { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("items")]
        public Object[]? Items { get; set; }

        [PropertyNameAliasAttribute("limit")]
        public int Limit { get; set; }

        [PropertyNameAliasAttribute("next")]
        public string? Next { get; set; }

        [PropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class DeviceObject
    {
        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("is_active")]
        public bool IsActive { get; set; }

        [PropertyNameAliasAttribute("is_private_session")]
        public bool IsPrivateSession { get; set; }

        [PropertyNameAliasAttribute("is_restricted")]
        public bool IsRestricted { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("volume_percent")]
        public int VolumePercent { get; set; }
    }

    public class DevicesObject
    {
        [PropertyNameAliasAttribute("devices")]
        public DeviceObject[]? Devices { get; set; }
    }

    public class DisallowsObject
    {
        [PropertyNameAliasAttribute("interrupting_playback")]
        public bool InterruptingPlayback { get; set; }

        [PropertyNameAliasAttribute("pausing")]
        public bool Pausing { get; set; }

        [PropertyNameAliasAttribute("resuming")]
        public bool Resuming { get; set; }

        [PropertyNameAliasAttribute("seeking")]
        public bool Seeking { get; set; }

        [PropertyNameAliasAttribute("skipping_next")]
        public bool SkippingNext { get; set; }

        [PropertyNameAliasAttribute("skipping_prev")]
        public bool SkippingPrev { get; set; }

        [PropertyNameAliasAttribute("toggling_repeat_context")]
        public bool TogglingRepeatContext { get; set; }

        [PropertyNameAliasAttribute("toggling_repeat_track")]
        public bool TogglingRepeatTrack { get; set; }

        [PropertyNameAliasAttribute("toggling_shuffle")]
        public bool TogglingShuffle { get; set; }

        [PropertyNameAliasAttribute("transferring_playback")]
        public bool TransferringPlayback { get; set; }
    }

    public class EpisodeObject
    {
        [PropertyNameAliasAttribute("audio_preview_url")]
        public string? AudioPreviewUrl { get; set; }

        [PropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [PropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [PropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [PropertyNameAliasAttribute("language")]
        public string? Language { get; set; }

        [PropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [PropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [PropertyNameAliasAttribute("resume_point")]
        public ResumePointObject? ResumePoint { get; set; }

        [PropertyNameAliasAttribute("show")]
        public SimplifiedShowObject? Show { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class ErrorObject
    {
        [PropertyNameAliasAttribute("message")]
        public string? Message { get; set; }

        [PropertyNameAliasAttribute("status")]
        public int Status { get; set; }
    }

    public class ExplicitContentSettingsObject
    {
        [PropertyNameAliasAttribute("filter_enabled")]
        public bool FilterEnabled { get; set; }

        [PropertyNameAliasAttribute("filter_locked")]
        public bool FilterLocked { get; set; }
    }

    public class ExternalIdObject
    {
        [PropertyNameAliasAttribute("ean")]
        public string? Ean { get; set; }

        [PropertyNameAliasAttribute("isrc")]
        public string? Isrc { get; set; }

        [PropertyNameAliasAttribute("upc")]
        public string? Upc { get; set; }
    }

    public class ExternalUrlObject
    {
        [PropertyNameAliasAttribute("spotify")]
        public string? Spotify { get; set; }
    }

    public class FollowersObject
    {

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class ImageObject
    {
        [PropertyNameAliasAttribute("height")]
        public int Height { get; set; }

        [PropertyNameAliasAttribute("url")]
        public string? Url { get; set; }

        [PropertyNameAliasAttribute("width")]
        public int Width { get; set; }
    }

    public class LinkedTrackObject
    {
        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class PagingObject
    {
        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("items")]
        public Object[]? Items { get; set; }

        [PropertyNameAliasAttribute("limit")]
        public int Limit { get; set; }

        [PropertyNameAliasAttribute("next")]
        public string? Next { get; set; }

        [PropertyNameAliasAttribute("offset")]
        public int Offset { get; set; }

        [PropertyNameAliasAttribute("previous")]
        public string? Previous { get; set; }

        [PropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class PlayHistoryObject
    {
        [PropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        [PropertyNameAliasAttribute("played_at")]
        public string? PlayedAt { get; set; }

        [PropertyNameAliasAttribute("track")]
        public SimplifiedTrackObject? Track { get; set; }
    }

    public class PlayerErrorObject
    {
        [PropertyNameAliasAttribute("message")]
        public string? Message { get; set; }

        [PropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }

        [PropertyNameAliasAttribute("status")]
        public int Status { get; set; }
    }

    public class PlaylistObject
    {
        [PropertyNameAliasAttribute("collaborative")]
        public bool Collaborative { get; set; }

        [PropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("owner")]
        public PublicUserObject? Owner { get; set; }


        [PropertyNameAliasAttribute("snapshot_id")]
        public string? SnapshotId { get; set; }

        [PropertyNameAliasAttribute("tracks")]
        public PlaylistTrackObject[]? Tracks { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class PlaylistTrackObject
    {
        [PropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [PropertyNameAliasAttribute("added_by")]
        public PublicUserObject? AddedBy { get; set; }

        [PropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        [PropertyNameAliasAttribute("track")]
        public object? Track { get; set; }
    }

    public class PlaylistTracksRefObject
    {
        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class SpotifyUserObject
    {
        [PropertyNameAliasAttribute("country")]
        public string? Country { get; set; }

        [PropertyNameAliasAttribute("display_name")]
        public string? DisplayName { get; set; }

        [PropertyNameAliasAttribute("email")]
        public string? Email { get; set; }

        [PropertyNameAliasAttribute("explicit_content")]
        public ExplicitContentSettingsObject? ExplicitContent { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("product")]
        public string? Product { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class PublicUserObject
    {
        [PropertyNameAliasAttribute("display_name")]
        public string? DisplayName { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class RecommendationSeedObject
    {
        [PropertyNameAliasAttribute("afterFilteringSize")]
        public int AfterFilteringSize { get; set; }

        [PropertyNameAliasAttribute("afterRelinkingSize")]
        public int AfterRelinkingSize { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("initialPoolSize")]
        public int InitialPoolSize { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }
    }

    public class RecommendationsObject
    {
        [PropertyNameAliasAttribute("seeds")]
        public RecommendationSeedObject[]? Seeds { get; set; }

        [PropertyNameAliasAttribute("tracks")]
        public SimplifiedTrackObject[]? Tracks { get; set; }
    }

    public class ResumePointObject
    {
        [PropertyNameAliasAttribute("fully_played")]
        public bool FullyPlayed { get; set; }

        [PropertyNameAliasAttribute("resume_position_ms")]
        public int ResumePositionMs { get; set; }
    }

    public class SavedAlbumObject
    {
        [PropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [PropertyNameAliasAttribute("album")]
        public AlbumObject? Album { get; set; }
    }

    public class SavedShowObject
    {
        [PropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [PropertyNameAliasAttribute("show")]
        public SimplifiedShowObject? Show { get; set; }
    }

    public class SavedTrackObject
    {
        [PropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [PropertyNameAliasAttribute("track")]
        public TrackObject? Track { get; set; }
    }

    public class ShowObject
    {
        [PropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [PropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        [PropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [PropertyNameAliasAttribute("episodes")]
        public SimplifiedEpisodeObject[]? Episodes { get; set; }


        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [PropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [PropertyNameAliasAttribute("media_type")]
        public string? MediaType { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("publisher")]
        public string? Publisher { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedAlbumObject
    {
        [PropertyNameAliasAttribute("album_group")]
        public string? AlbumGroup { get; set; }

        [PropertyNameAliasAttribute("album_type")]
        public string? AlbumType { get; set; }

        [PropertyNameAliasAttribute("artists")]
        public SimplifiedArtistObject[]? Artists { get; set; }

        [PropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [PropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [PropertyNameAliasAttribute("restrictions")]
        public AlbumRestrictionObject? Restrictions { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedArtistObject
    {
        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedEpisodeObject
    {

        [PropertyNameAliasAttribute("audio_preview_url")]
        public string? AudioPreviewUrl { get; set; }

        [PropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [PropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [PropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [PropertyNameAliasAttribute("language")]
        public string? Language { get; set; }

        [PropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [PropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [PropertyNameAliasAttribute("resume_point")]
        public ResumePointObject? ResumePoint { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedPlaylistObject
    {
        [PropertyNameAliasAttribute("collaborative")]
        public bool Collaborative { get; set; }

        [PropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("owner")]
        public PublicUserObject? Owner { get; set; }


        [PropertyNameAliasAttribute("snapshot_id")]
        public string? SnapshotId { get; set; }

        [PropertyNameAliasAttribute("tracks")]
        public PlaylistTracksRefObject? Tracks { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedShowObject
    {
        [PropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [PropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        [PropertyNameAliasAttribute("description")]
        public string? Description { get; set; }


        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [PropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [PropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [PropertyNameAliasAttribute("media_type")]
        public string? MediaType { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("publisher")]
        public string? Publisher { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedTrackObject
    {
        [PropertyNameAliasAttribute("artists")]
        public SimplifiedArtistObject[]? Artists { get; set; }

        [PropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [PropertyNameAliasAttribute("disc_number")]
        public int DiscNumber { get; set; }

        [PropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        [PropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [PropertyNameAliasAttribute("linked_from")]
        public LinkedTrackObject? LinkedFrom { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("preview_url")]
        public string? PreviewUrl { get; set; }

        [PropertyNameAliasAttribute("restrictions")]
        public TrackRestrictionObject? Restrictions { get; set; }

        [PropertyNameAliasAttribute("track_number")]
        public int TrackNumber { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class TrackObject
    {
        [PropertyNameAliasAttribute("album")]
        public SimplifiedAlbumObject? Album { get; set; }

        [PropertyNameAliasAttribute("artists")]
        public ArtistObject[]? Artists { get; set; }

        [PropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [PropertyNameAliasAttribute("disc_number")]
        public int DiscNumber { get; set; }

        [PropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [PropertyNameAliasAttribute("external_ids")]
        public ExternalIdObject? ExternalIds { get; set; }

        [PropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [PropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [PropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [PropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        [PropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [PropertyNameAliasAttribute("linked_from")]
        public TrackObject? LinkedFrom { get; set; }

        [PropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [PropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        [PropertyNameAliasAttribute("preview_url")]
        public string? PreviewUrl { get; set; }

        [PropertyNameAliasAttribute("restrictions")]
        public TrackRestrictionObject? Restrictions { get; set; }

        [PropertyNameAliasAttribute("track_number")]
        public int TrackNumber { get; set; }

        [PropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [PropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class TrackRestrictionObject
    {
        [PropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }
    }

    public class TuneableTrackObject
    {
        [PropertyNameAliasAttribute("acousticness")]
        public float Acousticness { get; set; }

        [PropertyNameAliasAttribute("danceability")]
        public float Danceability { get; set; }

        [PropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        [PropertyNameAliasAttribute("energy")]
        public float Energy { get; set; }

        [PropertyNameAliasAttribute("instrumentalness")]
        public float Instrumentalness { get; set; }

        [PropertyNameAliasAttribute("key")]
        public int Key { get; set; }

        [PropertyNameAliasAttribute("liveness")]
        public float Liveness { get; set; }

        [PropertyNameAliasAttribute("loudness")]
        public float Loudness { get; set; }

        [PropertyNameAliasAttribute("mode")]
        public int Mode { get; set; }

        [PropertyNameAliasAttribute("popularity")]
        public float Popularity { get; set; }

        [PropertyNameAliasAttribute("speechiness")]
        public float Speechiness { get; set; }

        [PropertyNameAliasAttribute("tempo")]
        public float Tempo { get; set; }

        [PropertyNameAliasAttribute("time_signature")]
        public int TimeSignature { get; set; }

        [PropertyNameAliasAttribute("valence")]
        public float Valence { get; set; }
    }
}
