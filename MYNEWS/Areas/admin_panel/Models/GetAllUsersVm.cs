namespace MYNEWS.Areas.admin_panel.Models
{
    public class GetAllUsersVm
    {
        public List<AllUsersModel> Users { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public List<int> PageSizes { get; set; } = new() {5, 15, 25, 35, 50, 100};
    }
}
