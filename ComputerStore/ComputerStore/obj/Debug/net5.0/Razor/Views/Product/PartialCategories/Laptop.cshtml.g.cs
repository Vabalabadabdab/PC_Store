#pragma checksum "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Product\PartialCategories\Laptop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d49f104dc2beb0b4312f6e591814bcb9d2877f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_PartialCategories_Laptop), @"mvc.1.0.view", @"/Views/Product/PartialCategories/Laptop.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d49f104dc2beb0b4312f6e591814bcb9d2877f", @"/Views/Product/PartialCategories/Laptop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_PartialCategories_Laptop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d49f104dc2beb0b4312f6e591814bcb9d2877f4010", async() => {
                WriteLiteral(@"
        <input type=""hidden"" name=""category"" value=""Laptop"" />

        <div id=""slider""></div>
        <div id=""slider_values_container"">
            <input id=""min-bar-val"" class=""bar-val"" type=""number"" name=""minPrice"" />
            <p>-</p>
            <input id=""max-bar-val"" class=""bar-val"" type=""number"" name=""maxPrice"" />
        </div>

        <button type=""button"" class=""accordion"">Manufacturer</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Acer
                <input type=""checkbox"" name=""values"" value=""Manufacturer Acer"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Asus
                <input type=""checkbox"" name=""values"" value=""Manufacturer Asus"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Dell
                <input type=""checkbox"" name=""values"" value=");
                WriteLiteral(@"""Manufacturer Dell"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Dream Machines
                <input type=""checkbox"" name=""values"" value=""Manufacturer DreamMachines"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Gigabyte
                <input type=""checkbox"" name=""values"" value=""Manufacturer Gigabyte"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                HP
                <input type=""checkbox"" name=""values"" value=""Manufacturer HP"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Lenovo
                <input type=""checkbox"" name=""values"" value=""Manufacturer Lenovo"">
                <span class=""checkmark""></span>
            </label>
            <label class");
                WriteLiteral(@"=""container-filter"">
                MSI
                <input type=""checkbox"" name=""values"" value=""Manufacturer MSI"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Processor ruler</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Intel Core i9
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Corei9"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Intel Core i7
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Corei7"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Intel Core i5
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Corei5"">
                <span class=""checkmark""></span>
            </label>
          ");
                WriteLiteral(@"  <label class=""container-filter"">
                Intel Core i3
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Corei3"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                AMD Ryzen 9
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Ryzen9"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                AMD Ryzen 7
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Ryzen7"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                AMD Ryzen 5
                <input type=""checkbox"" name=""values"" value=""ProcessorRuler Ryzen5"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                AMD Ryzen 3
                <input type=""chec");
                WriteLiteral(@"kbox"" name=""values"" value=""ProcessorRuler Ryzen3"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Count core</button>
        <div class=""panel"">
            <label class=""container-filter"">
                8 Core
                <input type=""checkbox"" name=""values"" value=""CountCore 8"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                6 Core
                <input type=""checkbox"" name=""values"" value=""CountCore 6"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                4 Core
                <input type=""checkbox"" name=""values"" value=""CountCore 4"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2 Core
                <input type=""checkbox"" name=""values"" value=""CountCo");
                WriteLiteral(@"re 2"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Graphics card type</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Discrete
                <input type=""checkbox"" name=""values"" value=""GraphicsType Discrete"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Integrated
                <input type=""checkbox"" name=""values"" value=""GraphicsType Integrated"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Video memory size</button>
        <div class=""panel"">
            <label class=""container-filter"">
                16 Gb
                <input type=""checkbox"" name=""values"" value=""VideoMemorySize 16"">
                <span class=""checkmark""></span>
            </label>
            <lab");
                WriteLiteral(@"el class=""container-filter"">
                8 Gb
                <input type=""checkbox"" name=""values"" value=""VideoMemorySize 8"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                6 Gb
                <input type=""checkbox"" name=""values"" value=""VideoMemorySize 6"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                4 Gb
                <input type=""checkbox"" name=""values"" value=""VideoMemorySize 4"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2 Gb
                <input type=""checkbox"" name=""values"" value=""VideoMemorySize 2"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Display resolution</button>
        <div class=""panel"">
            <label class=""container-");
                WriteLiteral(@"filter"">
                Ultra HD 4K (3840x2160)
                <input type=""checkbox"" name=""values"" value=""Resolution UltraHD"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Quad HD 2K (2560x1440)
                <input type=""checkbox"" name=""values"" value=""Resolution QuadHD"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2560x1600
                <input type=""checkbox"" name=""values"" value=""Resolution 2560x1600"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Full HD (1920x1080)
                <input type=""checkbox"" name=""values"" value=""Resolution FullHD"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">RAM size</button>
        <div class=""panel"">
     ");
                WriteLiteral(@"       <label class=""container-filter"">
                64 Gb
                <input type=""checkbox"" name=""values"" value=""RAM 64"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                32 Gb
                <input type=""checkbox"" name=""values"" value=""RAM 32"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                16 Gb
                <input type=""checkbox"" name=""values"" value=""RAM 16"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                8 Gb
                <input type=""checkbox"" name=""values"" value=""RAM 8"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Internal storage</button>
        <div class=""panel"">
            <label class=""container-filter"">
                SSD
  ");
                WriteLiteral(@"              <input type=""checkbox"" name=""values"" value=""InternalStorage SSD"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                HDD + SSD
                <input type=""checkbox"" name=""values"" value=""InternalStorage HDD+SDD"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""submit"" class=""accordion-btn"">Apply</button>
    ");
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