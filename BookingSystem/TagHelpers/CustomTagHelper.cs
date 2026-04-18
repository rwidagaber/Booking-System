
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace BookingSystem.TagHelpers
{
    //[HtmlTargetElement("custom-tag")]
    public class CustomTagHelper:TagHelper
    {
       
        
        public string Text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1"; 
            output.Content.SetContent(Text); 
        }
    }
}
