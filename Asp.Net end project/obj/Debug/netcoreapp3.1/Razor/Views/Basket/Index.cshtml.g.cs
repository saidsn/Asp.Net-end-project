#pragma checksum "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a42b6c5d3fe895353fc367ee797fd6c73226670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a42b6c5d3fe895353fc367ee797fd6c73226670", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823193780093bea598968f59b37eb9388f9c3102", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketDetailVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" d-block d-md-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";

    decimal endTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- main wrapper start -->\r\n<main>\r\n");
            WriteLiteral(@"    <div class=""breadcrumb-area bg-img"" data-bg=""~/assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Cart</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Cart</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("    <div class=\"cart-main-wrapper section-padding\">\r\n        <div class=\"container\">\r\n            <div class=\"section-bg-color\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12\">\r\n");
            WriteLiteral(@"                        <div class=""cart-table table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th class=""pro-thumbnail"">Image</th>
                                        <th class=""pro-title"">Title</th>
                                        <th class=""pro-price"">Count</th>
                                        <th class=""pro-quantity"">Price</th>
                                        <th class=""pro-quantity"">DisCounPrice</th>
                                        <th class=""pro-subtotal"">Total price</th>
                                        <th class=""pro-remove"">Remove</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 52 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"pro-thumbnail\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a42b6c5d3fe895353fc367ee797fd6c732266709075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2457, "~/assets/img/product/", 2457, 21, true);
#nullable restore
#line 56 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 2478, item.Image, 2478, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"pro-title\"><a href=\"#\">");
#nullable restore
#line 58 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-quantity\">\r\n                                                <div class=\"pro-qty\"><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2824, "\"", 2843, 1);
#nullable restore
#line 60 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
WriteAttributeValue("", 2832, item.Count, 2832, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                            </td>\r\n\r\n\r\n\r\n                                            <td class=\"pro-subtotal\"><span>$");
#nullable restore
#line 65 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                                                       Write(item.Price.ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td class=\"pro-subtotal\"><span>$");
#nullable restore
#line 66 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                                                        Write((item.Price-((item.Price*item.DiscountPrice)/100)).ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n                                            <td class=\"pro-subtotal\"><span>$");
#nullable restore
#line 68 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                                                       Write(item.Total.ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a42b6c5d3fe895353fc367ee797fd6c7322667013205", async() => {
                WriteLiteral("\r\n                                            <td class=\"pro-remove\"><button type=\"submit\"><i class=\"fa fa-trash-o\"></i></button></td>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                        endTotal = endTotal + item.Total;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"cart-update-option d-block d-md-flex justify-content-between\">\r\n                            <div class=\"apply-coupon-wrapper\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a42b6c5d3fe895353fc367ee797fd6c7322667016844", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Enter Your Coupon Code\" required />\r\n                                    <button class=\"btn\">Apply Coupon</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""cart-update"">
                                <a href=""#"" class=""btn"">Update Cart</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-5 ml-auto"">
");
            WriteLiteral(@"                        <div class=""cart-calculator-wrapper"">
                            <div class=""cart-calculate-items"">
                                <h3>Cart Totals</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <tr class=""total"">
                                            <td>Total</td>
                                            <td class=""total-amount"">$");
#nullable restore
#line 106 "C:\Users\OMEN\OneDrive\İş masası\Asp.Net end project\Asp.Net end project\Asp.Net end project\Views\Basket\Index.cshtml"
                                                                 Write(endTotal.ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>

                                    </table>
                                </div>
                            </div>
                            <a href=""checkout.html"" class=""btn d-block"">Proceed Checkout</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- cart main wrapper end -->
</main>
<!-- main wrapper end -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
