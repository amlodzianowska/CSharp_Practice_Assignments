#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30bf924142c9a86777aa9ba6dfba0a0446f43218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneWedding), @"mvc.1.0.view", @"/Views/Home/OneWedding.cshtml")]
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
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\_ViewImports.cshtml"
using weddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\_ViewImports.cshtml"
using weddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30bf924142c9a86777aa9ba6dfba0a0446f43218", @"/Views/Home/OneWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d2f7e7fad137d735531a94f00fd8cb8297fea8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
Write(Model.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
                  Write(Model.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding</h1>\r\n<h3>Date: ");
#nullable restore
#line 3 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
     Write(Model.WeddingDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Guests:</h3>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
  
        foreach(Attendance a in @Model.WeddingGuests)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 9 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
           Write(a.Guest.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
                          Write(a.Guest.LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\weddingPlanner\Views\Home\OneWedding.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591