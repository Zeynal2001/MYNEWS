using MYNEWS.Entities;
using System.ComponentModel.DataAnnotations;

namespace MYNEWS.Areas.admin_panel.Models
{
    public class CreateNewsModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public IFormFile? ForTrending { get; set; }
        public IFormFile? SingleBig { get; set; }
        public IFormFile? ForFeatured { get; set; }
        public IFormFile? ForCategoriesAndSub { get; set; }

        //-------------------RELATIONS-------------------------
        [Required]
        public string Category { get; set; }
        [Required]
        public string Subcategory { get; set; }

        [Required]
        public string[] Authors { get; set; }
        [Required]
        public string[] Tags { get; set; }


    }
}
