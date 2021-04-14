#pragma checksum "C:\ProjectsC#\APIDashboard\Views\PreProduction\_PopupSBM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1796442b596b35c2ed9eb029a812dded9eebe962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PreProduction__PopupSBM), @"mvc.1.0.view", @"/Views/PreProduction/_PopupSBM.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1796442b596b35c2ed9eb029a812dded9eebe962", @"/Views/PreProduction/_PopupSBM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e219fcd5f768228764250574bc0ae13009fc2449", @"/Views/_ViewImports.cshtml")]
    public class Views_PreProduction__PopupSBM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-xs-5 col-md-2 col-lg-2 col-xl-2 navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse delete-padding-exclam-point"">
	<button id=""myBtnSBM"" class=""buttonExclamationPopup""><i class='fas fa-exclamation-circle'></i></button>
</div>
<div id=""myPopupSBM"" class=""popupSBM"">
	<div class=""popup-content-SBM"">
		<div class=""popup-title-SBM"">
			<span class=""closeSBM"">&times;</span>
			<h2 class=""popup-title-h2-SBM"">Status</h2>
		</div>
		<div class=""contentSBM"">
			<p class=""content-h2-SBM"">Each API method will be assigned to a different status like explained below:</p>
			<ul>
				<li>
					<p class=""content-ul-li-SBM"">
						<b class=""green"">OK</b>: All informations can be get by our API method and informations are available from your seller's zone.</p>
				</li>
				<li>
					<p class=""content-ul-li-SBM"">
						<b class=""orange"">NOK</b>: Some issue has been detected like a non update of offers in your Products catalog page of your seller's zone but informations can be get from");
            WriteLiteral(@" API method.</p>
				</li>
				<li>
					<p class=""content-ul-li-SBM"">
						<b class=""red"">KO</b>: An issue has been detected about this API method and our team are mobilized to resolved this problem. Some API method are down. No informations are reported.</p>
				</li>
			</ul>
		</div>
		<div class=""BtnCenterSBM""><button type=""button"" class=""btn colorBackGrdBtnSBM"" name=""closeSBM"">Close</button></div>
</div>
</div>

<script>
    var popupSBM = document.getElementById(""myPopupSBM"");
    var btnSBM = document.getElementById(""myBtnSBM"");
    var spanSBM = document.getElementsByClassName(""closeSBM"")[0];
    btnSBM.onclick = function() {
        popupSBM.style.display = ""block"";
    }
    spanSBM.onclick = function() {
        popupSBM.style.display = ""none"";
    }
    window.onclick = function(event) {
        if (event.target == popupSBM) {
            popupSBM.style.display = ""none"";
        }
    }
    $(popupSBM).find(""button[name=closeSBM]"").on(""click"", function() {
		if ($("".f");
            WriteLiteral("ormElementError\").is(\':visible\')) {\r\n\t\t\t$(\".formElementError\").remove();\r\n\t\t}\r\n\t\t$(popupSBM).hide();\r\n\t});\r\n</script>");
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
