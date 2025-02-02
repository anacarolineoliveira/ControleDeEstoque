﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ControleDeEstoque.TagHelpers
{
    public class MensagemTagHelper : TagHelper
    {
        public string Texto { get; set; }

        public string Class { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                output.TagName = "div";

                output.Attributes.SetAttribute("class", string.IsNullOrEmpty(Class)?"my-3 alert alert-success":Class); 

                output.Content.SetContent(Texto);
            }
           
        }

    }
}
