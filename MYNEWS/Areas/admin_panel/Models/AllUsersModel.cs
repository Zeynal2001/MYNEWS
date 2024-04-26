namespace MYNEWS.Areas.admin_panel.Models
{
    public class AllUsersModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string? ProfilePhoto { get; set; }
    }
}
