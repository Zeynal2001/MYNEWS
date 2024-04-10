namespace MYNEWS.Models
{
    public class SliderItem
    {
        public Guid NewsId { get; set; }
        public string Title { get; set; }
        public string? PhotoPathForTrending { get; set; }
        public string? PhotoPathSingleBig { get; set; }
        public string? PhotoPathForFeatured { get; set; }
        public string? PhotoPathForCategories { get; set; }
        public string Category { get; set; }
        public string CategoryId { get; set; }
        public string Tag { get; set; }
        public DateTime CreatedAt  { get; set; }
    }
}
