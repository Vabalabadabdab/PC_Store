#pragma checksum "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Product\PartialCategories\GPU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60c2291eddb8ed765fd4a2c50328720f180bf9ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_PartialCategories_GPU), @"mvc.1.0.view", @"/Views/Product/PartialCategories/GPU.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c2291eddb8ed765fd4a2c50328720f180bf9ec", @"/Views/Product/PartialCategories/GPU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_PartialCategories_GPU : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c2291eddb8ed765fd4a2c50328720f180bf9ec3995", async() => {
                WriteLiteral(@"
        <input type=""hidden"" name=""category"" value=""GPU"" />

        <div id=""slider""></div>
        <div id=""slider_values_container"">
            <input id=""min-bar-val"" class=""bar-val"" type=""number"" name=""minPrice"" />
            <p>-</p>
            <input id=""max-bar-val"" class=""bar-val"" type=""number"" name=""maxPrice"" />
        </div>

        <button type=""button"" class=""accordion"">Manufacturer</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Amd
                <input type=""checkbox"" name=""values"" value=""Manufacturer Amd"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Nvidia
                <input type=""checkbox"" name=""values"" value=""Manufacturer Nvidia"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Memory</button>
        <div class=""panel"">
            <lab");
                WriteLiteral(@"el class=""container-filter"">
                24 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 24"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                16 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 16"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                12 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 12"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                11 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 11"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                10 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 10"">
                <span class=""checkmark""></span");
                WriteLiteral(@">
            </label>
            <label class=""container-filter"">
                8 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 8"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                6 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 6"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                4 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 4"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                3 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 3"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 2"">
               ");
                WriteLiteral(@" <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                1 Gb
                <input type=""checkbox"" name=""values"" value=""Memory 1"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Bitness</button>
        <div class=""panel"">
            <label class=""container-filter"">
                4096 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 4096"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                512 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 512"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                384 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 384"">
                <span class=""checkmark""></span>
            <");
                WriteLiteral(@"/label>
            <label class=""container-filter"">
                352 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 352"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                320 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 320"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                256 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 256"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                192 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 192"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                128 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 128"">
 ");
                WriteLiteral(@"               <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                64 bit
                <input type=""checkbox"" name=""values"" value=""Bitness 64"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Memory type</button>
        <div class=""panel"">
            <label class=""container-filter"">
                GDDR6X
                <input type=""checkbox"" name=""values"" value=""MemoryType GDDR6X"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                GDDR6
                <input type=""checkbox"" name=""values"" value=""MemoryType GDDR6"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                GDDR5X
                <input type=""checkbox"" name=""values"" value=""MemoryType GDDR5X"">
                <span class=""");
                WriteLiteral(@"checkmark""></span>
            </label>
            <label class=""container-filter"">
                GDDR5
                <input type=""checkbox"" name=""values"" value=""MemoryType GDDR5"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                GDDR4
                <input type=""checkbox"" name=""values"" value=""MemoryType GDDR4"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                GDDR3
                <input type=""checkbox"" name=""values"" value=""MemoryType GDDR3"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                HBM
                <input type=""checkbox"" name=""values"" value=""MemoryType HBM"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                HBM2
                <input type=""checkbox""");
                WriteLiteral(@" name=""values"" value=""MemoryType HBM2"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Backlight</button>
        <div class=""panel"">
            <label class=""container-filter"">
                RGB-backlight
                <input type=""checkbox"" name=""values"" value=""Backlight RGB"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                ARGB-backlight
                <input type=""checkbox"" name=""values"" value=""Backlight ARGB"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                No backlight
                <input type=""checkbox"" name=""values"" value=""Backlight No"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Count fans</button>
        <div class=""panel"">
      ");
                WriteLiteral(@"      <label class=""container-filter"">
                3 fans
                <input type=""checkbox"" name=""values"" value=""Fan 3"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                2 fans
                <input type=""checkbox"" name=""values"" value=""Fan 2"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                1 fans
                <input type=""checkbox"" name=""values"" value=""Fan 1"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                No fans
                <input type=""checkbox"" name=""values"" value=""Fan No"">
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
