#pragma checksum "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Alert\SuccessAlert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1fe30884846cfb15f59c2f72c66577aabd3249f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alert_SuccessAlert), @"mvc.1.0.view", @"/Views/Alert/SuccessAlert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1fe30884846cfb15f59c2f72c66577aabd3249f", @"/Views/Alert/SuccessAlert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Alert_SuccessAlert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script src=\"//cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n<script src=\"sweetalert2.all.min.js\"></script>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Alert\SuccessAlert.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        Swal.fire({\r\n            title: \'Success\',\r\n            icon: \'success\',\r\n            html:\r\n            \'");
#nullable restore
#line 13 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Alert\SuccessAlert.cshtml"
        Write(Model.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 16 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Alert\SuccessAlert.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
