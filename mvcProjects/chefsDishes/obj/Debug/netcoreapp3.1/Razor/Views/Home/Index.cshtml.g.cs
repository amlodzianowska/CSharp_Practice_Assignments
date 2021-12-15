#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac6044177e4a8b0bb24ac63469dc5d985a359a2"
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
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\_ViewImports.cshtml"
using chefsDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\_ViewImports.cshtml"
using chefsDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac6044177e4a8b0bb24ac63469dc5d985a359a2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b6cabc5b9cbbb7aea65db454b3a0c150ce4c2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h2>Check out our roster of Chefs!</h2>
    <hr>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Age</th>
                <th scope=""col""># of Dishes</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
              
                foreach (Chef ch in ViewBag.AllChefs)
                {
                    int age = @DateTime.Now.Year - @ch.Birthday.Year;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
                       Write(ch.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
                                 Write(ch.LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
                       Write(age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
                       Write(ch.MyDishes.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\chefsDishes\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
