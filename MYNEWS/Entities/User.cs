using System.Data;
using System.Xml.Linq;

namespace MYNEWS.Entities
{
    public class User
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; } //= string.Empty;
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }
        public Role Role { get; set; }
        public List<Category> Categories { get; set; }
        public List<Subcategory> Subcategories { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
