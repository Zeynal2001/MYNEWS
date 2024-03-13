namespace MYNEWS.Models
{
    public class SliderItem
    {
        public Guid NewsId { get; set; }
        public string Title { get; set; }
        public string? PhotoPathForTrending { get; set; }
        public string? PhotoPathSingleBig { get; set; }
        public string? LongPhotoPathForCategories { get; set; }
        public string? PhotoPathForFeatured { get; set; }
        public string? PhotoPathForCategories { get; set; }
        public string Categories { get; set; }
        public string Tags { get; set; }
        public DateTime CreatedAt  { get; set; }
    }
}
