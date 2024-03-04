namespace MYNEWS.Entities
{
    public class Comment : BaseEntity
    {
        public News News { get; set; }
        public User User { get; set; }
        public string CommentText { get; set; }
    }
}
