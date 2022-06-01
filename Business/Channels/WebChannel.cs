using EPiServer.Web;
using Microsoft.AspNetCore.Http;

namespace epi_razor_pages.Business.Channels
{
    /// <summary>
    /// Defines the 'Web' content channel
    /// </summary>
    public class WebChannel : DisplayChannel
    {
        public override string ChannelName => "web";

        public override bool IsActive(HttpContext context)
        {
            return true;
        }
    }
}