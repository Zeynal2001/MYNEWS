using MYNEWS.Models;

namespace MYNEWS.ViewModels
{
    public class CategoryVm
    {
       public List<CategoryIndex> Categories { get; set; }
        public List<SubcategoryIndex> Subcategories { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
