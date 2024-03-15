using MYNEWS.Entities;
using MYNEWS.Models;

namespace MYNEWS.ViewModels
{
    public class HomeIndexVm
    {
        public List<SliderItem> TrendingNews { get; set; }
        public List<SliderItem> RecentNews { get; set; }
        public List<CategoryModel>? Categories { get; set; }
        public List<TagModel> Tags { get; set; }
    }
}
