#pragma checksum "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe81f54090bbf20eb71a7c17e9caa79f724d122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe81f54090bbf20eb71a7c17e9caa79f724d122", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67d845e5371e4c720b943bf40f713afc7b23e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 61, true);
            WriteLiteral("\r\n<h1>Радимо до покупки</h1>\r\n<div class=\"row mt-5 mb-2\" />\r\n");
            EndContext();
#line 5 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Home\Index.cshtml"
      
        foreach (Book book in Model.favBooks)
        {
            

#line default
#line hidden
            BeginContext(162, 30, false);
#line 8 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Home\Index.cshtml"
       Write(Html.Partial("AllBooks", book));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Home\Index.cshtml"
                                           
        }
    

#line default
#line hidden
            BeginContext(212, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
