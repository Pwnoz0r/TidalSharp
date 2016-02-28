﻿// Visual Studio Extension "JsonUtilsToolbar" created by Jonathan "Pwnoz0r" Rainier - Initial Servers LLC. - 2016
// Generated using Xamasoft JSON Class Generator Lib - http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TidalSharp.Models.Static
{
    public class TracksItem
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("replayGain")]
        public double ReplayGain { get; set; }

        [JsonProperty("peak")]
        public double Peak { get; set; }

        [JsonProperty("allowStreaming")]
        public bool AllowStreaming { get; set; }

        [JsonProperty("streamReady")]
        public bool StreamReady { get; set; }

        [JsonProperty("streamStartDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime StreamStartDate { get; set; }

        [JsonProperty("premiumStreamingOnly")]
        public bool PremiumStreamingOnly { get; set; }

        [JsonProperty("trackNumber")]
        public int TrackNumber { get; set; }

        [JsonProperty("volumeNumber")]
        public int VolumeNumber { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isrc")]
        public string Isrc { get; set; }

        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        [JsonProperty("artist")]
        public Artist Artist { get; set; }

        [JsonProperty("artists")]
        public IList<Artist> Artists { get; set; }

        [JsonProperty("album")]
        public AlbumsModel Album { get; set; }
    }
}
