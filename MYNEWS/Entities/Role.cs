namespace MYNEWS.Entities
{
    public class Role : BaseEntity
    {
        public string RoleType { get; set; }
        public List<User> Users { get; set; }
    }
}
