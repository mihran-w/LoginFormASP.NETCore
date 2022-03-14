using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ContactProject.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("pass",TagStructure = TagStructure.NormalOrSelfClosing)]
    public class PassTagHelper : TagHelper
    {
        public string pass { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"tel:{pass}");
            output.Content.AppendHtml(pass);
        }
    }
}
