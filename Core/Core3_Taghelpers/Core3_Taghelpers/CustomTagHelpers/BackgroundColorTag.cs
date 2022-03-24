using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core3_Taghelpers.CustomTagHelpers
{
    [HtmlTargetElement(Attributes ="background-color")]
    public class BackgroundColorTag : TagHelper
    {
        public string BackgroundColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BackgroundColor}");
        }

    }
}
