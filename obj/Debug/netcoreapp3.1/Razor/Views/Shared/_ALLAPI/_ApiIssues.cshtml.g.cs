#pragma checksum "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afaac9d91a16a4455f81d0d767e5fe64f74253a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ALLAPI__ApiIssues), @"mvc.1.0.view", @"/Views/Shared/_ALLAPI/_ApiIssues.cshtml")]
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
#line 1 "C:\ProjectsC#\APIDashboard\Views\_ViewImports.cshtml"
using APIDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProjectsC#\APIDashboard\Views\_ViewImports.cshtml"
using APIDashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afaac9d91a16a4455f81d0d767e5fe64f74253a", @"/Views/Shared/_ALLAPI/_ApiIssues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e219fcd5f768228764250574bc0ae13009fc2449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ALLAPI__ApiIssues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-xs-7 col-md-12 col-lg-12 col-xl-12\">\r\n        <div class=\"card shadow mb-4\">\r\n            <div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\">\r\n");
#nullable restore
#line 5 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                 foreach (Issues myIssue in Model._Issues)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a data-toggle=\"collapse\" href=\"#issues\" class=\"card-header-link-title\">");
#nullable restore
#line 7 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                                                                                       Write(myIssue.TitleIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 8 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div id=""issues"" class=""panel-collapse collapse"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th class=""issue-font"" scope=""col"">#</th>
                            <th class=""issue-font"" scope=""col"">Issue</th>
                            <th class=""issue-font"" scope=""col"">Status</th>
                            <th class=""issue-font"" scope=""col"">Planned</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 21 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                         foreach (Issues myIssue in Model._Issues)
                        {
                            var style = (myIssue.StateIssue == "DONE") ? "color:#28a745;font-weight:bold;text-align:center;font-family: 'Montserrat-Light', sans-serif" : "color:#007bff;font-weight:bold;text-align:center;font-family: 'Montserrat-Light', sans-serif";
                            var style1 = (myIssue.StateIssue == "Nothing to report") ? "color:#28a745;font-weight:bold;text-align:center;font-family: 'Montserrat-Light', sans-serif" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th class=\"issue-font-content\" scope=\"row\">");
#nullable restore
#line 26 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                                                                      Write(myIssue.NumberIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td class=\"issue-font-content-j\">");
#nullable restore
#line 27 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                                                            Write(myIssue.ExplicationIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td");
            BeginWriteAttribute("style", " style=\"", 1838, "\"", 1860, 3);
#nullable restore
#line 28 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
WriteAttributeValue("", 1846, style, 1846, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1852, ";", 1852, 1, true);
#nullable restore
#line 28 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
WriteAttributeValue("", 1853, style1, 1853, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"stateIssue\">");
#nullable restore
#line 28 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                                                                      Write(myIssue.StateIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"issue-font-content\">");
#nullable restore
#line 29 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                                                          Write(myIssue.DateOfResolutionIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 31 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ApiIssues.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
