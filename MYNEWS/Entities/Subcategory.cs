namespace MYNEWS.Entities
{
    public class Subcategory : BaseEntity
    {
        public Category Category { get; set; }
        public string SubcategoryName { get; set; }
        public string SubcategoryDescription { get; set; }
    }
}
