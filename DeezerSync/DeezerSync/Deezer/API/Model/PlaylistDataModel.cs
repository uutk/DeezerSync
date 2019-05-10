﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DeezerSync.Deezer.API.Model
{
    public partial class PlaylistDataModel
    {
        // <auto-generated />
        //
        // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
        //
        //    using QuickType;
        //
        //    var welcome = Welcome.FromJson(jsonString);

        public partial class Welcome
        {
            [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> Error { get; set; }

            [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
            public Results Results { get; set; }
        }

        public partial class Results
        {
            [JsonProperty("DATA", NullValueHandling = NullValueHandling.Ignore)]
            public Data Data { get; set; }

            [JsonProperty("COMMENTS", NullValueHandling = NullValueHandling.Ignore)]
            public Comments Comments { get; set; }

            [JsonProperty("CURATOR", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Curator { get; set; }

            [JsonProperty("SONGS", NullValueHandling = NullValueHandling.Ignore)]
            public Comments Songs { get; set; }
        }

        public partial class Comments
        {
            [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
            public List<Datum> Data { get; set; }

            [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
            public long? Count { get; set; }

            [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
            public long? Total { get; set; }

            [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
            public long? Version { get; set; }

            [JsonProperty("filtered_count", NullValueHandling = NullValueHandling.Ignore)]
            public long? FilteredCount { get; set; }

            [JsonProperty("checksum", NullValueHandling = NullValueHandling.Ignore)]
            public string Checksum { get; set; }
        }

        public partial class Datum
        {
            [JsonProperty("SNG_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? SngId { get; set; }

            [JsonProperty("PRODUCT_TRACK_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ProductTrackId { get; set; }

            [JsonProperty("UPLOAD_ID", NullValueHandling = NullValueHandling.Ignore)]
            public long? UploadId { get; set; }

            [JsonProperty("SNG_TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string SngTitle { get; set; }

            [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ArtId { get; set; }

            [JsonProperty("PROVIDER_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ProviderId { get; set; }

            [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtName { get; set; }

            [JsonProperty("ARTISTS", NullValueHandling = NullValueHandling.Ignore)]
            public List<DatumArtist> Artists { get; set; }

            [JsonProperty("ALB_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? AlbId { get; set; }

            [JsonProperty("ALB_TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string AlbTitle { get; set; }

            [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
            public long? Type { get; set; }

            [JsonProperty("MD5_ORIGIN", NullValueHandling = NullValueHandling.Ignore)]
            public string Md5Origin { get; set; }

            [JsonProperty("VIDEO", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Video { get; set; }

            [JsonProperty("DURATION", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Duration { get; set; }

            [JsonProperty("ALB_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string AlbPicture { get; set; }

            [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtPicture { get; set; }

            [JsonProperty("RANK_SNG", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? RankSng { get; set; }

            [JsonProperty("SMARTRADIO", NullValueHandling = NullValueHandling.Ignore)]
            public long? Smartradio { get; set; }

            [JsonProperty("FILESIZE_AAC_64", NullValueHandling = NullValueHandling.Ignore)]
            public long? FilesizeAac64 { get; set; }

            [JsonProperty("FILESIZE_MP3_64", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeMp364 { get; set; }

            [JsonProperty("FILESIZE_MP3_128", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeMp3128 { get; set; }

            [JsonProperty("FILESIZE_MP3_256", NullValueHandling = NullValueHandling.Ignore)]
            public long? FilesizeMp3256 { get; set; }

            [JsonProperty("FILESIZE_MP3_320", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeMp3320 { get; set; }

            [JsonProperty("FILESIZE_FLAC", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeFlac { get; set; }

            [JsonProperty("FILESIZE", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Filesize { get; set; }

            [JsonProperty("GAIN", NullValueHandling = NullValueHandling.Ignore)]
            public string Gain { get; set; }

            [JsonProperty("MEDIA_VERSION", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? MediaVersion { get; set; }

            [JsonProperty("DISK_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? DiskNumber { get; set; }

            [JsonProperty("TRACK_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? TrackNumber { get; set; }

            [JsonProperty("VERSION", NullValueHandling = NullValueHandling.Ignore)]
            public string Version { get; set; }

            [JsonProperty("MEDIA", NullValueHandling = NullValueHandling.Ignore)]
            public List<Media> Media { get; set; }

            [JsonProperty("EXPLICIT_LYRICS", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ExplicitLyrics { get; set; }

            [JsonProperty("RIGHTS", NullValueHandling = NullValueHandling.Ignore)]
            public Rights Rights { get; set; }

            [JsonProperty("ISRC", NullValueHandling = NullValueHandling.Ignore)]
            public string Isrc { get; set; }

            [JsonProperty("DATE_ADD", NullValueHandling = NullValueHandling.Ignore)]
            public long? DateAdd { get; set; }

            [JsonProperty("HIERARCHICAL_TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string HierarchicalTitle { get; set; }

            [JsonProperty("SNG_CONTRIBUTORS", NullValueHandling = NullValueHandling.Ignore)]
            public SngContributorsUnion? SngContributors { get; set; }

            [JsonProperty("LYRICS_ID", NullValueHandling = NullValueHandling.Ignore)]
            public long? LyricsId { get; set; }

            [JsonProperty("EXPLICIT_TRACK_CONTENT", NullValueHandling = NullValueHandling.Ignore)]
            public ExplicitTrackContent ExplicitTrackContent { get; set; }

            [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
            public FallbackType? DatumType { get; set; }

            [JsonProperty("FALLBACK", NullValueHandling = NullValueHandling.Ignore)]
            public Fallback Fallback { get; set; }
        }

        public partial class DatumArtist
        {
            [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ArtId { get; set; }

            [JsonProperty("ROLE_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? RoleId { get; set; }

            [JsonProperty("ARTISTS_SONGS_ORDER", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ArtistsSongsOrder { get; set; }

            [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtName { get; set; }

            [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtPicture { get; set; }

            [JsonProperty("SMARTRADIO", NullValueHandling = NullValueHandling.Ignore)]
            public long? Smartradio { get; set; }

            [JsonProperty("RANK", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Rank { get; set; }

            [JsonProperty("LOCALES", NullValueHandling = NullValueHandling.Ignore)]
            public PurpleLocales? Locales { get; set; }

            [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
            public ArtistType? Type { get; set; }
        }

        public partial class Locale
        {
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }
        }

        public partial class ExplicitTrackContent
        {
            [JsonProperty("EXPLICIT_LYRICS_STATUS", NullValueHandling = NullValueHandling.Ignore)]
            public long? ExplicitLyricsStatus { get; set; }

            [JsonProperty("EXPLICIT_COVER_STATUS", NullValueHandling = NullValueHandling.Ignore)]
            public long? ExplicitCoverStatus { get; set; }
        }

        public partial class Fallback
        {
            [JsonProperty("SNG_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? SngId { get; set; }

            [JsonProperty("PRODUCT_TRACK_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ProductTrackId { get; set; }

            [JsonProperty("UPLOAD_ID", NullValueHandling = NullValueHandling.Ignore)]
            public long? UploadId { get; set; }

            [JsonProperty("SNG_TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string SngTitle { get; set; }

            [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ArtId { get; set; }

            [JsonProperty("PROVIDER_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ProviderId { get; set; }

            [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtName { get; set; }

            [JsonProperty("ARTISTS", NullValueHandling = NullValueHandling.Ignore)]
            public List<FallbackArtist> Artists { get; set; }

            [JsonProperty("ALB_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? AlbId { get; set; }

            [JsonProperty("ALB_TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string AlbTitle { get; set; }

            [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
            public long? Type { get; set; }

            [JsonProperty("MD5_ORIGIN", NullValueHandling = NullValueHandling.Ignore)]
            public string Md5Origin { get; set; }

            [JsonProperty("VIDEO", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Video { get; set; }

            [JsonProperty("DURATION", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Duration { get; set; }

            [JsonProperty("ALB_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string AlbPicture { get; set; }

            [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtPicture { get; set; }

            [JsonProperty("RANK_SNG", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? RankSng { get; set; }

            [JsonProperty("SMARTRADIO", NullValueHandling = NullValueHandling.Ignore)]
            public long? Smartradio { get; set; }

            [JsonProperty("FILESIZE_AAC_64", NullValueHandling = NullValueHandling.Ignore)]
            public long? FilesizeAac64 { get; set; }

            [JsonProperty("FILESIZE_MP3_64", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeMp364 { get; set; }

            [JsonProperty("FILESIZE_MP3_128", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeMp3128 { get; set; }

            [JsonProperty("FILESIZE_MP3_256", NullValueHandling = NullValueHandling.Ignore)]
            public long? FilesizeMp3256 { get; set; }

            [JsonProperty("FILESIZE_MP3_320", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeMp3320 { get; set; }

            [JsonProperty("FILESIZE_FLAC", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? FilesizeFlac { get; set; }

            [JsonProperty("FILESIZE", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Filesize { get; set; }

            [JsonProperty("GAIN", NullValueHandling = NullValueHandling.Ignore)]
            public string Gain { get; set; }

            [JsonProperty("MEDIA_VERSION", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? MediaVersion { get; set; }

            [JsonProperty("DISK_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? DiskNumber { get; set; }

            [JsonProperty("TRACK_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? TrackNumber { get; set; }

            [JsonProperty("VERSION", NullValueHandling = NullValueHandling.Ignore)]
            public string Version { get; set; }

            [JsonProperty("MEDIA", NullValueHandling = NullValueHandling.Ignore)]
            public List<Media> Media { get; set; }

            [JsonProperty("EXPLICIT_LYRICS", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ExplicitLyrics { get; set; }

            [JsonProperty("RIGHTS", NullValueHandling = NullValueHandling.Ignore)]
            public Rights Rights { get; set; }

            [JsonProperty("ISRC", NullValueHandling = NullValueHandling.Ignore)]
            public string Isrc { get; set; }

            [JsonProperty("HIERARCHICAL_TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string HierarchicalTitle { get; set; }

            [JsonProperty("SNG_CONTRIBUTORS", NullValueHandling = NullValueHandling.Ignore)]
            public SngContributorsClass SngContributors { get; set; }

            [JsonProperty("LYRICS_ID", NullValueHandling = NullValueHandling.Ignore)]
            public long? LyricsId { get; set; }

            [JsonProperty("EXPLICIT_TRACK_CONTENT", NullValueHandling = NullValueHandling.Ignore)]
            public ExplicitTrackContent ExplicitTrackContent { get; set; }

            [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
            public FallbackType? FallbackType { get; set; }
        }

        public partial class FallbackArtist
        {
            [JsonProperty("ART_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ArtId { get; set; }

            [JsonProperty("ROLE_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? RoleId { get; set; }

            [JsonProperty("ARTISTS_SONGS_ORDER", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ArtistsSongsOrder { get; set; }

            [JsonProperty("ART_NAME", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtName { get; set; }

            [JsonProperty("ART_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string ArtPicture { get; set; }

            [JsonProperty("SMARTRADIO", NullValueHandling = NullValueHandling.Ignore)]
            public long? Smartradio { get; set; }

            [JsonProperty("RANK", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Rank { get; set; }

            [JsonProperty("LOCALES", NullValueHandling = NullValueHandling.Ignore)]
            public FluffyLocales? Locales { get; set; }

            [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
            public ArtistType? Type { get; set; }
        }

        public partial class LocalesClass
        {
            [JsonProperty("lang_ja-jpan", NullValueHandling = NullValueHandling.Ignore)]
            public Locale LangJaJpan { get; set; }

            [JsonProperty("lang_ja-hrkt", NullValueHandling = NullValueHandling.Ignore)]
            public Locale LangJaHrkt { get; set; }
        }

        public partial class Media
        {
            [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
            public TypeEnum? Type { get; set; }

            [JsonProperty("HREF", NullValueHandling = NullValueHandling.Ignore)]
            public Uri Href { get; set; }
        }

        public partial class Rights
        {
            [JsonProperty("STREAM_ADS_AVAILABLE", NullValueHandling = NullValueHandling.Ignore)]
            public bool? StreamAdsAvailable { get; set; }

            [JsonProperty("STREAM_ADS", NullValueHandling = NullValueHandling.Ignore)]
            public DateTimeOffset? StreamAds { get; set; }

            [JsonProperty("STREAM_SUB_AVAILABLE", NullValueHandling = NullValueHandling.Ignore)]
            public bool? StreamSubAvailable { get; set; }

            [JsonProperty("STREAM_SUB", NullValueHandling = NullValueHandling.Ignore)]
            public DateTimeOffset? StreamSub { get; set; }
        }

        public partial class SngContributorsClass
        {
            [JsonProperty("mainartist", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Mainartist { get; set; }

            [JsonProperty("composerlyricist", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Composerlyricist { get; set; }

            [JsonProperty("producer", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Producer { get; set; }

            [JsonProperty("musicpublisher", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Musicpublisher { get; set; }

            [JsonProperty("featuredartist", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Featuredartist { get; set; }

            [JsonProperty("writer", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Writer { get; set; }

            [JsonProperty("composer", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Composer { get; set; }

            [JsonProperty("remixer", NullValueHandling = NullValueHandling.Ignore)]
            public List<string> Remixer { get; set; }
        }

        public partial class Data
        {
            [JsonProperty("PLAYLIST_ID", NullValueHandling = NullValueHandling.Ignore)]
            public string PlaylistId { get; set; }

            [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
            public string Title { get; set; }

            [JsonProperty("TYPE", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Type { get; set; }

            [JsonProperty("STATUS", NullValueHandling = NullValueHandling.Ignore)]
            public long? Status { get; set; }

            [JsonProperty("PARENT_PLAYLIST_ID", NullValueHandling = NullValueHandling.Ignore)]
            public string ParentPlaylistId { get; set; }

            [JsonProperty("PARENT_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ParentUserId { get; set; }

            [JsonProperty("PARENT_USERNAME", NullValueHandling = NullValueHandling.Ignore)]
            public string ParentUsername { get; set; }

            [JsonProperty("PARENT_USER_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string ParentUserPicture { get; set; }

            [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
            public string Description { get; set; }

            [JsonProperty("PLAYLIST_PICTURE", NullValueHandling = NullValueHandling.Ignore)]
            public string PlaylistPicture { get; set; }

            [JsonProperty("PICTURE_TYPE", NullValueHandling = NullValueHandling.Ignore)]
            public string PictureType { get; set; }

            [JsonProperty("DURATION", NullValueHandling = NullValueHandling.Ignore)]
            public long? Duration { get; set; }

            [JsonProperty("NB_SONG", NullValueHandling = NullValueHandling.Ignore)]
            public long? NbSong { get; set; }

            [JsonProperty("CHECKSUM", NullValueHandling = NullValueHandling.Ignore)]
            public string Checksum { get; set; }

            [JsonProperty("NB_FAN", NullValueHandling = NullValueHandling.Ignore)]
            public long? NbFan { get; set; }

            [JsonProperty("DATE_ADD", NullValueHandling = NullValueHandling.Ignore)]
            public DateTimeOffset? DateAdd { get; set; }

            [JsonProperty("DATE_MOD", NullValueHandling = NullValueHandling.Ignore)]
            public DateTimeOffset? DateMod { get; set; }

            [JsonProperty("HAS_ARTIST_LINKED", NullValueHandling = NullValueHandling.Ignore)]
            public bool? HasArtistLinked { get; set; }

            [JsonProperty("__TYPE__", NullValueHandling = NullValueHandling.Ignore)]
            public string DataType { get; set; }

            [JsonProperty("IS_FAVORITE", NullValueHandling = NullValueHandling.Ignore)]
            public bool? IsFavorite { get; set; }
        }

        public enum ArtistType { Artist };

        public enum FallbackType { Song };

        public enum TypeEnum { Preview };

        public partial struct PurpleLocales
        {
            public List<object> AnythingArray;
            public Dictionary<string, Locale> LocaleMap;

            public static implicit operator PurpleLocales(List<object> AnythingArray) => new PurpleLocales { AnythingArray = AnythingArray };
            public static implicit operator PurpleLocales(Dictionary<string, Locale> LocaleMap) => new PurpleLocales { LocaleMap = LocaleMap };
        }

        public partial struct FluffyLocales
        {
            public List<object> AnythingArray;
            public LocalesClass LocalesClass;

            public static implicit operator FluffyLocales(List<object> AnythingArray) => new FluffyLocales { AnythingArray = AnythingArray };
            public static implicit operator FluffyLocales(LocalesClass LocalesClass) => new FluffyLocales { LocalesClass = LocalesClass };
        }

        public partial struct SngContributorsUnion
        {
            public List<object> AnythingArray;
            public Dictionary<string, List<string>> StringArrayMap;

            public static implicit operator SngContributorsUnion(List<object> AnythingArray) => new SngContributorsUnion { AnythingArray = AnythingArray };
            public static implicit operator SngContributorsUnion(Dictionary<string, List<string>> StringArrayMap) => new SngContributorsUnion { StringArrayMap = StringArrayMap };
        }

        public partial class Welcome
        {
            public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, PlaylistDataModel.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                PurpleLocalesConverter.Singleton,
                ArtistTypeConverter.Singleton,
                FluffyLocalesConverter.Singleton,
                TypeEnumConverter.Singleton,
                FallbackTypeConverter.Singleton,
                SngContributorsUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        internal class ParseStringConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                long l;
                if (Int64.TryParse(value, out l))
                {
                    return l;
                }
                throw new Exception("Cannot unmarshal type long");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (long)untypedValue;
                serializer.Serialize(writer, value.ToString());
                return;
            }

            public static readonly ParseStringConverter Singleton = new ParseStringConverter();
        }

        internal class PurpleLocalesConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(PurpleLocales) || t == typeof(PurpleLocales?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<Dictionary<string, Locale>>(reader);
                        return new PurpleLocales { LocaleMap = objectValue };
                    case JsonToken.StartArray:
                        var arrayValue = serializer.Deserialize<List<object>>(reader);
                        return new PurpleLocales { AnythingArray = arrayValue };
                }
                throw new Exception("Cannot unmarshal type PurpleLocales");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (PurpleLocales)untypedValue;
                if (value.AnythingArray != null)
                {
                    serializer.Serialize(writer, value.AnythingArray);
                    return;
                }
                if (value.LocaleMap != null)
                {
                    serializer.Serialize(writer, value.LocaleMap);
                    return;
                }
                throw new Exception("Cannot marshal type PurpleLocales");
            }

            public static readonly PurpleLocalesConverter Singleton = new PurpleLocalesConverter();
        }

        internal class ArtistTypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ArtistType) || t == typeof(ArtistType?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "artist")
                {
                    return ArtistType.Artist;
                }
                throw new Exception("Cannot unmarshal type ArtistType");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ArtistType)untypedValue;
                if (value == ArtistType.Artist)
                {
                    serializer.Serialize(writer, "artist");
                    return;
                }
                throw new Exception("Cannot marshal type ArtistType");
            }

            public static readonly ArtistTypeConverter Singleton = new ArtistTypeConverter();
        }

        internal class FluffyLocalesConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(FluffyLocales) || t == typeof(FluffyLocales?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<LocalesClass>(reader);
                        return new FluffyLocales { LocalesClass = objectValue };
                    case JsonToken.StartArray:
                        var arrayValue = serializer.Deserialize<List<object>>(reader);
                        return new FluffyLocales { AnythingArray = arrayValue };
                }
                throw new Exception("Cannot unmarshal type FluffyLocales");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (FluffyLocales)untypedValue;
                if (value.AnythingArray != null)
                {
                    serializer.Serialize(writer, value.AnythingArray);
                    return;
                }
                if (value.LocalesClass != null)
                {
                    serializer.Serialize(writer, value.LocalesClass);
                    return;
                }
                throw new Exception("Cannot marshal type FluffyLocales");
            }

            public static readonly FluffyLocalesConverter Singleton = new FluffyLocalesConverter();
        }

        internal class TypeEnumConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "preview")
                {
                    return TypeEnum.Preview;
                }
                throw new Exception("Cannot unmarshal type TypeEnum");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (TypeEnum)untypedValue;
                if (value == TypeEnum.Preview)
                {
                    serializer.Serialize(writer, "preview");
                    return;
                }
                throw new Exception("Cannot marshal type TypeEnum");
            }

            public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
        }

        internal class FallbackTypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(FallbackType) || t == typeof(FallbackType?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "song")
                {
                    return FallbackType.Song;
                }
                throw new Exception("Cannot unmarshal type FallbackType");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (FallbackType)untypedValue;
                if (value == FallbackType.Song)
                {
                    serializer.Serialize(writer, "song");
                    return;
                }
                throw new Exception("Cannot marshal type FallbackType");
            }

            public static readonly FallbackTypeConverter Singleton = new FallbackTypeConverter();
        }

        internal class SngContributorsUnionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(SngContributorsUnion) || t == typeof(SngContributorsUnion?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<Dictionary<string, List<string>>>(reader);
                        return new SngContributorsUnion { StringArrayMap = objectValue };
                    case JsonToken.StartArray:
                        var arrayValue = serializer.Deserialize<List<object>>(reader);
                        return new SngContributorsUnion { AnythingArray = arrayValue };
                }
                throw new Exception("Cannot unmarshal type SngContributorsUnion");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (SngContributorsUnion)untypedValue;
                if (value.AnythingArray != null)
                {
                    serializer.Serialize(writer, value.AnythingArray);
                    return;
                }
                if (value.StringArrayMap != null)
                {
                    serializer.Serialize(writer, value.StringArrayMap);
                    return;
                }
                throw new Exception("Cannot marshal type SngContributorsUnion");
            }

            public static readonly SngContributorsUnionConverter Singleton = new SngContributorsUnionConverter();
        }

    }
}
