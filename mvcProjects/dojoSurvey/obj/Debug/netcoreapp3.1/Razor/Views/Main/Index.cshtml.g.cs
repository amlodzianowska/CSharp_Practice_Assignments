#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\mvcProjects\dojoSurvey\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bb47eaf68d7dbcd40ea016dc2c5aeb6d80c5c80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb47eaf68d7dbcd40ea016dc2c5aeb6d80c5c80", @"/Views/Main/Index.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">

<h2>Dojo Survey</h2>
<div class=""text-center"">
    <div class=""container"">
        <form class = ""form"" action=""results"" method=""post"">
            <div div class=""mb-3"">
                <label class=""form-label"" for=""userName"">Your Name</label>
                <input class=""form-control"" type=""text"" name=""userName"">
            </div>
            <div div class=""mb-3"">
                <label class=""form-label"" for=""location"">Dojo Location:</label>
                <select class=""form-select"" name=""location"">
                    <option selected>Select Location</option>
                    <option value=""San Jose"">San Jose</option>
                    <option value=""Chicago"">Chicago</option>
                    <option value=""Miami"">Miami</option>
                </select>
           ");
            WriteLiteral(@" </div>
            <div div class=""mb-3"">
                <label class=""form-label"" for=""language"">Favorite Language:</label>
                <select class=""form-select"" name=""language"">
                    <option selected>Select Language</option>
                    <option value=""C#"">C#</option>
                    <option value=""Python"">Python</option>
                    <option value=""Java"">Java</option>
                </select>
            </div>
            <div class=""mb-3"">
                <label class=""form-label"" for=""comment"">Comment (optional): </label>
                <textarea name=""comment"" class=""form-control""></textarea>
            </div>
            <div div class=""mb-3"">
                <input class=""btn btn-primary"" type=""submit"" value=""Submit"">
            </div>
        </form>
    </div>

    
</div>
");
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
