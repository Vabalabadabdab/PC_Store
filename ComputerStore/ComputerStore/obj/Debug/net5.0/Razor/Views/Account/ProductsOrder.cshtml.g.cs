#pragma checksum "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b6fe316307e815fb2856a6463ce6617694f3734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ProductsOrder), @"mvc.1.0.view", @"/Views/Account/ProductsOrder.cshtml")]
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
#line 1 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\_ViewImports.cshtml"
using ComputerStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\_ViewImports.cshtml"
using ComputerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6fe316307e815fb2856a6463ce6617694f3734", @"/Views/Account/ProductsOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ProductsOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BLL_ComputerStore.Infrastucture.Models.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
 if (Model.Count != 0 && Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"orderProducts_container\">\r\n    <h1>Order details {");
#nullable restore
#line 6 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
                  Write(TempData["OrderId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("}</h1>\r\n");
#nullable restore
#line 7 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"prodcut_item\">\r\n        <h3>Product: ");
#nullable restore
#line 10 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
                Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3>Cost: ");
#nullable restore
#line 11 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
             Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UAH</h3>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 15 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Account\ProductsOrder.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BLL_ComputerStore.Infrastucture.Models.ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591