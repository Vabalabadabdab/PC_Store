#pragma checksum "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Product\PartialCategories\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ae3a978979018585cb1f148d97e5ffe59fdf660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_PartialCategories_Keyboard), @"mvc.1.0.view", @"/Views/Product/PartialCategories/Keyboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ae3a978979018585cb1f148d97e5ffe59fdf660", @"/Views/Product/PartialCategories/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_PartialCategories_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae3a978979018585cb1f148d97e5ffe59fdf6604020", async() => {
                WriteLiteral(@"
        <input type=""hidden"" name=""category"" value=""Keyboard"" />

        <div id=""slider""></div>
        <div id=""slider_values_container"">
            <input id=""min-bar-val"" class=""bar-val"" type=""number"" name=""minPrice"" />
            <p>-</p>
            <input id=""max-bar-val"" class=""bar-val"" type=""number"" name=""maxPrice"" />
        </div>

        <button type=""button"" class=""accordion"">Manufacturer</button>
        <div class=""panel"">
            <label class=""container-filter"">
                A4Tech
                <input type=""checkbox"" name=""values"" value=""Manufacturer A4Tech"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                ASUS
                <input type=""checkbox"" name=""values"" value=""Manufacturer ASUS"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Corsair
                <input type=""checkbox"" name=""value");
                WriteLiteral(@"s"" value=""Manufacturer Corsair"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Cougar
                <input type=""checkbox"" name=""values"" value=""Manufacturer Cougar"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Ducky
                <input type=""checkbox"" name=""values"" value=""Manufacturer Ducky"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Glorious
                <input type=""checkbox"" name=""values"" value=""Manufacturer Glorious"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Hator
                <input type=""checkbox"" name=""values"" value=""Manufacturer Hator"">
                <span class=""checkmark""></span>
            </label>
            <label clas");
                WriteLiteral(@"s=""container-filter"">
                Keychron
                <input type=""checkbox"" name=""values"" value=""Manufacturer Keychron"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                HyperX
                <input type=""checkbox"" name=""values"" value=""Manufacturer HyperX"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Logitech
                <input type=""checkbox"" name=""values"" value=""Manufacturer Logitech"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                MSI
                <input type=""checkbox"" name=""values"" value=""Manufacturer MSI"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Razer
                <input type=""checkbox"" name=""values"" value=""Manufacturer Razer"">");
                WriteLiteral(@"
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                SteelSeries
                <input type=""checkbox"" name=""values"" value=""Manufacturer SteelSeries"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Varmilo
                <input type=""checkbox"" name=""values"" value=""Manufacturer Varmilo"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Type</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Membrane
                <input type=""checkbox"" name=""values"" value=""Type Membrane"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Mechanical
                <input type=""checkbox"" name=""values"" value=""Type Mechanical"">
        ");
                WriteLiteral(@"        <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Scissor
                <input type=""checkbox"" name=""values"" value=""Type Scissor"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Optical
                <input type=""checkbox"" name=""values"" value=""Type Optical"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Optical-mechanical
                <input type=""checkbox"" name=""values"" value=""Type OpticalMechanical"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Membrane + mechanical keys
                <input type=""checkbox"" name=""values"" value=""MembraneMechanical"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""but");
                WriteLiteral(@"ton"" class=""accordion"">Form factor</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Full size
                <input type=""checkbox"" name=""values"" value=""FormFactor Full"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                TKL (Compact)
                <input type=""checkbox"" name=""values"" value=""FormFactor TKL"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Size 60%
                <input type=""checkbox"" name=""values"" value=""FormFactor 60%"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Size 65%
                <input type=""checkbox"" name=""values"" value=""FormFactor 65%"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
             ");
                WriteLiteral(@"   Numpad
                <input type=""checkbox"" name=""values"" value=""FormFactor Numpad"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Connect</button>
        <div class=""panel"">
            <label class=""container-filter"">
                Wireless
                <input type=""checkbox"" name=""values"" value=""Connect Wireless"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Wired
                <input type=""checkbox"" name=""values"" value=""Connect Wired"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Combined
                <input type=""checkbox"" name=""values"" value=""Connect Combined"">
                <span class=""checkmark""></span>
            </label>
        </div>

        <button type=""button"" class=""accordion"">Backlight</button>");
                WriteLiteral(@"
        <div class=""panel"">
            <label class=""container-filter"">
                One color
                <input type=""checkbox"" name=""values"" value=""Backlight One"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                RGB Backlight
                <input type=""checkbox"" name=""values"" value=""Backlight RGB"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                Multiple colors
                <input type=""checkbox"" name=""values"" value=""Backlight Multiple"">
                <span class=""checkmark""></span>
            </label>
            <label class=""container-filter"">
                No backlight
                <input type=""checkbox"" name=""values"" value=""Backlight No"">
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
