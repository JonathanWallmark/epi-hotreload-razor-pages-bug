using System.ComponentModel.DataAnnotations;
using epi_razor_pages.Models.Pages;
using EPiServer.Web;
using Microsoft.AspNetCore.Html;

namespace epi_razor_pages.Models.ViewModels;

public class ContactBlockModel
{
    [UIHint(UIHint.Image)]
    public ContentReference Image { get; set; }

    public string Heading { get; set; }

    public string LinkText { get; set; }

    public IHtmlContent LinkUrl { get; set; }

    public bool ShowLink { get; set; }

    public ContactPage ContactPage { get; set; }
}
