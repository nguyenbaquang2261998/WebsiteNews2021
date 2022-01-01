#pragma checksum "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d28f756a47885e3a163a67a93bfffebc5590a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Articles_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Articles/Index.cshtml")]
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
#line 1 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
using DOLPHIN.Helpers.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d28f756a47885e3a163a67a93bfffebc5590a26", @"/Areas/Admin/Views/Articles/Index.cshtml")]
    public class Areas_Admin_Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        DATA TABLE
        <h3 class=""title-5 m-b-35"">data table</h3>
        <div class=""table-data__tool"">
            <div class=""table-data__tool-left"">
                <div class=""rs-select2--light rs-select2--md"">
                    <select class=""js-select2"" name=""property"">
                        <option selected=""selected"">All Properties</option>
                        <option");
            BeginWriteAttribute("value", " value=\"", 619, "\"", 627, 0);
            EndWriteAttribute();
            WriteLiteral(">Option 1</option>\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 679, "\"", 687, 0);
            EndWriteAttribute();
            WriteLiteral(@">Option 2</option>
                    </select>
                    <div class=""dropDownSelect2""></div>
                </div>
                <div class=""rs-select2--light rs-select2--sm"">
                    <select class=""js-select2"" name=""time"">
                        <option selected=""selected"">Today</option>
                        <option");
            BeginWriteAttribute("value", " value=\"", 1044, "\"", 1052, 0);
            EndWriteAttribute();
            WriteLiteral(">3 Days</option>\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 1102, "\"", 1110, 0);
            EndWriteAttribute();
            WriteLiteral(@">1 Week</option>
                    </select>
                    <div class=""dropDownSelect2""></div>
                </div>
                <button class=""au-btn-filter"">
                    <i class=""zmdi zmdi-filter-list""></i>filters
                </button>
            </div>
            <div class=""table-data__tool-right"">
                <a href=""/admin/articles/create"" class=""au-btn au-btn-icon au-btn--green au-btn--small"">
                    <i class=""zmdi zmdi-plus""></i>add article
                </a>
                <div class=""rs-select2--dark rs-select2--sm rs-select2--dark2"">
                    <select class=""js-select2"" name=""type"">
                        <option selected=""selected"">Export</option>
                        <option");
            BeginWriteAttribute("value", " value=\"", 1885, "\"", 1893, 0);
            EndWriteAttribute();
            WriteLiteral(">Option 1</option>\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 1945, "\"", 1953, 0);
            EndWriteAttribute();
            WriteLiteral(@">Option 2</option>
                    </select>
                    <div class=""dropDownSelect2""></div>
                </div>
            </div>
        </div>
        <div class=""table-responsive table-responsive-data2"">
            <table class=""table table-data2"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Author</th>
                        <th>Description</th>
                        <th>Publish</th>
                        <th>Update</th>
                        <th>Status</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 62 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"tr-shadow\">\r\n                            <td>");
#nullable restore
#line 65 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(item.Author.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                           Write(item.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 71 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                                 if (item.Status == (int)EnArticleStatus.Approved)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status--process\">Approved</span>\r\n");
#nullable restore
#line 74 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                                 if (item.Status == (int)EnArticleStatus.Pending)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status--denied\">Pending</span>\r\n");
#nullable restore
#line 78 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                                 if (item.Status == (int)EnArticleStatus.Delete)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"status--denied\">Delete</span>\r\n");
#nullable restore
#line 82 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </td>
                            <td>
                                <div class=""table-data-feature"">
                                    <span class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 4070, "\"", 4108, 2);
            WriteAttributeValue("", 4077, "/Admin/Articles/Update/", 4077, 23, true);
#nullable restore
#line 87 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
WriteAttributeValue("", 4100, item.Id, 4100, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-edit\"></i></a>\r\n                                    </span>\r\n                                    <span class=\"item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\">\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4348, "\"", 4374, 3);
            WriteAttributeValue("", 4358, "Delete(", 4358, 7, true);
#nullable restore
#line 90 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
WriteAttributeValue("", 4365, item.Id, 4365, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4373, ")", 4373, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-delete""></i></a>
                                    </span>
                                    <span class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""More"">
                                        <i class=""zmdi zmdi-more""></i>
                                    </span>
                                </div>
                            </td>
                        </tr>
                        <tr class=""spacer""></tr>
");
#nullable restore
#line 99 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        Total record : ");
#nullable restore
#line 103 "D:\QuangNB\Desktop\MMO\WebsiteNews2021\GenZ\DOLPHIN\Areas\Admin\Views\Articles\Index.cshtml"
                  Write(ViewBag.TotalRecord);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<script>
    function Delete(Id) {
        var data = {
            Id: Id,
        };
        var title = ""Bạn có đồng ý xóa dữ liệu này không?"";
        var url = '/Admin/Articles/Delete/';
        swal({
            title: title,
            icon: ""warning"",
            buttons: {
                ok: ""Xác nhận"",
                cancel: ""Hủy"",
            }
        }).then((isConfirm) => {
            if (isConfirm != 'ok') {

            } else {
                $.post(url, data,
                    function (rs) {
                        if (rs.status > 0) {
                            swal({
                                title: ""Xóa thành công!"",
                                text: ""Dữ liệu của bạn đã được cập nhật!"",
                                icon: ""success"",
                            }).then(function (isConfirm) {
                                window.location.href = '/Admin/Articles';
                            });
                       ");
            WriteLiteral(" }\r\n                        else {\r\n                            toastr.error(rs.message);\r\n                        }\r\n                    });\r\n            }\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
