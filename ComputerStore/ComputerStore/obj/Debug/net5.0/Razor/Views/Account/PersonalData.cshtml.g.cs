#pragma checksum "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Account\PersonalData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c070595dd93f3c17e5895e8d9f827268a6445887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_PersonalData), @"mvc.1.0.view", @"/Views/Account/PersonalData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c070595dd93f3c17e5895e8d9f827268a6445887", @"/Views/Account/PersonalData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e7854bc2f9c50d63e1afcd180501b030ca7077", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_PersonalData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain_ComputerStore.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"personalData\">\r\n    <h1>Personal data</h1>\r\n\r\n    <p class=\"p-name-first\">Surname</p>\r\n    <p class=\"p-value\">");
#nullable restore
#line 7 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Account\PersonalData.cshtml"
                  Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
            WriteLiteral("\r\n\r\n    <p class=\"p-name\">Name</p>\r\n    <p class=\"p-value\">");
#nullable restore
#line 10 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Account\PersonalData.cshtml"
                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
            WriteLiteral("\r\n\r\n    <p class=\"p-name\">Patronymic</p>\r\n    <p class=\"p-value\">");
#nullable restore
#line 13 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Account\PersonalData.cshtml"
                  Write(Model.Patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
            WriteLiteral("\r\n\r\n    <p class=\"p-name\">Phone</p>\r\n    <p class=\"p-value\">+");
#nullable restore
#line 16 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Account\PersonalData.cshtml"
                   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
            WriteLiteral("\r\n\r\n    <p class=\"p-name\">Email</p>\r\n    <p class=\"p-value\">");
#nullable restore
#line 19 "C:\Users\hallc\Documents\GitHub\PC_Store\ComputerStore\ComputerStore\Views\Account\PersonalData.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
            WriteLiteral("\r\n\r\n</div>\r\n<div class=\"accountController\">\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain_ComputerStore.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
