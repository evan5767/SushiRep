#pragma checksum "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Offert\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e4caa415e9a54b273a1f2a97d0ed4ab4999356399c6740027c223ee8b8d23bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offert_Index), @"mvc.1.0.view", @"/Views/Offert/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Offert/Index.cshtml", typeof(AspNetCore.Views_Offert_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e4caa415e9a54b273a1f2a97d0ed4ab4999356399c6740027c223ee8b8d23bb7", @"/Views/Offert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f55ede54582f2ea85aba1581f2c71d6fb438f08968c7959a64ac368674e3dcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Offert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OffertViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 53, true);
            WriteLiteral("\r\n<h1>Предложения</h1>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 5 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Offert\Index.cshtml"
      
        foreach (Food food in Model.FavFoods)
        {
            

#line default
#line hidden
            BeginContext(156, 27, false);
#line (8,14)-(8,41) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Offert\Index.cshtml"
Write(Html.Partial("Foods", food));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Offert\Index.cshtml"
                                        
        }
    

#line default
#line hidden
            BeginContext(203, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OffertViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
