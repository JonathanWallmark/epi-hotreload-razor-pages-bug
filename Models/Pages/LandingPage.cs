using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Models;
using System.ComponentModel.DataAnnotations;

namespace epi_razor_pages.Models.Pages
{
    /// <summary>
    /// Used for campaign or landing pages, commonly used for pages linked in online advertising such as AdWords
    /// </summary>
    [SiteContentType(
       GUID = "DBED4258-8213-48DB-A11F-99C034172A54",
       GroupName = Globals.GroupNames.Specialized)]
    [SiteImageUrl]
    public class LandingPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

    }
}