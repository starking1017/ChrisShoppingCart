#pragma checksum "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9754f8b4e40143ac190dfdc182caeb923f5dc56d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageUser_Edit), @"mvc.1.0.view", @"/Views/ManageUser/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageUser/Edit.cshtml", typeof(AspNetCore.Views_ManageUser_Edit))]
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
#line 1 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9754f8b4e40143ac190dfdc182caeb923f5dc56d", @"/Views/ManageUser/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageUser_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 24, true);
            WriteLiteral("\r\n<h2>Edit User</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(204, 23, false);
#line 13 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(231, 35, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(267, 64, false);
#line 16 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(331, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(338, 25, false);
#line 17 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.Id));

#line default
#line hidden
            EndContext();
            BeginContext(363, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(370, 35, false);
#line 18 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.PasswordHash));

#line default
#line hidden
            EndContext();
            BeginContext(405, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(412, 40, false);
#line 19 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(452, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(459, 39, false);
#line 20 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.ConcurrencyStamp));

#line default
#line hidden
            EndContext();
            BeginContext(498, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(505, 37, false);
#line 21 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(542, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(549, 37, false);
#line 22 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(586, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(593, 33, false);
#line 23 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(626, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(633, 38, false);
#line 24 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.NormalizedEmail));

#line default
#line hidden
            EndContext();
            BeginContext(671, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(678, 41, false);
#line 25 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.NormalizedUserName));

#line default
#line hidden
            EndContext();
            BeginContext(719, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(726, 36, false);
#line 26 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.SecurityStamp));

#line default
#line hidden
            EndContext();
            BeginContext(762, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(769, 39, false);
#line 27 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.HiddenFor(p => p.TwoFactorEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(808, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(851, 97, false);
#line 30 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(948, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(996, 97, false);
#line 32 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
       Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1108, 86, false);
#line 33 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1265, 94, false);
#line 38 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1407, 94, false);
#line 40 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1516, 83, false);
#line 41 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1670, 100, false);
#line 46 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
   Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1818, 100, false);
#line 48 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1933, 83, false);
#line 49 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 221, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 59 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(2240, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2254, 44, false);
#line 62 "C:\Users\stark\Source\repos\ChrisShoppingCart\ShoppingCart\Views\ManageUser\Edit.cshtml"
Write(Html.ActionLink("Back to Userlist", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
