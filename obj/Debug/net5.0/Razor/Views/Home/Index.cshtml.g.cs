#pragma checksum "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5669ac0a80b0600e77e9959bb940c159bf38f948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Step_student\source\repos\MVC_Begin\Views\_ViewImports.cshtml"
using MVC_Begin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Step_student\source\repos\MVC_Begin\Views\_ViewImports.cshtml"
using MVC_Begin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5669ac0a80b0600e77e9959bb940c159bf38f948", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da918f8ce37f675bcbc9e32eeafaf80c57033d35", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Begin.Models.Phone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
      
          ViewData["Title"] = "Список телефонов";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
       <table class=""table"">
           <thead>
               <tr>
                   <td>Компания</td>
                   <td>Модель</td>
                   <td>Цена</td>
                   <td></td>
               </tr>
           </thead>
           <tbody>
");
#nullable restore
#line 19 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
                foreach(var phone in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <tr>\r\n                   <td>");
#nullable restore
#line 22 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
                  Write(phone.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 23 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
                  Write(phone.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 24 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
                  Write(phone.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td><a");
            BeginWriteAttribute("href", " href =\"", 706, "\"", 733, 2);
            WriteAttributeValue("", 714, "/Home/Buy/", 714, 10, true);
#nullable restore
#line 25 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
WriteAttributeValue("", 724, phone.Id, 724, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Купить</a></td>\r\n               </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Step_student\source\repos\MVC_Begin\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </tbody>\r\n       </table>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Begin.Models.Phone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
