#pragma checksum "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2644567ac42657c1a92e031ef60492948d75a0d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2644567ac42657c1a92e031ef60492948d75a0d3", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7327607597b52ae4e95cf7058766c536c8b7e581", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User_Info>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2644567ac42657c1a92e031ef60492948d75a0d37102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $("".updateCart"").click(function (event) {
            event.preventDefault();
            var quantity = $("".quantity_"" + $(this).attr(""data-id"")).val();
            console.log(quantity);
            $.ajax({
                type: ""POST"",
                url:""");
#nullable restore
#line 25 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                Write(Url.Action("updateCart","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                data: {\r\n                    id: $(this).attr(\"data-id\"),\r\n                    quantity:quantity\r\n                },\r\n                success: function (result) {\r\n                    window.location.href = \'");
#nullable restore
#line 31 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                       Write(Url.Action("Cart","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                }
            });
        });
    });
</script>

<section class=""section"">
    <div class=""container-fluid"">
        <div id=""cart_checkout"">
            <div class=""main "">
                <div class=""table-responsive"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2644567ac42657c1a92e031ef60492948d75a0d39461", async() => {
                WriteLiteral(@"

                        <div id=""issessionset""></div><table id=""cart"" class=""table table-hover table-condensed"">
                            <thead>
                                <tr>
                                    <th style=""width:50%"">Sản phẩm</th>
                                    <th style=""width:10%"">Giá</th>
                                    <th style=""width:8%"">Số lượng</th>
                                    <th style=""width:7%"" class=""text-center"">Tổng</th>
                                    <th style=""width:10%""></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 56 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                 foreach (var item in ViewBag.carts)
                                {
                                    string txt_class = "quantity_" + item.Product.product_id;
                                    int total = item.Product.product_price * item.Quantity;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <tr>
                                        <td data-th=""Product"">
                                            <div class=""row"">
                                                <div class=""col-sm-4 "">
                                                    <img");
                BeginWriteAttribute("src", " src=\"", 2559, "\"", 2608, 2);
                WriteAttributeValue("", 2565, "/product_images/", 2565, 16, true);
#nullable restore
#line 64 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 2581, item.Product.product_image, 2581, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 70px;width:75px;\">\r\n                                                    <h4 class=\"nomargin product-name header-cart-item-name\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2644567ac42657c1a92e031ef60492948d75a0d311771", async() => {
#nullable restore
#line 65 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                                                                                                                                                                                   Write(item.Product.product_title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                                                                                                                                                  WriteLiteral(item.Product.product_id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</h4>
                                                </div>
                                                <div class=""col-sm-6"">
                                                    <div style=""max-width: 50px;"">
                                                        <p>");
#nullable restore
#line 69 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                                      Write(item.Product.product_desc);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                        <input type=""hidden"" name=""product_id[]"" value=""71"">
                                        <input type=""hidden""");
                BeginWriteAttribute("name", " name=\"", 3555, "\"", 3562, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"150\">\r\n                                        <td data-th=\"Price\"><input type=\"text\" class=\"form-control price\"");
                BeginWriteAttribute("value", " value=\"", 3683, "\"", 3718, 1);
#nullable restore
#line 76 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3691, item.Product.product_price, 3691, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\"></td>\r\n                                        <td data-th=\"Quantity\">\r\n                                            <input type=\"text\"");
                BeginWriteAttribute("class", " class=\"", 3874, "\"", 3905, 2);
                WriteAttributeValue("", 3882, "form-control", 3882, 12, true);
#nullable restore
#line 78 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue(" ", 3894, txt_class, 3895, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3906, "\"", 3928, 1);
#nullable restore
#line 78 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 3914, item.Quantity, 3914, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        </td>\r\n                                        <td data-th=\"Subtotal\" class=\"text-center\"><input type=\"text\" class=\"form-control total\"");
                BeginWriteAttribute("value", " value=\"", 4109, "\"", 4144, 1);
#nullable restore
#line 80 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 4117, item.Product.product_price, 4117, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\"></td>\r\n                                        <td class=\"actions\" data-th=\"\">\r\n                                            <div class=\"btn-group\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 4365, "\"", 4372, 0);
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 83 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                                               Write(item.Product.product_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"updateCart\"><i class=\"fa fa-refresh\"></i></a>\r\n\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2644567ac42657c1a92e031ef60492948d75a0d318484", async() => {
                    WriteLiteral("<i class=\"fa fa-trash-o\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                                                                                   WriteLiteral(item.Product.product_id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 89 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                            <tfoot>\r\n                                <tr>\r\n");
#nullable restore
#line 93 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                      
                                        var total1 = 0;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                     foreach (var item in ViewBag.carts)
                                    {
                                        total1 = total1 + (item.Product.product_price * item.Quantity);
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2644567ac42657c1a92e031ef60492948d75a0d322228", async() => {
                    WriteLiteral("<i class=\"fa fa-angle-left\"></i> Tiếp tục mua hàng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                    <td colspan=\"2\" class=\"hidden-xs\"></td>\r\n                                    <td class=\"hidden-xs text-center\"><b class=\"net_total\">Tổng tiền :  ");
#nullable restore
#line 102 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                                                                                   Write(total1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</b></td>\r\n\r\n");
                WriteLiteral("                                </tr>\r\n                            </tfoot>\r\n                        </table>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div style=\"width: 30%; margin: auto\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2644567ac42657c1a92e031ef60492948d75a0d325773", async() => {
                WriteLiteral("\r\n\r\n\r\n            Mã người dùng: <input class=\"form-control\" type=\"text\" name=\"user_id\"");
                BeginWriteAttribute("value", " value=\"", 6346, "\"", 6368, 1);
#nullable restore
#line 119 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6354, Model.user_id, 6354, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required readonly><br>\r\n            Người nhận: <input class=\"form-control\" type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 6469, "\"", 6493, 1);
#nullable restore
#line 120 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6477, Model.last_name, 6477, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required><br>\r\n            Email: <input class=\"form-control\" type=\"text\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 6581, "\"", 6601, 1);
#nullable restore
#line 121 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6589, Model.email, 6589, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required><br>\r\n            Số điện thoại: <input class=\"form-control\" type=\"text\" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 6697, "\"", 6718, 1);
#nullable restore
#line 122 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6705, Model.mobile, 6705, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required><br>\r\n            Địa chỉ: <input class=\"form-control\" type=\"text\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 6810, "\"", 6833, 1);
#nullable restore
#line 123 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
WriteAttributeValue("", 6818, Model.address1, 6818, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required><br>\r\n            Ghi chú: <textarea class=\"form-control\" name=\"note\"");
                BeginWriteAttribute("value", " value=\"", 6913, "\"", 6921, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n\r\n            <input class=\"form-control\" type=\"hidden\" name=\"order_id\"");
                BeginWriteAttribute("value", " value=\"", 7007, "\"", 7015, 0);
                EndWriteAttribute();
                WriteLiteral(" readonly><br>\r\n            <input class=\"form-control\" type=\"hidden\" name=\"order_date\"");
                BeginWriteAttribute("value", " value=\"", 7103, "\"", 7111, 0);
                EndWriteAttribute();
                WriteLiteral(@" required readonly><br>
            <input class=""form-control"" type=""hidden"" name=""quantity"" value=""0"" required readonly><br>
            <input class=""form-control"" type=""hidden"" name=""total"" value=""0"" readonly><br>
            <input class=""form-control"" type=""hidden"" name=""paid_status"" value=""0"" required readonly><br>
            <input class=""form-control"" type=""hidden"" name=""status"" value=""0"" required readonly><br>

");
#nullable restore
#line 133 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
              
                var total2 = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
             foreach (var item in ViewBag.carts)
            {
                total2 = total2 + (item.Product.product_price * item.Quantity);
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input style=\"float:right\" type=\"submit\" name=\"submit\" class=\"btn btn-success\" value=\"Xác nhận\" />\r\n\r\n            <b class=\"net_total\">Thành tiền: ");
#nullable restore
#line 142 "D:\C#\ASP.NET CORE\Weeeb\Weeeb\Views\Home\Cart.cshtml"
                                        Write(total2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</b>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    \r\n</section>\t");
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