#pragma checksum "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ddd6c9252fa2e1470bdd62037412f42fdd9c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#line 1 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ddd6c9252fa2e1470bdd62037412f42fdd9c27", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:270px ; height:330px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blackfriday.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/home/shipping.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Shop";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-3"">
                <div class=""left-sidebar"">
                    <h2>Danh Mục</h2>
                    <div class=""panel-group category-products"" id=""accordian"">
                        <!--category-productsr-->
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Quần áo thể thao
                                    </a>
                                </h4>
                            </div>
                            <div id=""sportswear"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
   ");
            WriteLiteral(@"                                 <ul>
                                        <li><a href=""#"">Nike </a></li>
                                        <li><a href=""#"">Under Armour </a></li>
                                        <li><a href=""#"">Adidas </a></li>
                                        <li><a href=""#"">Puma</a></li>
                                        <li><a href=""#"">ASICS </a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#mens"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Quần áo Nam
                             ");
            WriteLiteral(@"       </a>
                                </h4>
                            </div>
                            <div id=""mens"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        <li><a href=""#"">Fendi</a></li>
                                        <li><a href=""#"">Guess</a></li>
                                        <li><a href=""#"">Valentino</a></li>
                                        <li><a href=""#"">Dior</a></li>
                                        <li><a href=""#"">Versace</a></li>
                                        <li><a href=""#"">Armani</a></li>
                                        <li><a href=""#"">Prada</a></li>
                                        <li><a href=""#"">Dolce and Gabbana</a></li>
                                        <li><a href=""#"">Chanel</a></li>
                                        <li><a href=""#"">Gucci</a></li>
                    ");
            WriteLiteral(@"                </ul>
                                </div>
                            </div>
                        </div>

                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#womens"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Quần áo nữ
                                    </a>
                                </h4>
                            </div>
                            <div id=""womens"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        <li><a href=""#"">Fendi</a></li>
                                        <li><a href=""#"">Guess</a></li>
               ");
            WriteLiteral(@"                         <li><a href=""#"">Valentino</a></li>
                                        <li><a href=""#"">Dior</a></li>
                                        <li><a href=""#"">Versace</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Quần áo trẻ em</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Thời trang</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
 ");
            WriteLiteral(@"                               <h4 class=""panel-title""><a href=""#"">Trang phục gia đình</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Túi xách</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Giày</a></h4>
                            </div>
                        </div>
                    </div>
                    <!--/category-productsr-->

                    <div class=""shipping text-center"">
                        <!--shipping-->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62ddd6c9252fa2e1470bdd62037412f42fdd9c2711113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--/brands_products-->

                    <div class=""price-range"">
                        <!--price-range-->
                        <h2>Price Range</h2>
                        <div class=""well"">
                            <input type=""text"" class=""span2""");
            BeginWriteAttribute("value", " value=\"", 6509, "\"", 6517, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-slider-min=""0"" data-slider-max=""600""
                                   data-slider-step=""5"" data-slider-value=""[250,450]"" id=""sl2""><br />
                            <b>$ 0</b> <b class=""pull-right"">$ 600</b>
                        </div>
                    </div>
                    <!--/price-range-->

                    <div class=""shipping text-center"">
                        <!--shipping-->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62ddd6c9252fa2e1470bdd62037412f42fdd9c2713233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--/shipping-->

                </div>
            </div>

            <div class=""col-sm-9 padding-right"">
                <div class=""features_items"">
                    <!--features_items-->
                    <h2 class=""title text-center"">Sản phẩm tìm kiếm</h2>
");
#nullable restore
#line 141 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-4"">
                            <div class=""product-image-wrapper"">
                                <div class=""single-products"">
                                    <div class=""productinfo text-center"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 7703, "\"", 7732, 2);
            WriteAttributeValue("", 7710, "/Home/Details/", 7710, 14, true);
#nullable restore
#line 147 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
WriteAttributeValue("", 7724, item.Id, 7724, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62ddd6c9252fa2e1470bdd62037412f42fdd9c2715675", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7744, "~/images/", 7744, 9, true);
#nullable restore
#line 147 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
AddHtmlAttributeValue("", 7753, item.Images, 7753, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                        <h2>");
#nullable restore
#line 148 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
                                       Write(string.Format("{0:##,#}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</h2>\r\n                                        <p>");
#nullable restore
#line 149 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 7981, "\"", 8010, 2);
            WriteAttributeValue("", 7988, "/Home/Details/", 7988, 14, true);
#nullable restore
#line 150 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
WriteAttributeValue("", 8002, item.Id, 8002, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-default add-to-cart"">
                                            <i class=""fa fa-shopping-cart""></i>Thêm vào giỏ
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 157 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Views\Home\Shop.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--features_items-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
