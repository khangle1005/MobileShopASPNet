#pragma checksum "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325d831c0fc734a6abc17664cf10a278ba2bf92f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brand_BrandIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Brand/BrandIndex.cshtml")]
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
#line 1 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\_ViewImports.cshtml"
using Weeeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\_ViewImports.cshtml"
using Weeeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325d831c0fc734a6abc17664cf10a278ba2bf92f", @"/Areas/Admin/Views/Brand/BrandIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91a5482b7722685eda7e0472e455c60b01d2d6b", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brand_BrandIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Brands>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_Layouta.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""col-md-14"">
            <div class=""card "">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title"">Manage User</h4>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
");
#nullable restore
#line 14 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                         if (ViewBag.SuccessMsg != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                                ");
#nullable restore
#line 17 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                           Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 19 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"table-responsive ps\">\r\n                        <table class=\"table tablesorter table-hover\"");
            BeginWriteAttribute("id", " id=\"", 889, "\"", 894, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>Brands id</th>
                                    <th>Brands name</th>
                                    <th><a href=""/Admin/Brand/CreateBrand"" class=""btn btn-success"">Add New</a></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 31 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                                 foreach (var a in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 34 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                                       Write(a.brand_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 35 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                                       Write(a.brand_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1695, "\"", 1726, 2);
            WriteAttributeValue("", 1702, "EditBrand?Id=", 1702, 13, true);
#nullable restore
#line 37 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
WriteAttributeValue("", 1715, a.brand_id, 1715, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'button\' rel=\'tooltip\'");
            BeginWriteAttribute("title", " title=\'", 1755, "\'", 1763, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" data-original-title=\'Edit User\'>\r\n                                                <div class=\'ripple-container\'>Edit  </div>\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2011, "\"", 2044, 2);
            WriteAttributeValue("", 2018, "DeleteBrand?Id=", 2018, 15, true);
#nullable restore
#line 40 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
WriteAttributeValue("", 2033, a.brand_id, 2033, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'button\' rel=\'tooltip\'");
            BeginWriteAttribute("title", " title=\'", 2073, "\'", 2081, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"" data-original-title='Delete User'>
                                                <div class='ripple-container'>Delete</div>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 45 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Areas\Admin\Views\Brand\BrandIndex.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                        <div class=""ps__rail-x"" style=""left: 0px; bottom: 0px;""><div class=""ps__thumb-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div></div><div class=""ps__rail-y"" style=""top: 0px; right: 0px;""><div class=""ps__thumb-y"" tabindex=""0"" style=""top: 0px; height: 0px;""></div></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Brands>> Html { get; private set; }
    }
}
#pragma warning restore 1591
