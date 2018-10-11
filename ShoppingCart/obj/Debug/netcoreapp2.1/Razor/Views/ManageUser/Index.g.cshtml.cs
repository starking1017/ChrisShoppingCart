#pragma checksum "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e9dddf5a76b08db26c49b6362e59fb21f54ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageUser_Index), @"mvc.1.0.view", @"/Views/ManageUser/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageUser/Index.cshtml", typeof(AspNetCore.Views_ManageUser_Index))]
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
#line 1 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e9dddf5a76b08db26c49b6362e59fb21f54ea8", @"/Views/ManageUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 28, true);
            WriteLiteral("\r\n<h2>User Management</h2>\r\n");
            EndContext();
#line 10 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
 if (ViewBag.ResultMessage != null)
{
    

#line default
#line hidden
            BeginContext(232, 79, false);
#line 12 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
Write(Html.Label("info", (string)ViewBag.ResultMessage, new { @class = "text-info" }));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
                                                                                    
}

#line default
#line hidden
            BeginContext(316, 85, true);
            WriteLiteral("<table class=\"table table-hover table-striped\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(402, 44, false);
#line 17 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(446, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(490, 41, false);
#line 20 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(531, 57, true);
            WriteLiteral("\r\n        </th>\r\n        <th>Operator</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 25 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(620, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(657, 43, false);
#line 28 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(700, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(744, 40, false);
#line 31 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(784, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(828, 87, false);
#line 34 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { pId = item.Id }, new { @class="btn btn-primary"}));

#line default
#line hidden
            EndContext();
            BeginContext(915, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Index.cshtml"
}

#line default
#line hidden
            BeginContext(946, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
