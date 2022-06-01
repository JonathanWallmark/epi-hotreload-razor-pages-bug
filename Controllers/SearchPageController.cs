using epi_razor_pages.Models.Pages;
using epi_razor_pages.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace epi_razor_pages.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        public ViewResult Index(SearchPage currentPage, string q)
        {
            var model = new SearchContentModel(currentPage)
            {
                Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
                NumberOfHits = 0,
                SearchServiceDisabled = true,
                SearchedQuery = q
            };

            return View(model);
        }
    }
}