#pragma checksum "C:\Users\bruno\source\repos\SessionTraining\SessionTraining\Views\Users\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87fca2bcce5d78d4dd8ca23a3b70226424bfe314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Hello), @"mvc.1.0.view", @"/Views/Users/Hello.cshtml")]
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
#line 1 "C:\Users\bruno\source\repos\SessionTraining\SessionTraining\Views\_ViewImports.cshtml"
using SessionTraining;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruno\source\repos\SessionTraining\SessionTraining\Views\_ViewImports.cshtml"
using SessionTraining.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fca2bcce5d78d4dd8ca23a3b70226424bfe314", @"/Views/Users/Hello.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eaf4f88eb59d4de6ce3ff13b669c36aebd5e30c", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Hello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SessionTraining.Models.Entities.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bruno\source\repos\SessionTraining\SessionTraining\Views\Users\Hello.cshtml"
  
    ViewData["Title"] = "Hello";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p> Hello ");
#nullable restore
#line 7 "C:\Users\bruno\source\repos\SessionTraining\SessionTraining\Views\Users\Hello.cshtml"
     Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SessionTraining.Models.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
