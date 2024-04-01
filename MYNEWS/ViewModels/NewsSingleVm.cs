using MYNEWS.Models;

namespace MYNEWS.ViewModels
{
    public class NewsSingleVm
    {
        public NewsSingle NewsDetails { get; set; }
        public List<RelatedNews> RelatedNews { get; set; }
        public List<UserComment> UserComment { get; set; }
    }

    public class RelatedNews
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string PhotoPathLikeForTrending { get; set; }
        public string Category { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class UserComment
    {
        public int Id { get; set; }
        public int CommentsCount { get; set; }
        public string ProfilePhotoPath { get; set; }
        public string FullName { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
