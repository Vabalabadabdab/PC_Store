#pragma checksum "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0789c79cf8e3f8f803186cd2867278408cb03e11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductCards), @"mvc.1.0.view", @"/Views/Product/ProductCards.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0789c79cf8e3f8f803186cd2867278408cb03e11", @"/Views/Product/ProductCards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductCards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BLL_ComputerStore.Infrastucture.Models.ProductDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shopping-basket.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
 foreach (var product in @Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-card\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0789c79cf8e3f8f803186cd2867278408cb03e114465", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 214, "\"", 233, 1);
#nullable restore
#line 7 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
WriteAttributeValue("", 222, product.Id, 222, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <button>\r\n");
#nullable restore
#line 9 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
                 if (product.Rate != 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"product-card rate-container\">\r\n                        <p>Rate: ");
#nullable restore
#line 12 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
                            Write(Math.Round(product.Rate, 1));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 14 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 520, "\"", 547, 1);
#nullable restore
#line 16 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
WriteAttributeValue("", 526, product.ProductImage, 526, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                <div class=\"product-card-content\">\r\n                    <h2>");
#nullable restore
#line 19 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 20 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
                  Write(product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div");
            BeginWriteAttribute("id", " id=\"", 774, "\"", 794, 2);
#nullable restore
#line 24 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
WriteAttributeValue("", 779, product.Id, 779, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 790, "-div", 790, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 795, "\"", 852, 6);
            WriteAttributeValue("", 805, "AddToBasket(", 805, 12, true);
#nullable restore
#line 24 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
WriteAttributeValue("", 817, product.Id, 817, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 828, ",", 828, 1, true);
            WriteAttributeValue(" ", 829, "\'", 830, 2, true);
#nullable restore
#line 24 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
WriteAttributeValue("", 831, User.Identity.Name, 831, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 850, "\')", 850, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"product-card-footer\">\r\n            <p>");
#nullable restore
#line 25 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
          Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("₴</p>\r\n            <a href=\"#\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0789c79cf8e3f8f803186cd2867278408cb03e1110077", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
AddHtmlAttributeValue("", 970, product.Id, 970, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 981, "-img", 981, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
        function AddToBasket(productId, userName) {
            $.ajax({
                type: ""POST"",
                url: ""/Account/AddToBasket"",
                data: { productId: productId, userName: userName },
                success: function (data) {
                    /*$('#reviews').html(data);*/
                }
            });

            CheckProduct(productId);
        }

        function CheckProduct(id) {
            $('#' + id + '-img').attr(""src"", ""/images/check.png"");
            $('#' + id + '-div').css(""background-color"", ""#F07427"");
        }
    </script>
");
#nullable restore
#line 55 "C:\Users\hallc\Desktop\ComputerStore\ComputerStore\ComputerStore\Views\Product\ProductCards.cshtml"
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
