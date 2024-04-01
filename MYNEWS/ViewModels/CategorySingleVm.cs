namespace MYNEWS.ViewModels
{
    public class CategorySingleVm
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public List<SubcategoriesForThisVm> Subcategories { get; set; }
        public List<NewsForThisVm> News { get; set; }
    }

    public class SubcategoriesForThisVm
    {
        public Guid Id { get; set; }
        public string SubcategoryName { get; set; }
    }

    public class NewsForThisVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? PhotoPathForTrending { get; set; }
        public string? PhotoPathSingleBig { get; set; }
        public string? PhotoPathForFeatured { get; set; }
        public string? PhotoPathForCategories { get; set; }
        public string? SubCategory { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
