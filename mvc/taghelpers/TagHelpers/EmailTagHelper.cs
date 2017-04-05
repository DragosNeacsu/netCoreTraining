using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taghelpers.TagHelpers
{
	[HtmlTargetElement("email")]
	public class EmailTagHelper : TagHelper
	{
		public string To { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "a";
			output.Attributes.SetAttribute("href", $"mailto:{To}");
		}
	}
}
