#pragma checksum "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1527789ed73625752ad242125fdbccebc7f0d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Index.cshtml", typeof(AspNetCore.Views_HelloWorld_Index))]
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
#line 1 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host;

#line default
#line hidden
#line 3 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host.Models;

#line default
#line hidden
#line 4 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\_ViewImports.cshtml"
using gimmegif.web.host.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1527789ed73625752ad242125fdbccebc7f0d28", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03ff2743f67e7d00456811e71033eab3c83d6d4", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gimmegif.web.host.Models.HelloWorldViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HelloWorld", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\HelloWorld\Index.cshtml"
  
    ViewData["Title"] = "!!!GIMMEGIF!!!";

#line default
#line hidden
            BeginContext(119, 25, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(145, 10, false);
#line 7 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\HelloWorld\Index.cshtml"
Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(155, 33, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(188, 978, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537e5c35dfd24a91900aa9956519b110", async() => {
                BeginContext(285, 407, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <div class=""col-md-10"">
                <p>Upload one or more files using this form:</p>
                <input type=""file"" name=""TheImages"" multiple />
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-10"">
                <p>Delay in milliseconds:</p>
                <input type=""number"" name=""Delay""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 692, "\"", 712, 1);
#line 20 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\HelloWorld\Index.cshtml"
WriteAttributeValue("", 700, Model.Delay, 700, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(713, 214, true);
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                <p>Textgrootte: (default 48)</p>\r\n                <input type=\"number\" name=\"TextSize\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 927, "\"", 950, 1);
#line 26 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\HelloWorld\Index.cshtml"
WriteAttributeValue("", 935, Model.TextSize, 935, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(951, 208, true);
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                <input type=\"submit\" value=\"Upload\" />\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1166, 12, true);
            WriteLiteral("\r\n\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1178, "\"", 1197, 1);
#line 36 "C:\Users\Pascal\Documents\GitHub\gifBuilder\gimmegif.web.host\gimmegif.web.host\Views\HelloWorld\Index.cshtml"
WriteAttributeValue("", 1184, Model.TheGif, 1184, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1198, 39, true);
            WriteLiteral(" alt=\"GIMMEGIF\" border=\"0\" />\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gimmegif.web.host.Models.HelloWorldViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
