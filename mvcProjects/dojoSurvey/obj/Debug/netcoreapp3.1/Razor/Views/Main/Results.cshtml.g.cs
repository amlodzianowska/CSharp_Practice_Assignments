#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurvey\Views\Main\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7b357ca4ce50df69d6167f40fc1ca14ee9b1e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Results), @"mvc.1.0.view", @"/Views/Main/Results.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7b357ca4ce50df69d6167f40fc1ca14ee9b1e4", @"/Views/Main/Results.cshtml")]
    public class Views_Main_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Submitted Info</h1>\r\n<h2>Name: ");
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurvey\Views\Main\Results.cshtml"
     Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Dojo Location: ");
#nullable restore
#line 3 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurvey\Views\Main\Results.cshtml"
              Write(ViewBag.dojoLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Favorite Language: ");
#nullable restore
#line 4 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurvey\Views\Main\Results.cshtml"
                  Write(ViewBag.language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Comment: ");
#nullable restore
#line 5 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurvey\Views\Main\Results.cshtml"
        Write(ViewBag.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
