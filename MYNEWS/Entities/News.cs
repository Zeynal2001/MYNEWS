using System.Xml.Linq;

namespace MYNEWS.Entities
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public string AdditionalPhotoPath { get; set; }
        public int ViewsCount { get; set; }
        //public string ShortDescription { get; set; }
        //public Guid CategoryId { get; set; }
        public List<Author> Authors { get; set; }
        public List<NewsTag> NewsTags { get; set; }
        public List<Category> Categories { get; set; }
        public List<Subcategory> Subcategories { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
