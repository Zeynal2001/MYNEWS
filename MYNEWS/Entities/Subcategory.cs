namespace MYNEWS.Entities
{
    public class Subcategory : BaseEntity
    {
        public string SubcategoryName { get; set; }
        public Category Category { get; set; }
        public List<News> News { get; set; }
    }
}
