namespace MYNEWS.Entities
{
    public class Comment : BaseEntity
    {
        public int? Vote { get; set; }
        public News News { get; set; }
        public AppUser User { get; set; }
        public string CommentText { get; set; }
    }
}
