#pragma checksum "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a662574942fc8311d4bb1670093c71306f76d7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VeMayBay_Index), @"mvc.1.0.view", @"/Views/VeMayBay/Index.cshtml")]
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
#line 1 "D:\PBL3-TicketWeb\TicketWeb\Views\_ViewImports.cshtml"
using TicketWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PBL3-TicketWeb\TicketWeb\Views\_ViewImports.cshtml"
using TicketWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a662574942fc8311d4bb1670093c71306f76d7f9", @"/Views/VeMayBay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb632d47e17aa42a9fa559e95a81be29ee3cc51", @"/Views/_ViewImports.cshtml")]
    public class Views_VeMayBay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TicketWeb.Models.VeMayBay>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
  

    Layout = "_LayoutPortal3";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .header {
        background-color: #1559b6;
        text-align: center;
        padding: 5px;
        border-bottom: 2px ridge #ffffff;
        font-size: 30px;
        color: azure;
        font-family: sans-serif;
    }
    .btn_add {
        border-radius: 5px;
        color: #ffffff;
        background-color: #4cff00;
        padding: 10px;
    }
    body {
        background-image: url(""https://img2.thuthuatphanmem.vn/uploads/2019/03/02/hinh-nen-powerpoint-xanh-duong-cuc-dep_012324053.jpeg"");
        line-height:3.5;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a662574942fc8311d4bb1670093c71306f76d7f94779", async() => {
                WriteLiteral("\r\n    <title>Quản Lý Vé Máy Bay</title>\r\n    <div class=\"header\">\r\n        <h1 class=\"head-title\">QUẢN LÝ VÉ MÁY BAY</h1>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<p style=\"text-align:left\";>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a662574942fc8311d4bb1670093c71306f76d7f95932", async() => {
                WriteLiteral("Thêm vé máy bay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ChuyenBay_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenKhach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NguoiDat_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GiaVe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 72 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ChuyenBay_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenKhach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NguoiDat_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GiaVe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.ActionLink("Chỉnh sửa", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 101 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
           Write(Html.ActionLink("Xóa", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 104 "D:\PBL3-TicketWeb\TicketWeb\Views\VeMayBay\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TicketWeb.Models.VeMayBay>> Html { get; private set; }
    }
}
#pragma warning restore 1591
