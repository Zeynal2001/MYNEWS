namespace MYNEWS.Entities
{
    public class NewsTag : BaseEntity
    {
        public string TagName { get; set; }
        public List<News> News { get; set; }
    }
}
