#pragma checksum "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6469576f754f81bc7574a256e15cbeba7a3725a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCheckout), @"mvc.1.0.view", @"/Views/Home/ViewCheckout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6469576f754f81bc7574a256e15cbeba7a3725a9", @"/Views/Home/ViewCheckout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7327607597b52ae4e95cf7058766c536c8b7e581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCheckout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User_Info>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml"
  
    ViewData["Title"] = "Checkout";
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
            WriteLiteral("\r\n<div style=\"width: 30%; margin: auto\">\r\n    Id: <input class=\"form-control\" type=\"text\" name=\"user_id\"");
            BeginWriteAttribute("value", " value=\"", 444, "\"", 466, 1);
#nullable restore
#line 18 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml"
WriteAttributeValue("", 452, Model.user_id, 452, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required readonly><br>\r\n    Người nhận: <input class=\"form-control\" type=\"text\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 559, "\"", 583, 1);
#nullable restore
#line 19 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml"
WriteAttributeValue("", 567, Model.last_name, 567, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required><br>\r\n    Email: <input class=\"form-control\" type=\"text\" name=\"email\"");
            BeginWriteAttribute("value", " value=\"", 663, "\"", 683, 1);
#nullable restore
#line 20 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml"
WriteAttributeValue("", 671, Model.email, 671, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required><br>\r\n    Số điện thoại: <input class=\"form-control\" type=\"text\" name=\"phone\"");
            BeginWriteAttribute("value", " value=\"", 771, "\"", 792, 1);
#nullable restore
#line 21 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml"
WriteAttributeValue("", 779, Model.mobile, 779, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required><br>\r\n    Địa chỉ: <input class=\"form-control\" type=\"text\" name=\"address\"");
            BeginWriteAttribute("value", " value=\"", 876, "\"", 899, 1);
#nullable restore
#line 22 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\ViewCheckout.cshtml"
WriteAttributeValue("", 884, Model.address1, 884, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required><br>\r\n    Ghi chú: <textarea class=\"form-control\" name=\"note\"");
            BeginWriteAttribute("value", " value=\"", 971, "\"", 979, 0);
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
</div>


<b class=""net_total"">Thành tiền :  đ</b>
<div style=""margin: auto"">
    <input style=""margin-right: 16px"" type=""submit"" name=""submit"" form=""cart-form"" class=""btn btn-success"" value=""Xác nhận"" />
    <input style=""margin-right: 16px"" type=""submit"" name=""delete-all"" form=""cart-form"" class=""btn btn-danger"" value=""Xóa giỏ hàng"" />
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User_Info> Html { get; private set; }
    }
}
#pragma warning restore 1591
