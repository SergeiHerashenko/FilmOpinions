using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmOpinions.Domain.ViewModels.HomePage_Model
{
    public class HomePageModel
    {
        public List<HomePagePhotoURL> PhotoSite { get; }
        public List<HomePageSiteName> NameSite { get; }
        public string DescriptionText { get; }

        public HomePageModel()
        {
            PhotoSite = new List<HomePagePhotoURL> { new HomePagePhotoURL() };
            NameSite = new List<HomePageSiteName> { new HomePageSiteName() };
            DescriptionText = new HomePageDescriptionText().DescriptionText;
        }

        public List<HomePageModel> GetContent()
        {
            List<HomePageModel> ContentsSite = new List<HomePageModel>
            {
                new HomePageModel()
            };

            return ContentsSite;
        }
    }
}
