using epi_razor_pages.Models.Pages;
using EPiServer.Web.Mvc;

namespace epi_razor_pages.Pages.Start
{
    public class StartPageModel : RazorPageModel<StartPage>
    {
        public string WorkingReload { get; set; }

        public void OnGet()
        {
            WorkingReload = "Changing this property value works.";
        }
    }
}
