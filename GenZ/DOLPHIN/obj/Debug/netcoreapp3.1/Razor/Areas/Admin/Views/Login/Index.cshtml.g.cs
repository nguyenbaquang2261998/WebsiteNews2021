#pragma checksum "D:\MakeMoneyWebsite\GenZ\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e109205762897b420229560656e0324776505231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Login_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e109205762897b420229560656e0324776505231", @"/Areas/Admin/Views/Login/Index.cshtml")]
    public class Areas_Admin_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MakeMoneyWebsite\GenZ\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"login-form\">\r\n    <form");
            BeginWriteAttribute("action", " action=\"", 140, "\"", 149, 0);
            EndWriteAttribute();
            WriteLiteral(@" method=""post"">
        <div class=""form-group"">
            <label>Email Address</label>
            <input class=""au-input au-input--full"" type=""email"" name=""email"" placeholder=""Email"">
        </div>
        <div class=""form-group"">
            <label>Password</label>
            <input class=""au-input au-input--full"" type=""password"" name=""password"" placeholder=""Password"">
        </div>
        <div class=""login-checkbox"">
            <label>
                <input type=""checkbox"" name=""remember"">Remember Me
            </label>
            <label>
                <a href=""#"">Forgotten Password?</a>
            </label>
        </div>
        <button class=""au-btn au-btn--block au-btn--green m-b-20"" type=""submit"">sign in</button>
        <div class=""social-login-content"">
            <div class=""social-button"">
                <button class=""au-btn au-btn--block au-btn--blue m-b-20"">sign in with facebook</button>
                <button class=""au-btn au-btn--block au-btn--blue2"">sign ");
            WriteLiteral("in with twitter</button>\r\n            </div>\r\n        </div>\r\n    </form>\r\n    <div class=\"register-link\">\r\n        <p>\r\n            Don\'t you have account?\r\n            <a href=\"#\">Sign Up Here</a>\r\n        </p>\r\n    </div>\r\n</div>");
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
