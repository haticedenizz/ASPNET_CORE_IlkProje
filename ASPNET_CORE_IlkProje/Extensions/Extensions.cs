using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_CORE_IlkProje.Extensions
{
    static public class Extensions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlhelper,string name,string value)
            //{ tek satır return ediliyorsa 
        => htmlhelper.TextBox(name, value, new
            {
                @class = "form-input",
                style = "background-color:green"
            });

        
    }
}
