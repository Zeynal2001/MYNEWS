using System.Xml.Linq;

namespace MYNEWS.Entities
{
    public class News : BaseEntity
    {
        //Çox vaxt entity də single/details səhifəsində tələb olunan datalar saxlanılır.
        //Amma bu layihədə single səhifəsində dataların hamısı göstərilmir deyə
        //home səhifəsində tələb olunan datalarda entity də qeyd olundu.
        public string Title { get; set; }
        public string Content { get; set; }
        //public string PhotoPath { get; set; }
        //public string AdditionalPhotoPath { get; set; }
        public string? PhotoPathForTrending { get; set; }
        public string? PhotoPathSingleBig { get; set; }
        public string? PhotoPathForFeatured { get; set; }
        public string? PhotoPathForCategories { get; set; }
        public string? PhotoPathForUserComment{ get; set; }
        public int ViewsCount { get; set; }

        //-------------------RELATIONS-------------------------
        public List<Author> Authors { get; set; }
        public List<NewsTag> NewsTags { get; set; }
        public List<Comment> Comments { get; set; }
        //TODO: Admin panelini quranda aşağıda olan nullable ları sil.
        public Guid? CategoryId { get; set; }
        public Guid? SubcategoryId { get; set; }
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}
