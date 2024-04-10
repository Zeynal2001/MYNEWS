namespace MYNEWS.Models
{
    public class SearchModel
    {
        public List<SliderItem> FoundNews { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public string Query { get; set; }

    }
}
