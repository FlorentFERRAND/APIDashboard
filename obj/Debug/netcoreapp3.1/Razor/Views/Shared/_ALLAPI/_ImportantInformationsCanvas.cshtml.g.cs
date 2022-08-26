#pragma checksum "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1499a34635ff16f2669a73e1063ce9843a4a01d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ALLAPI__ImportantInformationsCanvas), @"mvc.1.0.view", @"/Views/Shared/_ALLAPI/_ImportantInformationsCanvas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1499a34635ff16f2669a73e1063ce9843a4a01d3", @"/Views/Shared/_ALLAPI/_ImportantInformationsCanvas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e219fcd5f768228764250574bc0ae13009fc2449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ALLAPI__ImportantInformationsCanvas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Popup/_PopupII", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-xl-9 col-lg-8 col-md-7 col-xs-6\">\r\n        <div class=\"card shadow mb-4\">\r\n            <div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\">\r\n");
#nullable restore
#line 5 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                 foreach (Informations myInfos in Model._Informations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"text-issue\" id=\"text-issue-II\">");
#nullable restore
#line 7 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                         Write(myInfos.TitleImportantInformations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 8 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1499a34635ff16f2669a73e1063ce9843a4a01d34617", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-12 mb-4\">\r\n");
#nullable restore
#line 13 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                     foreach (Informations myInfos in Model._Informations)
                    {
                        var style = (myInfos.StateImportantInformations == "OK") ? "background-color:#1cc88a!important;color:#ffffff;font-size:16px!important;font-family:'Montserrat-Light',sans-serif" : "";
                        var style1 = (myInfos.StateImportantInformations == "KO") ? "background-color:#f2dede!important;color:#a94442;font-size:16px!important;font-family:'Montserrat-Light',sans-serif" : "";
                        var style2 = (myInfos.StateImportantInformations == "NOK") ? "background-color:#febe28!important;color:#ffffff;font-size:16px!important;font-family:'Montserrat-Light',sans-serif" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card bg-success text-white shadow\"");
            BeginWriteAttribute("style", " style=\"", 1376, "\"", 1406, 5);
#nullable restore
#line 18 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
WriteAttributeValue("", 1384, style, 1384, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1390, ";", 1390, 1, true);
#nullable restore
#line 18 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
WriteAttributeValue("", 1391, style1, 1391, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1398, ";", 1398, 1, true);
#nullable restore
#line 18 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
WriteAttributeValue("", 1399, style2, 1399, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-body\">\r\n                                <p");
            BeginWriteAttribute("style", " style=\"", 1497, "\"", 1527, 5);
#nullable restore
#line 20 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
WriteAttributeValue("", 1505, style, 1505, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1511, ";", 1511, 1, true);
#nullable restore
#line 20 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
WriteAttributeValue("", 1512, style1, 1512, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1519, ";", 1519, 1, true);
#nullable restore
#line 20 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
WriteAttributeValue("", 1520, style2, 1520, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"card-body\">");
#nullable restore
#line 20 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                            Write(myInfos.ImportantInfos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>                            \r\n");
#nullable restore
#line 23 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-4 col-md-5 col-xs-6"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
");
#nullable restore
#line 31 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                 foreach (PieChart myPieChart in Model._PieChart)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"text-issue\" id=\"text-issue-II\">");
#nullable restore
#line 33 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                         Write(myPieChart.TitlePieChart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 34 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""content-canvas"">
                <canvas id=""myPieChart""></canvas>
            </div>
            <script>
                var ctxP = document.getElementById(""myPieChart"").getContext('2d');
                var myPieChart = new Chart(ctxP, {
                type: 'pie',
                data: {
                    labels: [""");
#nullable restore
#line 44 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                               foreach (PieChart myPieChart in Model._PieChart) {
                                                    if (myPieChart.StatusByMethodPieChart == "OK") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                Write(myPieChart.StatusByMethodPieChart);

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                                                       ; }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 46 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                      foreach (PieChart myPieChart in Model._PieChart) {
                                                    if (myPieChart.StatusByMethodPieChart == "KO") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                Write(myPieChart.StatusByMethodPieChart);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                                                       ; }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 48 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                      foreach (PieChart myPieChart in Model._PieChart) {
                                                    if (myPieChart.StatusByMethodPieChart == "NOK") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                 Write(myPieChart.StatusByMethodPieChart);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                                                        ; }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\"],\r\n                    datasets: [{\r\n                    data: [");
#nullable restore
#line 52 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                            foreach (PieChart myPieChart in Model._PieChart) {
                                                    if (myPieChart.StatusByMethodPieChart == "OK") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                Write(myPieChart.NumberMethodsByStatus);

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                                                      ; }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n");
#nullable restore
#line 55 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                 foreach (PieChart myPieChart in Model._PieChart) {
                                                    if (myPieChart.StatusByMethodPieChart == "KO") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                Write(myPieChart.NumberMethodsByStatus);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                                                      ; }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n");
#nullable restore
#line 58 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                 foreach (PieChart myPieChart in Model._PieChart) {
                                                    if (myPieChart.StatusByMethodPieChart == "NOK") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                 Write(myPieChart.NumberMethodsByStatus);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\ProjectsC#\APIDashboard\Views\Shared\_ALLAPI\_ImportantInformationsCanvas.cshtml"
                                                                                                                                       ; }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                                            backgroundColor: [""#1CC88A"", ""#FF5A5E"", ""#FEBE28""],
                                            hoverBackgroundColor: [""#1CC88A"", ""#FF5A5E"", ""#FEBE28""]
                    }]
                },
                options: {
                    responsive: true
                }
                });
            </script>
        </div>
    </div>
</div>");
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
