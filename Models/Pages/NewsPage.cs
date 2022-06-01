using System.ComponentModel.DataAnnotations;
using epi_razor_pages.Business;
using epi_razor_pages.Models.Blocks;
using EPiServer.DataAbstraction;
using EPiServer.Filters;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;
using Models;

namespace epi_razor_pages.Models.Pages
{
    /// <summary>
    /// Presents a news section including a list of the most recent articles on the site
    /// </summary>
    [SiteContentType(GUID = "638D8271-5CA3-4C72-BABC-3E8779233263")]
    [SiteImageUrl]
    public class NewsPage : StandardPage
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 305)]
        public virtual PageListBlock NewsList { get; set; }
    }
}