#pragma checksum "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e94fd16889cce67ee19e82dc855555e1e2344d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\_ViewImports.cshtml"
using TumblrRipOff.Models;

#line default
#line hidden
#line 2 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e94fd16889cce67ee19e82dc855555e1e2344d6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60ff2ba08be2ac06d4f61e81f27e9c0222956ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en-us\">\r\n");
            EndContext();
            BeginContext(38, 397, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9ca5ccbe1d4b319782e61702dee849", async() => {
                BeginContext(44, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(58, 13, false);
#line 4 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(71, 357, true);
                WriteLiteral(@"</title>
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""Stylesheet"" href=""/css/default.css"" type=""text/css"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(435, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(437, 1583, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7b2e1ced1e425283e9721b17b28928", async() => {
                BeginContext(443, 131, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <nav class=\"navbar navbar-left navbar-dark bg-dark\">\r\n            <ul>\r\n                <li>");
                EndContext();
                BeginContext(575, 75, false);
#line 13 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Home", "Index", "Home", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(650, 27, true);
                WriteLiteral("</li>\r\n                <li>");
                EndContext();
                BeginContext(678, 88, false);
#line 14 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("My Profile", "MyProfile", "Profile", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(766, 27, true);
                WriteLiteral("</li>\r\n                <li>");
                EndContext();
                BeginContext(794, 90, false);
#line 15 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Create Post", "CreatePost", "Profile", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(884, 27, true);
                WriteLiteral("</li>\r\n                <li>");
                EndContext();
                BeginContext(912, 82, false);
#line 16 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
               Write(Html.ActionLink("Admin Page", "Index", "Admin", null, new { @class = "nav-link" }));

#line default
#line hidden
                EndContext();
                BeginContext(994, 38, true);
                WriteLiteral("</li>\r\n            </ul>\r\n            ");
                EndContext();
                BeginContext(1032, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bde73a597db64bffab28101b5ce7406e", async() => {
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
                EndContext();
                BeginContext(1064, 67, true);
                WriteLiteral("\r\n        </nav>\r\n    </div>\r\n    <div class=\"container\">\r\n        ");
                EndContext();
                BeginContext(1132, 12, false);
#line 22 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1144, 835, true);
                WriteLiteral(@"
    </div>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js"" integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="" crossorigin=""anonymous""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.1/jquery.validate.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.6/jquery.validate.unobtrusive.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
    ");
                EndContext();
                BeginContext(1980, 31, false);
#line 29 "G:\Documents\School\ASP GIT\CST465TermProject\ASP Final Project\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(2011, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2020, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
