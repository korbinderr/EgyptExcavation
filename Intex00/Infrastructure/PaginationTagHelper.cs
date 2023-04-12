using Intex00.Models.MummyViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex00.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-blah")]
    public class PaginationTagHelper : TagHelper
    {

        //Dynamically Create the pages links for us

        private IUrlHelperFactory uhf;

        public PaginationTagHelper(IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        //Different from the View Context
        public PageInfo PageBlah { get; set; }
        public string PageAction { get; set; }
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string pageClassSelected { get; set; }

        //override means to use this method instead of the parent class
        public override void Process(TagHelperContext tch, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            TagBuilder final = new TagBuilder("div");

            for (int i = 1; i <= PageBlah.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");

                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i,
                    sex = vc.HttpContext.Request.Query["sex"],
                    depth = vc.HttpContext.Request.Query["depth"],
                    ageatdeath = vc.HttpContext.Request.Query["ageatdeath"],
                    headdirection = vc.HttpContext.Request.Query["headdirection"],
                    haircolor = vc.HttpContext.Request.Query["haircolor"],
                    textilecolor = vc.HttpContext.Request.Query["textilecolor"],
                    textilestructure = vc.HttpContext.Request.Query["textilestructure"],
                    burialid = vc.HttpContext.Request.Query["burialid"],
                    textilefunction = vc.HttpContext.Request.Query["textilefunction"]
                });
                if (PageClassesEnabled)
                {
                    tb.AddCssClass(PageClass);
                    tb.AddCssClass(i == PageBlah.CurrentPage
                        ? pageClassSelected : PageClassNormal);
                }
                tb.AddCssClass(PageClass);
                tb.InnerHtml.Append(i.ToString());

                final.InnerHtml.AppendHtml(tb);
            }

            tho.Content.AppendHtml(final.InnerHtml);
        }
    }
}