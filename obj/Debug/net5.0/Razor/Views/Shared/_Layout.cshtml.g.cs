#pragma checksum "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d041"
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
#line 1 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi;

#line default
#line hidden
#line 2 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.Data.Models;

#line default
#line hidden
#line 3 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.Data.Repisitory;

#line default
#line hidden
#line 1 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d041", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f55ede54582f2ea85aba1581f2c71d6fb438f08968c7959a64ac368674e3dcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bannera.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("banner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; height: auto; display: block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
  
    var isAdmin = User.IsInRole("admin");
    var isUser = User.IsInRole("user");

#line default
#line hidden
            BeginContext(167, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(204, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d0419492", async() => {
                BeginContext(210, 102, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(313, 13, false);
#line (13,13)-(13,26) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(326, 14, true);
                WriteLiteral("</title>\r\n    ");
                EndContext();
                BeginContext(340, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04110366", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(412, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(421, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(423, 7120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04112607", async() => {
                BeginContext(429, 1809, true);
                WriteLiteral(@"
    <header>
        <div class=""px-3 py-2 text-bg-dark border-bottom"">
            <div class=""container"">
                <div class=""d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start"">
                    <a href=""/"" class=""d-flex align-items-center my-2 my-lg-0 me-lg-auto text-white text-decoration-none"">
                        <svg class=""bi me-2"" width=""40"" height=""32"" role=""img"" aria-label=""Bootstrap""><use xlink:href=""#bootstrap""></use></svg>
                    </a>

                    <ul class=""nav col-12 col-lg-auto my-2 justify-content-center my-md-0 text-small"">
                        <li>
                            <a href=""/Offert/Index"" class=""nav-link text-white"">
                                <svg class=""bi d-block mx-auto mb-1"" width=""24"" height=""24""><use xlink:href=""#grid""></use></svg>
                                Главная
                            </a>
                        </li>
                        <li>
                 ");
                WriteLiteral(@"           <a href=""/ShopCart/Index"" class=""nav-link text-white"">
                                <svg class=""bi d-block mx-auto mb-1"" width=""24"" height=""24""><use xlink:href=""#table""></use></svg>
                                Корзина
                            </a>
                        </li>
                        <li>
                            <a href=""/Home/Contacts"" class=""nav-link text-white"">
                                <svg class=""bi d-block mx-auto mb-1"" width=""24"" height=""24""><use xlink:href=""#grid""></use></svg>
                                Контакты
                            </a>
                        </li>
                    </ul>
                    <ul class=""nav col-12 col-lg-auto my-2 justify-content-center my-md-0 text-small"">
");
                EndContext();
#line 46 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
                BeginContext(2334, 133, true);
                WriteLiteral("                            <li>\r\n                                <p style=\"margin-right: 15px; margin-top: 30px; color: slateblue;\">");
                EndContext();
                BeginContext(2468, 18, false);
#line (49,101)-(49,119) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2486, 107, true);
                WriteLiteral("</p>\r\n                            </li>\r\n                            <li>\r\n                                ");
                EndContext();
                BeginContext(2593, 224, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04115846", async() => {
                    BeginContext(2658, 152, true);
                    WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Выход\" style=\"display: inline; margin-top: 30px;\" />\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2817, 37, true);
                WriteLiteral("\r\n                            </li>\r\n");
                EndContext();
#line 57 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
                                 if (isAdmin)
                                {

#line default
#line hidden
                BeginContext(2938, 810, true);
                WriteLiteral(@"                                <li>
                                    <a href=""/AddFood/AddNewFood"" class=""nav-link text-white"">
                                        <svg class=""bi d-block mx-auto mb-1"" width=""24"" height=""24""><use xlink:href=""#grid""></use></svg>
                                        Управление
                                    </a>
                                </li>
                                <li>
                                    <a href=""/ViewOrder/OrderDetails"" class=""nav-link text-white"">
                                        <svg class=""bi d-block mx-auto mb-1"" width=""24"" height=""24""><use xlink:href=""#grid""></use></svg>
                                        Заказы
                                    </a>
                                </li>
");
                EndContext();
#line 71 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
                                }

#line default
#line hidden
#line 71 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(3879, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(3907, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04119910", async() => {
                    BeginContext(3982, 4, true);
                    WriteLiteral("Вход");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3990, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4020, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04121723", async() => {
                    BeginContext(4070, 11, true);
                    WriteLiteral("Регистрация");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4085, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 77 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
                BeginContext(4118, 198, true);
                WriteLiteral("                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n\r\n    <div class=\"col-lg-6 px-0\" style=\"width: 100vw;\">\r\n        ");
                EndContext();
                BeginContext(4316, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04123904", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4409, 113, true);
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n    <div class=\"owl-controls clickable\"><div class=\"owl-pagination\"><div class=\"owl-page\"><span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4522, "\"", 4530, 0);
                EndWriteAttribute();
                BeginContext(4531, 41, true);
                WriteLiteral("></span></div><div class=\"owl-page\"><span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4572, "\"", 4580, 0);
                EndWriteAttribute();
                BeginContext(4581, 41, true);
                WriteLiteral("></span></div><div class=\"owl-page\"><span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4622, "\"", 4630, 0);
                EndWriteAttribute();
                BeginContext(4631, 48, true);
                WriteLiteral("></span></div><div class=\"owl-page active\"><span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4679, "\"", 4687, 0);
                EndWriteAttribute();
                BeginContext(4688, 41, true);
                WriteLiteral("></span></div><div class=\"owl-page\"><span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4729, "\"", 4737, 0);
                EndWriteAttribute();
                BeginContext(4738, 2419, true);
                WriteLiteral(@"></span></div></div></div>
    </div>
    <nav class=""navbar navbar-expand-md bg-dark sticky-top border-bottom"" data-bs-theme=""dark"">
        <div class=""container"">
            <a class=""navbar-brand d-md-none"" href=""#"">
                <svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#aperture""></use></svg>
                Aperture
            </a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#offcanvas"" aria-controls=""offcanvas"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""offcanvas"" aria-labelledby=""offcanvasLabel"">
                <div class=""offcanvas-header"">
                    <h5 class=""offcanvas-title"" id=""offcanvasLabel"">Aperture</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""offcanvas"" aria-label=""Close""></button>
                </div>
                <");
                WriteLiteral(@"div class=""offcanvas-body"">
                    <ul class=""navbar-nav flex-grow-1 justify-content-between"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#aperture""></use></svg>
                            </a>
                        </li>
                        <li class=""nav-item""><a class=""nav-link"" href=""/Home/List/pizza"">Пицца</a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""/Home/List/rolls"">Холодные роллы</a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""/Home/List/salad"">Салаты</a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""/Home/List/drink"">Напитки</a></li>
                        <li class=""nav-item""><a class=""nav-link"" href=""/Home/List/WOK"">WOK</a></li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" hr");
                WriteLiteral(@"ef=""#"">
                                <svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#cart""></use></svg>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </nav>

    <div class=""container mt-5"">
        <main role=""main"" class=""pb-3"">
            ");
                EndContext();
                BeginContext(7158, 12, false);
#line (131,14)-(131,26) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7170, 192, true);
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"container\">\r\n        <p class=\"float-end\"><a href=\"#\">Back to top</a></p>\r\n        <p>© 2024 Все права защищены</p>\r\n\r\n\r\n    </footer>\r\n    ");
                EndContext();
                BeginContext(7362, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04129991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7407, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7413, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928da2d065b4dea96ee5b6cb5d5106f8e16432bced8d0cbe0e98c4a3c318d04131272", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#line 142 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7475, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7482, 52, false);
#line (143,6)-(143,58) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(7534, 2, true);
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
            BeginContext(7543, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManage { get; private set; }
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
