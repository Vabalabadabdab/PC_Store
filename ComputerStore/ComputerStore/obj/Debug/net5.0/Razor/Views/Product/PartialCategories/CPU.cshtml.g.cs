#pragma checksum "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Product\PartialCategories\CPU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd06ed638abd2b8eb20f13f812234ac10f14c53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_PartialCategories_CPU), @"mvc.1.0.view", @"/Views/Product/PartialCategories/CPU.cshtml")]
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
#line 1 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\_ViewImports.cshtml"
using ComputerStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\_ViewImports.cshtml"
using ComputerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd06ed638abd2b8eb20f13f812234ac10f14c53", @"/Views/Product/PartialCategories/CPU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_PartialCategories_CPU : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetSelectProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"filter-card\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cd06ed638abd2b8eb20f13f812234ac10f14c533995", async() => {
                WriteLiteral(@"
        <input type=""hidden"" name=""category"" value=""CPU"" />

        <div id=""slider""></div>
        <div id=""slider_values_container"">
            <input id=""min-bar-val"" class=""bar-val"" type=""number"" name=""minPrice"" />
            <p>-</p>
            <input id=""max-bar-val"" class=""bar-val"" type=""number"" name=""maxPrice"" />
        </div>

        <button type=""button"" class=""accordion"">Manufacturer</button>
        <div class=""panel"">
            <label class=""container-filter"">
                AMD
                <input type=""checkbox"" name=""values"" value=""Manufacturer AMD"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Intel
                <input type=""checkbox"" name=""values"" value=""Manufacturer Intel"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Number of cores</button>
        <div class=""panel"">
         ");
                WriteLiteral(@"   <label class=""container-filter"">
                64
                <input type=""checkbox"" name=""values"" value=""Core 64"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                32
                <input type=""checkbox"" name=""values"" value=""Core 32"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                24
                <input type=""checkbox"" name=""values"" value=""Core 24"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                16
                <input type=""checkbox"" name=""values"" value=""Core 16"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                12
                <input type=""checkbox"" name=""values"" value=""Core 12"">
                <span class=""checkmark""></span>
            </l");
                WriteLiteral(@"abel>
            <label class=""container-filter"">
                10
                <input type=""checkbox"" name=""values"" value=""Core 10"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                8
                <input type=""checkbox"" name=""values"" value=""Core 8"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                6
                <input type=""checkbox"" name=""values"" value=""Core 6"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                4
                <input type=""checkbox"" name=""values"" value=""Core 4"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2
                <input type=""checkbox"" name=""values"" value=""Core 2"">
                <span class=""checkmark""></span>
       ");
                WriteLiteral(@"     </label>
        </div>

        <button type=""button"" class=""accordion"">Number of threads</button>
        <div class=""panel"">
            <label class=""container-filter"">
                128
                <input type=""checkbox"" name=""values"" value=""Thread 128"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                64
                <input type=""checkbox"" name=""values"" value=""Thread 64"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                48
                <input type=""checkbox"" name=""values"" value=""Thread 48"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                32
                <input type=""checkbox"" name=""values"" value=""Thread 32"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">");
                WriteLiteral(@"
                24
                <input type=""checkbox"" name=""values"" value=""Thread 24"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                20
                <input type=""checkbox"" name=""values"" value=""Thread 20"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                16
                <input type=""checkbox"" name=""values"" value=""Thread 16"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                12
                <input type=""checkbox"" name=""values"" value=""Thread 12"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                8
                <input type=""checkbox"" name=""values"" value=""Thread 8"">
                <span class=""checkmark""></span>
            </label>
            <label c");
                WriteLiteral(@"lass=""container-filter"">
                6
                <input type=""checkbox"" name=""values"" value=""Thread 6"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                4
                <input type=""checkbox"" name=""values"" value=""Thread 4"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2
                <input type=""checkbox"" name=""values"" value=""Thread 2"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Integrated graphics</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Yes
                <input type=""checkbox"" name=""values"" value=""IntegratedGraphics Yes"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                No
     ");
                WriteLiteral("           <input type=\"checkbox\" name=\"values\" value=\"IntegratedGraphics No\">\r\n                <span class=\"checkmark\"></span>\r\n            </label>\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"accordion-btn\">Apply</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
