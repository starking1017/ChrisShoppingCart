#pragma checksum "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665fabe3c0616274d217b47696d4acfce54d0cca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#line 2 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#line 1 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
using ShoppingCart.Models.Cart;

#line default
#line hidden
#line 2 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
using ShoppingCart.Models.Product;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665fabe3c0616274d217b47696d4acfce54d0cca", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.Cart.Ship>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/order.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
  
    ViewBag.Title = "CheckOut";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var cart = Operation.GetCurrentCart();

#line default
#line hidden
            BeginContext(246, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(250, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "236cfa1629224605ab8525ead6368a38", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(310, 260, true);
            WriteLiteral(@"

<h2>Review your order</h2>

<table class=""table table-hover"" style=""vertical-align:bottom"" id=""cartTable"">
    <thead><tr><td></td><td>Picture</td><td>Name</td><td>Price</td><td>Quantity</td><td class=""text-right"">Amount</td></tr></thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
         foreach (CartItem pd in cart)
        {

#line default
#line hidden
            BeginContext(621, 66, true);
            WriteLiteral("            <tr>\r\n                <td><span class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 687, "\"", 725, 3);
            WriteAttributeValue("", 697, "removeItemFromCart(\'", 697, 20, true);
#line 24 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
WriteAttributeValue("", 717, pd.Id, 717, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 723, "\')", 723, 2, true);
            EndWriteAttribute();
            BeginContext(726, 47, true);
            WriteLiteral(">Delete</span></td>\r\n\r\n                <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 773, "\"", 798, 1);
#line 26 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
WriteAttributeValue("", 779, pd.DefaultImageURL, 779, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(799, 53, true);
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n                <td>");
            EndContext();
            BeginContext(853, 7, false);
#line 27 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
               Write(pd.Name);

#line default
#line hidden
            EndContext();
            BeginContext(860, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(888, 8, false);
#line 28 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
               Write(pd.Price);

#line default
#line hidden
            EndContext();
            BeginContext(896, 120, true);
            WriteLiteral("</td>\r\n                <td class=\"form-inline\" style=\"width:200px\">\r\n                    <input type=\"text\" name=\"fname\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1016, "\"", 1036, 1);
#line 30 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
WriteAttributeValue("", 1024, pd.Quantity, 1024, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 40, true);
            WriteLiteral(" class=\"form-control\" style=\"width:40px\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1077, "\"", 1097, 2);
#line 30 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
WriteAttributeValue("", 1082, pd.Id, 1082, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1088, "-quantity", 1088, 9, true);
            EndWriteAttribute();
            BeginContext(1098, 30, true);
            WriteLiteral(" />\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1128, "\"", 1139, 1);
#line 31 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
WriteAttributeValue("", 1133, pd.Id, 1133, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1140, 134, true);
            WriteLiteral(" class=\"btn btn-warning\" onclick=\"update(this.id);\">Update</span>\r\n                </td>\r\n                <td class=\"text-right\">CDN$ ");
            EndContext();
            BeginContext(1275, 24, false);
#line 33 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
                                       Write(pd.Amount.ToString("n2"));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1336, 95, true);
            WriteLiteral("        <tr><td colspan=\"4\"></td><td class=\"text-right\"></td><td class=\"text-right\">Total CDN$ ");
            EndContext();
            BeginContext(1432, 31, false);
#line 36 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
                                                                                          Write(cart.TotalAmount.ToString("n2"));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 40, true);
            WriteLiteral("</td></tr>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
#line 41 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(1538, 23, false);
#line 43 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1565, 98, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Shipping Information</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(1664, 64, false);
#line 48 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1777, 101, false);
#line 50 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
       Write(Html.LabelFor(model => model.ReceiverName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1934, 101, false);
#line 52 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
           Write(Html.EditorFor(model => model.ReceiverName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2054, 90, false);
#line 53 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.ReceiverName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2231, 102, false);
#line 58 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
       Write(Html.LabelFor(model => model.ReceiverPhone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2333, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2389, 102, false);
#line 60 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
           Write(Html.EditorFor(model => model.ReceiverPhone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2491, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2510, 91, false);
#line 61 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.ReceiverPhone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2688, 104, false);
#line 66 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
       Write(Html.LabelFor(model => model.ReceiverAddress, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2792, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2848, 104, false);
#line 68 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
           Write(Html.EditorFor(model => model.ReceiverAddress, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2952, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2971, 93, false);
#line 69 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.ReceiverAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3064, 260, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Place Order"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 79 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Order\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Models.Cart.Ship> Html { get; private set; }
    }
}
#pragma warning restore 1591
