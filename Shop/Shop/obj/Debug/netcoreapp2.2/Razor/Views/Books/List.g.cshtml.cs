#pragma checksum "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Books\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50d9eee48eb799210c5be3efa91999fb8fc0cee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_List), @"mvc.1.0.view", @"/Views/Books/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/List.cshtml", typeof(AspNetCore.Views_Books_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d9eee48eb799210c5be3efa91999fb8fc0cee8", @"/Views/Books/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698b1ec29562463bc33480ac52eac0346944c13", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("\r\n<h1>Всі книжки</h1>\r\n<h3>");
            EndContext();
            BeginContext(28, 18, false);
#line 3 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Books\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
            EndContext();
            BeginContext(46, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 4 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Books\List.cshtml"
  
    foreach (var book in Model.allBooks)
    {

#line default
#line hidden
            BeginContext(106, 38, true);
            WriteLiteral("        <div>\r\n            <h2>Назва: ");
            EndContext();
            BeginContext(145, 9, false);
#line 8 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Books\List.cshtml"
                  Write(book.name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 28, true);
            WriteLiteral("</h2>\r\n            <p>Ціна: ");
            EndContext();
            BeginContext(183, 24, false);
#line 9 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Books\List.cshtml"
                Write(book.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(207, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 11 "C:\Users\Asus\Documents\GitHub\booksshop\Shop\Shop\Views\Books\List.cshtml"
    }

#line default
#line hidden
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
