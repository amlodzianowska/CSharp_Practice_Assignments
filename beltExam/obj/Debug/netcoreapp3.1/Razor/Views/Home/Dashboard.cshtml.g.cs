#pragma checksum "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f41420a2ae5f4a3a0dce82eab3e22315054c70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\_ViewImports.cshtml"
using beltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\_ViewImports.cshtml"
using beltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f41420a2ae5f4a3a0dce82eab3e22315054c70", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b317a7d697ae73a9ac90a2759213fb6e1f4a84", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Dojo Activity Center, welcome ");
#nullable restore
#line 1 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                             Write(ViewBag.LoggedInUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Activity</th>
            <th scope=""col"">Date and Time</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Event Coordinator</th>
            <th scope=""col"">No. of Participants</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
          
            if(ViewBag.AllActivities == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>No Activities yet</h4>\r\n");
#nullable restore
#line 19 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
            }else{
                foreach(DojoActivity w in ViewBag.AllActivities)
                {
                    int yearCompare = @w.ActivityDate.Year - @DateTime.Now.Year;
                    int monthCompare = @w.ActivityDate.Month - @DateTime.Now.Month;
                    int dayCompare = @w.ActivityDate.Day - @DateTime.Now.Day;
                    if (0>yearCompare || yearCompare == 0 && 0>monthCompare || yearCompare == 0 && monthCompare == 0 && 0>dayCompare)
                    {
                        continue;
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1197, "\"", 1231, 2);
            WriteAttributeValue("", 1204, "/activity/", 1204, 10, true);
#nullable restore
#line 30 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1214, w.DojoActivityId, 1214, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                                                                 Write(w.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                           Write(w.ActivityDate.ToString("MMMM dd, yyyy @"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 31 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                                                                        Write(w.ActivityTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                           Write(w.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                                       Write(w.DurationUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                           Write(w.Coordinator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                           Write(w.Atendees.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                              
                                if(@w.Coordinator.UserId == @ViewBag.LoggedInUser.UserId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1752, "\"", 1784, 2);
            WriteAttributeValue("", 1759, "/delete/", 1759, 8, true);
#nullable restore
#line 38 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1767, w.DojoActivityId, 1767, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n");
#nullable restore
#line 39 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                                }else{
                                    if(w.Atendees.Any(f => f.UserId == ViewBag.LoggedInUser.UserId))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2038, "\"", 2098, 4);
            WriteAttributeValue("", 2045, "/leave/", 2045, 7, true);
#nullable restore
#line 42 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2052, w.DojoActivityId, 2052, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2069, "/", 2069, 1, true);
#nullable restore
#line 42 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2070, ViewBag.LoggedInUser.UserId, 2070, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Leave</a></td>\r\n");
#nullable restore
#line 43 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                                        }else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2239, "\"", 2298, 4);
            WriteAttributeValue("", 2246, "/join/", 2246, 6, true);
#nullable restore
#line 44 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2252, w.DojoActivityId, 2252, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2269, "/", 2269, 1, true);
#nullable restore
#line 44 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2270, ViewBag.LoggedInUser.UserId, 2270, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Join</a></td>\r\n");
#nullable restore
#line 45 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                                        }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\anmlo\Desktop\Dojo_Assignments\csharp\beltExam\Views\Home\Dashboard.cshtml"
                    }
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/newActivity\" class=\"btn btn-primary\">Add New Activity</a>");
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