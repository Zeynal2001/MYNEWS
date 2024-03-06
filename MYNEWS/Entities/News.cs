using System.Xml.Linq;

namespace MYNEWS.Entities
{
    public class News : BaseEntity
    {
        //Çox vaxt entity də single/details səhifəsində tələb olunan datalar saxlanılır
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public string AdditionalPhotoPath { get; set; }
        public int ViewsCount { get; set; }
        //-----------------------------------------------
        public List<Author> Authors { get; set; }
        public List<NewsTag> NewsTags { get; set; }
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
