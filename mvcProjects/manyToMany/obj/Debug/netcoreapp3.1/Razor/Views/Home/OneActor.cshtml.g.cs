#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06be4338bc18828c9dc983000413e1677df21c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneActor), @"mvc.1.0.view", @"/Views/Home/OneActor.cshtml")]
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
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\_ViewImports.cshtml"
using manyToMany;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\_ViewImports.cshtml"
using manyToMany.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06be4338bc18828c9dc983000413e1677df21c8b", @"/Views/Home/OneActor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1227055714310189377164aef0ec9ece076945b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneActor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Actor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addRole"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
Write(Model.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 3 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
            Write(Model.LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>Appeared in:</h3>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
      
        foreach(Cast c in Model.ActedIn)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 9 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
           Write(c.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 175, "\"", 226, 4);
            WriteAttributeValue("", 182, "/delete/cast/", 182, 13, true);
#nullable restore
#line 9 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
WriteAttributeValue("", 195, Model.ActorId, 195, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 209, "/", 209, 1, true);
#nullable restore
#line 9 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
WriteAttributeValue("", 210, c.Movie.MovieId, 210, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">X</a></li>\r\n");
#nullable restore
#line 10 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 267, "\"", 302, 2);
            WriteAttributeValue("", 274, "/actor/delete/", 274, 14, true);
#nullable restore
#line 13 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
WriteAttributeValue("", 288, Model.ActorId, 288, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06be4338bc18828c9dc983000413e1677df21c8b6600", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"MovieId\">Add Movie</label>\r\n        <select name=\"MovieId\" class=\"form-control col-4\">\r\n");
#nullable restore
#line 19 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
              
                foreach (Movie a in @ViewBag.AllMovies)
                {
                    if(!Model.ActedIn.Any(t => t.MovieId == a.MovieId))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06be4338bc18828c9dc983000413e1677df21c8b7435", async() => {
#nullable restore
#line 24 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
                                              Write(a.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
                           WriteLiteral(a.MovieId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <input type=\"hidden\" name=\"ActorId\"");
                BeginWriteAttribute("value", " value=\"", 904, "\"", 926, 1);
#nullable restore
#line 30 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\manyToMany\Views\Home\OneActor.cshtml"
WriteAttributeValue("", 912, Model.ActorId, 912, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <input type=\"submit\" value=\"Add Movie\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Actor> Html { get; private set; }
    }
}
#pragma warning restore 1591
