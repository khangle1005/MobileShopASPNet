#pragma checksum "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a4005aa7a6394a1b7c861f6f66ba057150d37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_checkout), @"mvc.1.0.view", @"/Views/Home/checkout.cshtml")]
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
#line 1 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Weeeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Weeeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a4005aa7a6394a1b7c861f6f66ba057150d37f", @"/Views/Home/checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7327607597b52ae4e95cf7058766c536c8b7e581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\checkout.cshtml"
  
    ViewData["Title"] = "Home Page";
    if (Context.Session.GetString("username") != null)
    {
        ViewData["acc"] = "Hi " + Context.Session.GetString("username");
        ViewData["user_id"] = Context.Session.GetString("uid");
    }
    else
    {
        ViewData["acc"] = "My Account";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>\r\n    ");
#nullable restore
#line 15 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\checkout.cshtml"
Write(ViewData["thongbao"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n\r\n");
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
