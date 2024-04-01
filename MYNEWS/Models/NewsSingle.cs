namespace MYNEWS.Models
{
    public class NewsSingle
    {
        public string Id { get; set; } //Front End-çi üçün Id ni də gətirirk.
        public string Title { get; set; }
        public string Content { get; set; }
        public string? PhotoPathForTrending { get; set; }
        public string? PhotoPathSingleBig { get; set; }
        public string? PhotoPathForFeatured { get; set; }
        public string? PhotoPathForCategories { get; set; }
        public string? PhotoPathLikeForCategories { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReadingTime { get; set; }
        public int ViewsCount { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
    }
}
