#pragma checksum "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5909902f6faa7b70d31448c1541acfb2ca40a09b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Create.cshtml", typeof(AspNetCore.Views_Product_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5909902f6faa7b70d31448c1541acfb2ca40a09b", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.Product.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 21, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(188, 23, false);
#line 12 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(219, 77, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Product</h4>\r\n        <hr />\r\n");
            EndContext();
#line 17 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
         if (ViewBag.ResultMessage != null)
        {
            

#line default
#line hidden
            BeginContext(365, 92, false);
#line 19 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.ValidationSummary(true, (string)ViewBag.ResultMessage , new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 19 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
                                                                                                         
        }

#line default
#line hidden
            BeginContext(470, 46, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(517, 93, false);
#line 22 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(666, 93, false);
#line 24 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(759, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(778, 82, false);
#line 25 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(860, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(947, 100, false);
#line 30 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1103, 100, false);
#line 32 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1222, 89, false);
#line 33 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 88, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1400, 94, false);
#line 39 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1550, 94, false);
#line 41 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1663, 83, false);
#line 42 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1833, 100, false);
#line 47 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.PublishDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1989, 99, false);
#line 49 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.PublishDate, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2107, 89, false);
#line 50 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.PublishDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2283, 95, false);
#line 55 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Status, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 99, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <div class=\"checkbox\">\r\n                    ");
            EndContext();
            BeginContext(2478, 37, false);
#line 58 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
               Write(Html.EditorFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2515, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2538, 84, false);
#line 59 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2622, 110, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2733, 97, false);
#line 65 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.Quantity, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2886, 97, false);
#line 67 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.Quantity, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2983, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3002, 86, false);
#line 68 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Quantity, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3088, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3175, 104, false);
#line 73 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
       Write(Html.LabelFor(model => model.DefaultImageURL, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3279, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3335, 104, false);
#line 75 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.EditorFor(model => model.DefaultImageURL, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3439, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3458, 93, false);
#line 76 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.DefaultImageURL, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3551, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 86 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
}

#line default
#line hidden
            BeginContext(3809, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3823, 40, false);
#line 89 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\Product\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3863, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Models.Product.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
