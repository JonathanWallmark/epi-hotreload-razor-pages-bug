using EPiServer.Web;
using Microsoft.AspNetCore.Http;

namespace epi_razor_pages.Business.Channels
{
    //<summary>
    // Defines the 'Mobile' content channel
    //</summary>
    public class MobileChannel : DisplayChannel
    {
        public const string Name = "mobile";

        public override string ChannelName => Name;

        public override string ResolutionId => typeof(IphoneVerticalResolution).FullName;

        public override bool IsActive(HttpContext context)
        {
            return false;
        }
    }
}