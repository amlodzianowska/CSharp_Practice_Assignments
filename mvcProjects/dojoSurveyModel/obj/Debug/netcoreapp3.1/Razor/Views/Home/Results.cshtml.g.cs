#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8db657ade3b413cf8b42000306414c39506d9256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\_ViewImports.cshtml"
using dojoSurveyModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\_ViewImports.cshtml"
using dojoSurveyModel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db657ade3b413cf8b42000306414c39506d9256", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9a75086f7196b88ccaec6522c3f606c20f46d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Submitted Info</h1>\r\n<h2>User Name: ");
#nullable restore
#line 4 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\Home\Results.cshtml"
          Write(Model.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Dojo Location: ");
#nullable restore
#line 5 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\Home\Results.cshtml"
              Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Favorite Language: ");
#nullable restore
#line 6 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\Home\Results.cshtml"
                  Write(Model.language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Comments: ");
#nullable restore
#line 7 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurveyModel\Views\Home\Results.cshtml"
         Write(Model.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<a class=\"btn btn-primary\" href=\"/\">Go back</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
