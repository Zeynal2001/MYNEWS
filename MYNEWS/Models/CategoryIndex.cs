namespace MYNEWS.Models
{
    public class CategoryIndex
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? LongPhotoPathForCategories { get; set; }
        public List<SubcategoryIndex> Subcategories { get; set; }
    }
}
