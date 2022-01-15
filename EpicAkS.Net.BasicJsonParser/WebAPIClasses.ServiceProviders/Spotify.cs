using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.Spotify
{
    public class SpotifyAccessToken
    {
        [EpicAkSPropertyNameAliasAttribute("access_token")]
        public string? AccessToken { get; set; }

        [EpicAkSPropertyNameAliasAttribute("token_type")]
        public string? TokenType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("scope")]
        public string? Scope { get; set; }

        [EpicAkSPropertyNameAliasAttribute("expires_in")]
        public string? ExpiresIn { get; set; }

        [EpicAkSPropertyNameAliasAttribute("refresh_token")]
        public string? RefreshToken { get; set; }
    }

    public class AlbumObject
    {
        [EpicAkSPropertyNameAliasAttribute("album_type")]
        public string? AlbumType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("artists")]
        public ArtistObject[]? Artists { get; set; }

        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [EpicAkSPropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_ids")]
        public ExternalIdObject? ExternalIds { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("genres")]
        public string[]? Genres { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("label")]
        public string? Label { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public AlbumRestrictionObject? Restrictions { get; set; }

        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public SimplifiedTrackObject[]? Tracks { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class AlbumRestrictionObject
    {
        [EpicAkSPropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }
    }

    public class ArtistObject
    {
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [EpicAkSPropertyNameAliasAttribute("genres")]
        public string[]? Genres { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class AudioFeaturesObject
    {
        [EpicAkSPropertyNameAliasAttribute("acousticness")]
        public float Acousticness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("analysis_url")]
        public string? AnalysisUrl { get; set; }

        [EpicAkSPropertyNameAliasAttribute("danceability")]
        public float Danceability { get; set; }

        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        [EpicAkSPropertyNameAliasAttribute("energy")]
        public float Energy { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("instrumentalness")]
        public float Instrumentalness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("key")]
        public int Key { get; set; }

        [EpicAkSPropertyNameAliasAttribute("liveness")]
        public float Liveness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("loudness")]
        public float Loudness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("mode")]
        public int Mode { get; set; }

        [EpicAkSPropertyNameAliasAttribute("speechiness")]
        public float Speechiness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("tempo")]
        public float Tempo { get; set; }

        [EpicAkSPropertyNameAliasAttribute("time_signature")]
        public int TimeSignature { get; set; }

        [EpicAkSPropertyNameAliasAttribute("track_href")]
        public string? TrackHref { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }

        [EpicAkSPropertyNameAliasAttribute("valence")]
        public float Valence { get; set; }
    }

    public class CategoryObject
    {
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("icons")]
        public ImageObject[]? Icons { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }
    }

    public class ContextObject
    {
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class CopyrightObject
    {
        [EpicAkSPropertyNameAliasAttribute("text")]
        public string? Text { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }
    }

    public class CurrentlyPlayingContextObject
    {
        [EpicAkSPropertyNameAliasAttribute("actions")]
        public DisallowsObject? Actions { get; set; }

        [EpicAkSPropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        [EpicAkSPropertyNameAliasAttribute("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("device")]
        public DeviceObject? Device { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_playing")]
        public bool IsPlaying { get; set; }

        [EpicAkSPropertyNameAliasAttribute("item")]
        public object? Item { get; set; }

        [EpicAkSPropertyNameAliasAttribute("progress_ms")]
        public int ProgressMs { get; set; }

        [EpicAkSPropertyNameAliasAttribute("repeat_state")]
        public string? RepeatState { get; set; }

        [EpicAkSPropertyNameAliasAttribute("shuffle_state")]
        public string? ShuffleState { get; set; }

        [EpicAkSPropertyNameAliasAttribute("timestamp")]
        public int Timestamp { get; set; }
    }

    public class CurrentlyPlayingObject
    {
        [EpicAkSPropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        [EpicAkSPropertyNameAliasAttribute("currently_playing_type")]
        public string? CurrentlyPlayingType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_playing")]
        public bool IsPlaying { get; set; }

        [EpicAkSPropertyNameAliasAttribute("item")]
        public object? Item { get; set; }

        [EpicAkSPropertyNameAliasAttribute("progress_ms")]
        public int ProgressMs { get; set; }

        [EpicAkSPropertyNameAliasAttribute("timestamp")]
        public int Timestamp { get; set; }
    }

    public class CursorObject
    {
        [EpicAkSPropertyNameAliasAttribute("after")]
        public string? After { get; set; }
    }

    public class CursorPagingObject
    {
        [EpicAkSPropertyNameAliasAttribute("cursors")]
        public CursorObject? Cursors { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("items")]
        public Object[]? Items { get; set; }

        [EpicAkSPropertyNameAliasAttribute("limit")]
        public int Limit { get; set; }

        [EpicAkSPropertyNameAliasAttribute("next")]
        public string? Next { get; set; }

        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class DeviceObject
    {
        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_active")]
        public bool IsActive { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_private_session")]
        public bool IsPrivateSession { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_restricted")]
        public bool IsRestricted { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("volume_percent")]
        public int VolumePercent { get; set; }
    }

    public class DevicesObject
    {
        [EpicAkSPropertyNameAliasAttribute("devices")]
        public DeviceObject[]? Devices { get; set; }
    }

    public class DisallowsObject
    {
        [EpicAkSPropertyNameAliasAttribute("interrupting_playback")]
        public bool InterruptingPlayback { get; set; }

        [EpicAkSPropertyNameAliasAttribute("pausing")]
        public bool Pausing { get; set; }

        [EpicAkSPropertyNameAliasAttribute("resuming")]
        public bool Resuming { get; set; }

        [EpicAkSPropertyNameAliasAttribute("seeking")]
        public bool Seeking { get; set; }

        [EpicAkSPropertyNameAliasAttribute("skipping_next")]
        public bool SkippingNext { get; set; }

        [EpicAkSPropertyNameAliasAttribute("skipping_prev")]
        public bool SkippingPrev { get; set; }

        [EpicAkSPropertyNameAliasAttribute("toggling_repeat_context")]
        public bool TogglingRepeatContext { get; set; }

        [EpicAkSPropertyNameAliasAttribute("toggling_repeat_track")]
        public bool TogglingRepeatTrack { get; set; }

        [EpicAkSPropertyNameAliasAttribute("toggling_shuffle")]
        public bool TogglingShuffle { get; set; }

        [EpicAkSPropertyNameAliasAttribute("transferring_playback")]
        public bool TransferringPlayback { get; set; }
    }

    public class EpisodeObject
    {
        [EpicAkSPropertyNameAliasAttribute("audio_preview_url")]
        public string? AudioPreviewUrl { get; set; }

        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [EpicAkSPropertyNameAliasAttribute("language")]
        public string? Language { get; set; }

        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [EpicAkSPropertyNameAliasAttribute("resume_point")]
        public ResumePointObject? ResumePoint { get; set; }

        [EpicAkSPropertyNameAliasAttribute("show")]
        public SimplifiedShowObject? Show { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class ErrorObject
    {
        [EpicAkSPropertyNameAliasAttribute("message")]
        public string? Message { get; set; }

        [EpicAkSPropertyNameAliasAttribute("status")]
        public int Status { get; set; }
    }

    public class ExplicitContentSettingsObject
    {
        [EpicAkSPropertyNameAliasAttribute("filter_enabled")]
        public bool FilterEnabled { get; set; }

        [EpicAkSPropertyNameAliasAttribute("filter_locked")]
        public bool FilterLocked { get; set; }
    }

    public class ExternalIdObject
    {
        [EpicAkSPropertyNameAliasAttribute("ean")]
        public string? Ean { get; set; }

        [EpicAkSPropertyNameAliasAttribute("isrc")]
        public string? Isrc { get; set; }

        [EpicAkSPropertyNameAliasAttribute("upc")]
        public string? Upc { get; set; }
    }

    public class ExternalUrlObject
    {
        [EpicAkSPropertyNameAliasAttribute("spotify")]
        public string? Spotify { get; set; }
    }

    public class FollowersObject
    {

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class ImageObject
    {
        [EpicAkSPropertyNameAliasAttribute("height")]
        public int Height { get; set; }

        [EpicAkSPropertyNameAliasAttribute("url")]
        public string? Url { get; set; }

        [EpicAkSPropertyNameAliasAttribute("width")]
        public int Width { get; set; }
    }

    public class LinkedTrackObject
    {
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class PagingObject
    {
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("items")]
        public Object[]? Items { get; set; }

        [EpicAkSPropertyNameAliasAttribute("limit")]
        public int Limit { get; set; }

        [EpicAkSPropertyNameAliasAttribute("next")]
        public string? Next { get; set; }

        [EpicAkSPropertyNameAliasAttribute("offset")]
        public int Offset { get; set; }

        [EpicAkSPropertyNameAliasAttribute("previous")]
        public string? Previous { get; set; }

        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class PlayHistoryObject
    {
        [EpicAkSPropertyNameAliasAttribute("context")]
        public ContextObject? Context { get; set; }

        [EpicAkSPropertyNameAliasAttribute("played_at")]
        public string? PlayedAt { get; set; }

        [EpicAkSPropertyNameAliasAttribute("track")]
        public SimplifiedTrackObject? Track { get; set; }
    }

    public class PlayerErrorObject
    {
        [EpicAkSPropertyNameAliasAttribute("message")]
        public string? Message { get; set; }

        [EpicAkSPropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }

        [EpicAkSPropertyNameAliasAttribute("status")]
        public int Status { get; set; }
    }

    public class PlaylistObject
    {
        [EpicAkSPropertyNameAliasAttribute("collaborative")]
        public bool Collaborative { get; set; }

        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("owner")]
        public PublicUserObject? Owner { get; set; }


        [EpicAkSPropertyNameAliasAttribute("snapshot_id")]
        public string? SnapshotId { get; set; }

        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public PlaylistTrackObject[]? Tracks { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class PlaylistTrackObject
    {
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [EpicAkSPropertyNameAliasAttribute("added_by")]
        public PublicUserObject? AddedBy { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        [EpicAkSPropertyNameAliasAttribute("track")]
        public object? Track { get; set; }
    }

    public class PlaylistTracksRefObject
    {
        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("total")]
        public int Total { get; set; }
    }

    public class SpotifyUserObject
    {
        [EpicAkSPropertyNameAliasAttribute("country")]
        public string? Country { get; set; }

        [EpicAkSPropertyNameAliasAttribute("display_name")]
        public string? DisplayName { get; set; }

        [EpicAkSPropertyNameAliasAttribute("email")]
        public string? Email { get; set; }

        [EpicAkSPropertyNameAliasAttribute("explicit_content")]
        public ExplicitContentSettingsObject? ExplicitContent { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("product")]
        public string? Product { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class PublicUserObject
    {
        [EpicAkSPropertyNameAliasAttribute("display_name")]
        public string? DisplayName { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("followers")]
        public FollowersObject? Followers { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class RecommendationSeedObject
    {
        [EpicAkSPropertyNameAliasAttribute("afterFilteringSize")]
        public int AfterFilteringSize { get; set; }

        [EpicAkSPropertyNameAliasAttribute("afterRelinkingSize")]
        public int AfterRelinkingSize { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("initialPoolSize")]
        public int InitialPoolSize { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }
    }

    public class RecommendationsObject
    {
        [EpicAkSPropertyNameAliasAttribute("seeds")]
        public RecommendationSeedObject[]? Seeds { get; set; }

        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public SimplifiedTrackObject[]? Tracks { get; set; }
    }

    public class ResumePointObject
    {
        [EpicAkSPropertyNameAliasAttribute("fully_played")]
        public bool FullyPlayed { get; set; }

        [EpicAkSPropertyNameAliasAttribute("resume_position_ms")]
        public int ResumePositionMs { get; set; }
    }

    public class SavedAlbumObject
    {
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [EpicAkSPropertyNameAliasAttribute("album")]
        public AlbumObject? Album { get; set; }
    }

    public class SavedShowObject
    {
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [EpicAkSPropertyNameAliasAttribute("show")]
        public SimplifiedShowObject? Show { get; set; }
    }

    public class SavedTrackObject
    {
        [EpicAkSPropertyNameAliasAttribute("added_at")]
        public string? AddedAt { get; set; }

        [EpicAkSPropertyNameAliasAttribute("track")]
        public TrackObject? Track { get; set; }
    }

    public class ShowObject
    {
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [EpicAkSPropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [EpicAkSPropertyNameAliasAttribute("episodes")]
        public SimplifiedEpisodeObject[]? Episodes { get; set; }


        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [EpicAkSPropertyNameAliasAttribute("media_type")]
        public string? MediaType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("publisher")]
        public string? Publisher { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedAlbumObject
    {
        [EpicAkSPropertyNameAliasAttribute("album_group")]
        public string? AlbumGroup { get; set; }

        [EpicAkSPropertyNameAliasAttribute("album_type")]
        public string? AlbumType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("artists")]
        public SimplifiedArtistObject[]? Artists { get; set; }

        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public AlbumRestrictionObject? Restrictions { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedArtistObject
    {
        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedEpisodeObject
    {

        [EpicAkSPropertyNameAliasAttribute("audio_preview_url")]
        public string? AudioPreviewUrl { get; set; }

        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [EpicAkSPropertyNameAliasAttribute("language")]
        public string? Language { get; set; }

        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date")]
        public string? ReleaseDate { get; set; }

        [EpicAkSPropertyNameAliasAttribute("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [EpicAkSPropertyNameAliasAttribute("resume_point")]
        public ResumePointObject? ResumePoint { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedPlaylistObject
    {
        [EpicAkSPropertyNameAliasAttribute("collaborative")]
        public bool Collaborative { get; set; }

        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("owner")]
        public PublicUserObject? Owner { get; set; }


        [EpicAkSPropertyNameAliasAttribute("snapshot_id")]
        public string? SnapshotId { get; set; }

        [EpicAkSPropertyNameAliasAttribute("tracks")]
        public PlaylistTracksRefObject? Tracks { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedShowObject
    {
        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [EpicAkSPropertyNameAliasAttribute("copyrights")]
        public CopyrightObject[]? Copyrights { get; set; }

        [EpicAkSPropertyNameAliasAttribute("description")]
        public string? Description { get; set; }


        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("images")]
        public ImageObject[]? Images { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [EpicAkSPropertyNameAliasAttribute("languages")]
        public string[]? Languages { get; set; }

        [EpicAkSPropertyNameAliasAttribute("media_type")]
        public string? MediaType { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("publisher")]
        public string? Publisher { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class SimplifiedTrackObject
    {
        [EpicAkSPropertyNameAliasAttribute("artists")]
        public SimplifiedArtistObject[]? Artists { get; set; }

        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [EpicAkSPropertyNameAliasAttribute("disc_number")]
        public int DiscNumber { get; set; }

        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [EpicAkSPropertyNameAliasAttribute("linked_from")]
        public LinkedTrackObject? LinkedFrom { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("preview_url")]
        public string? PreviewUrl { get; set; }

        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public TrackRestrictionObject? Restrictions { get; set; }

        [EpicAkSPropertyNameAliasAttribute("track_number")]
        public int TrackNumber { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class TrackObject
    {
        [EpicAkSPropertyNameAliasAttribute("album")]
        public SimplifiedAlbumObject? Album { get; set; }

        [EpicAkSPropertyNameAliasAttribute("artists")]
        public ArtistObject[]? Artists { get; set; }

        [EpicAkSPropertyNameAliasAttribute("available_markets")]
        public string[]? AvailableMarkets { get; set; }

        [EpicAkSPropertyNameAliasAttribute("disc_number")]
        public int DiscNumber { get; set; }

        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }


        [EpicAkSPropertyNameAliasAttribute("external_ids")]
        public ExternalIdObject? ExternalIds { get; set; }

        [EpicAkSPropertyNameAliasAttribute("external_urls")]
        public ExternalUrlObject? ExternalUrls { get; set; }

        [EpicAkSPropertyNameAliasAttribute("href")]
        public string? Href { get; set; }

        [EpicAkSPropertyNameAliasAttribute("id")]
        public string? Id { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_local")]
        public bool IsLocal { get; set; }

        [EpicAkSPropertyNameAliasAttribute("is_playable")]
        public bool IsPlayable { get; set; }

        [EpicAkSPropertyNameAliasAttribute("linked_from")]
        public TrackObject? LinkedFrom { get; set; }

        [EpicAkSPropertyNameAliasAttribute("name")]
        public string? Name { get; set; }

        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public int Popularity { get; set; }

        [EpicAkSPropertyNameAliasAttribute("preview_url")]
        public string? PreviewUrl { get; set; }

        [EpicAkSPropertyNameAliasAttribute("restrictions")]
        public TrackRestrictionObject? Restrictions { get; set; }

        [EpicAkSPropertyNameAliasAttribute("track_number")]
        public int TrackNumber { get; set; }

        [EpicAkSPropertyNameAliasAttribute("type")]
        public string? Type { get; set; }

        [EpicAkSPropertyNameAliasAttribute("uri")]
        public string? Uri { get; set; }
    }

    public class TrackRestrictionObject
    {
        [EpicAkSPropertyNameAliasAttribute("reason")]
        public string? Reason { get; set; }
    }

    public class TuneableTrackObject
    {
        [EpicAkSPropertyNameAliasAttribute("acousticness")]
        public float Acousticness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("danceability")]
        public float Danceability { get; set; }

        [EpicAkSPropertyNameAliasAttribute("duration_ms")]
        public int DurationMs { get; set; }

        [EpicAkSPropertyNameAliasAttribute("energy")]
        public float Energy { get; set; }

        [EpicAkSPropertyNameAliasAttribute("instrumentalness")]
        public float Instrumentalness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("key")]
        public int Key { get; set; }

        [EpicAkSPropertyNameAliasAttribute("liveness")]
        public float Liveness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("loudness")]
        public float Loudness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("mode")]
        public int Mode { get; set; }

        [EpicAkSPropertyNameAliasAttribute("popularity")]
        public float Popularity { get; set; }

        [EpicAkSPropertyNameAliasAttribute("speechiness")]
        public float Speechiness { get; set; }

        [EpicAkSPropertyNameAliasAttribute("tempo")]
        public float Tempo { get; set; }

        [EpicAkSPropertyNameAliasAttribute("time_signature")]
        public int TimeSignature { get; set; }

        [EpicAkSPropertyNameAliasAttribute("valence")]
        public float Valence { get; set; }
    }
}
