using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThesisProject.WebApp.Models;
using ThesisProject.WebApp.Models.Pacients;

namespace ThesisProject.WebApp.TagHelpers
{
    public class PageLinkTagHalper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHalper(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public PacientSearchViewModel PacientSearch { get; set; }
        public string PageAction { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            output.TagName = "nav";

            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination");

            TagBuilder prevItem = CreateTag("Previous", PageViewModel.HasPrebiousPage,
                PageViewModel.Page - 1, urlHelper);
            ul.InnerHtml.AppendHtml(prevItem);

            for (int i = 1; i <= PageViewModel.TotalPages; i++)
            {
                TagBuilder tag = CreateTag(i, urlHelper);
                ul.InnerHtml.AppendHtml(tag);
            }
            TagBuilder nextItem = CreateTag("Previous", PageViewModel.HasNextPage,
                PageViewModel.Page + 1, urlHelper);
            ul.InnerHtml.AppendHtml(nextItem);

            output.Content.AppendHtml(ul);
        }
        TagBuilder CreateTag(int pageNumber, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (pageNumber == this.PageViewModel.Page)
            {
                item.AddCssClass("active");
            }
            else
            {
                link.Attributes["href"] = urlHelper.Action(PageAction, new { page = pageNumber, pacientSearch = PacientSearch });
            }
            item.AddCssClass("page-item");
            link.AddCssClass("page-link");
            link.InnerHtml.Append(pageNumber.ToString());
            item.InnerHtml.AppendHtml(link);
            return item;
        }
        TagBuilder CreateTag(string text, bool active, int page, IUrlHelper urlHelper)
        {
            TagBuilder item = new TagBuilder("li");
            TagBuilder link = new TagBuilder("a");
            if (active)
            {
                link.Attributes["href"] = urlHelper.Action(PageAction, new { page = PageViewModel.Page - 1 });
            }
            else
            {
                item.AddCssClass("disabled");
            }
            item.AddCssClass("page-item");
            link.AddCssClass("page-link");
            link.InnerHtml.Append(text);
            item.InnerHtml.AppendHtml(link);
            return item;
        }
    }
}
