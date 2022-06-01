using EPiServer.Core;

namespace epi_razor_pages.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}