#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8c039adc41b66654527344679107cd446123f31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_oneDish), @"mvc.1.0.view", @"/Views/Home/oneDish.cshtml")]
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
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c039adc41b66654527344679107cd446123f31", @"/Views/Home/oneDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_oneDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
Write(ViewBag.oneDish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
Write(ViewBag.oneDish.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr>\r\n<p>");
#nullable restore
#line 4 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
Write(ViewBag.oneDish.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><span font-weight=\"bold\">Calories: </span>");
#nullable restore
#line 5 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
                                        Write(ViewBag.oneDish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><span font-weight=\"bold\">Tastiness: </span>");
#nullable restore
#line 6 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
                                         Write(ViewBag.oneDish.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 324, 2);
            WriteAttributeValue("", 293, "/delete/", 293, 8, true);
#nullable restore
#line 7 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
WriteAttributeValue("", 301, ViewBag.oneDish.DishId, 301, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n<a class=\"btn btn-light\"");
            BeginWriteAttribute("href", " href=\"", 362, "\"", 398, 2);
            WriteAttributeValue("", 369, "/edit/", 369, 6, true);
#nullable restore
#line 8 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\CRUDelicious\Views\Home\oneDish.cshtml"
WriteAttributeValue("", 375, ViewBag.oneDish.DishId, 375, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
