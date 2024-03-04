namespace MYNEWS.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<News> News { get; set; }
        public List<Subcategory> Subcategories { get; set; }
    }
}
