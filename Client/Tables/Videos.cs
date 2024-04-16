using System;
using System.Text.Json.Serialization;

namespace RadzenBlazorAzureStaticWebApp.Tables 
{
        public class Thumbnail
    {
        [JsonPropertyName("default")]
        public ThumbnailUrl? Default { get; set; }
        [JsonPropertyName("medium")]
        public ThumbnailUrl? Medium { get; set; }
        [JsonPropertyName("high")]
        public ThumbnailUrl? High { get; set; }
        [JsonPropertyName("standard")]
        public ThumbnailUrl? Standard { get; set; }
        [JsonPropertyName("maxres")]
        public ThumbnailUrl? Maxres { get; set; }
    }

    public class ThumbnailUrl
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
    public class Videos
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        public string? Channel { get; set; }
        public DateTime? Published { get; set; }
        public string? Duration { get; set; }
        public string? Url { get; set; }
        [JsonPropertyName("thumbnail")]
        public Thumbnail? Thumbnail { get; set; }
    }
}