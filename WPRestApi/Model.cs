using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace WPRestApi
{

    public class Guid
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }

    public class Title
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }

    public class Content
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
        [JsonProperty("@protected")]
        public bool Protected { get; set; }
    }

    public class Excerpt
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
        [JsonProperty("@protected")]
        public bool Protected { get; set; }
    }

    public class Description
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }

    public class Caption
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }

    public class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Collection
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class About
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Author
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Reply
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class VersionHistory
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class WpAttachment
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Cury
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
        [JsonProperty("templated")]
        public bool Templated { get; set; }
    }

    public class ImageSize
    {
        [JsonProperty("file")]
        public string File { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
    }

    public class Sizes
    {
        [JsonProperty("thumbnail")]
        public ImageSize Thumbnail { get; set; }
        [JsonProperty("full")]
        public ImageSize Full { get; set; }
    }

    public class ImageMeta
    {
        [JsonProperty("aperture")]
        public string Aperture { get; set; }
        [JsonProperty("credit")]
        public string Credit { get; set; }
        [JsonProperty("camera")]
        public string Camera { get; set; }
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("created_timestamp")]
        public string CreatedTimestamp { get; set; }
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        [JsonProperty("focal_length")]
        public string FocalLength { get; set; }
        [JsonProperty("iso")]
        public string Iso { get; set; }
        [JsonProperty("shutter_speed")]
        public string ShutterSpeed { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("orientation")]
        public string Orientation { get; set; }
        [JsonProperty("keywords")]
        public List<object> Keywords { get; set; }
    }

    public class MediaDetails
    {
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("file")]
        public string File { get; set; }
        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }
        [JsonProperty("image_meta")]
        public ImageMeta ImageMeta { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("taxonomy")]
        public string Taxonomy { get; set; }
        [JsonProperty("parent")]
        public int Parent { get; set; }
        [JsonProperty("meta")]
        public List<object> Meta { get; set; }
        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class Up
    {
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class WpPostType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Links
    {
        [JsonProperty("self")]
        public List<Self> Self { get; set; }
        [JsonProperty("collection")]
        public List<Collection> Collection { get; set; }
        [JsonProperty("about")]
        public List<About> About { get; set; }
        [JsonProperty("up")]
        public List<Up> Up { get; set; }
        [JsonProperty("wp:post_type")]
        public List<WpPostType> WpPostType { get; set; }
        [JsonProperty("curies")]
        public List<Cury> Curies { get; set; }
        [JsonProperty("author")]
        public List<Author> Author { get; set; }
        [JsonProperty("replies")]
        public List<Reply> Replies { get; set; }
        [JsonProperty("version-history")]
        public List<VersionHistory> VersionHistory { get; set; }
        [JsonProperty("wp:attachment")]
        public List<WpAttachment>WpAttachment { get; set; }
    }

    public class Page
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("date_gmt")]
        public DateTime DateGMT { get; set; }
        [JsonProperty("guid")]
        public Guid Guid { get; set; }
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("modified_gmt")]
        public DateTime ModifiedGMT { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("title")]
        public Title Title { get; set; }
        [JsonProperty("content")]
        public Content Content { get; set; }
        [JsonProperty("excerpt")]
        public Excerpt Excerpt { get; set; }
        [JsonProperty("author")]
        public int Author { get; set; }
        [JsonProperty("featured_media")]
        public int FeaturedMedia { get; set; }
        [JsonProperty("parent")]
        public int Parent { get; set; }
        [JsonProperty("menu_order")]
        public int MenuOrder { get; set; }
        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }
        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }
        [JsonProperty("template")]
        public string Template { get; set; }
        [JsonProperty("meta")]
        public List<object> Meta { get; set; }
        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class Post
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("date_gmt")]
        public DateTime DateGMT { get; set; }
        [JsonProperty("guid")]
        public Guid Guid { get; set; }
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("modified_gmt")]
        public DateTime ModifiedGMT { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("title")]
        public Title Title { get; set; }
        [JsonProperty("content")]
        public Content Content { get; set; }
        [JsonProperty("excerpt")]
        public Excerpt Excerpt { get; set; }
        [JsonProperty("author")]
        public int Author { get; set; }
        [JsonProperty("featured_media")]
        public int FeaturedMedia { get; set; }
        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }
        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }
        [JsonProperty("sticky")]
        public bool Sticky { get; set; }
        [JsonProperty("template")]
        public string Template { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("meta")]
        public List<object> Meta { get; set; }
        [JsonProperty("categories")]
        public List<int> Categories { get; set; }
        [JsonProperty("tags")]
        public List<object> Tags { get; set; }
        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class Media
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("date_gmt")]
        public DateTime DateGMT { get; set; }
        [JsonProperty("guid")]
        public Guid Guid { get; set; }
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("modified_gmt")]
        public DateTime ModifiedGMT { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("title")]
        public Title Title { get; set; }
        [JsonProperty("author")]
        public int Author { get; set; }
        [JsonProperty("comment_status")]
        public string CommentStatus { get; set; }
        [JsonProperty("ping_status")]
        public string PingStatus { get; set; }
        [JsonProperty("template")]
        public string Template { get; set; }
        [JsonProperty("meta")]
        public List<ImageMeta> Meta { get; set; }
        [JsonProperty("description")]
        public Description Description { get; set; }
        [JsonProperty("caption")]
        public Caption Caption { get; set; }
        [JsonProperty("alt_text")]
        public string AltText { get; set; }
        [JsonProperty("media_type")]
        public string MediaType { get; set; }
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }
        [JsonProperty("media_details")]
        public MediaDetails MediaDetails { get; set; }
        [JsonProperty("post")]
        public int Post { get; set; }
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}