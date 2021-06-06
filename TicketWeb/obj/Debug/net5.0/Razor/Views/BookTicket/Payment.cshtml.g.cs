#pragma checksum "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e031808a5f7d53ce5126079e6b3d413c5f91537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookTicket_Payment), @"mvc.1.0.view", @"/Views/BookTicket/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e031808a5f7d53ce5126079e6b3d413c5f91537", @"/Views/BookTicket/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb632d47e17aa42a9fa559e95a81be29ee3cc51", @"/Views/_ViewImports.cshtml")]
    public class Views_BookTicket_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TicketWeb.Models.VeMayBay>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e031808a5f7d53ce5126079e6b3d413c5f915373864", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <style>
        body {
            font-family: Arial;
            font-size: 17px;
            padding: 8px;
        }

        * {
            box-sizing: border-box;
        }

        .row {
            display: -ms-flexbox; /* IE10 */
            display: flex;
            -ms-flex-wrap: wrap; /* IE10 */
            flex-wrap: wrap;
            margin: 0 -16px;
        }

        .col-25 {
            -ms-flex: 25%; /* IE10 */
            flex: 25%;
        }

        .col-50 {
            -ms-flex: 50%; /* IE10 */
            flex: 50%;
        }

        .col-75 {
            -ms-flex: 75%; /* IE10 */
            flex: 75%;
        }

        .col-25,
        .col-50,
        .col-75 {
            padding: 0 16px;
        }

        .container {
            backgroun");
                WriteLiteral(@"d-color: #f2f2f2;
            padding: 5px 20px 15px 20px;
            border: 1px solid lightgrey;
            border-radius: 3px;
        }

        input[type=text] {
            width: 100%;
            margin-bottom: 20px;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        label {
            margin-bottom: 10px;
            display: block;
        }

        .icon-container {
            margin-bottom: 20px;
            padding: 7px 0;
            font-size: 24px;
        }

        .btn {
            background-color: #04AA6D;
            color: white;
            padding: 12px;
            margin: 10px 0;
            border: none;
            width: 100%;
            border-radius: 3px;
            cursor: pointer;
            font-size: 17px;
        }

            .btn:hover {
                background-color: #45a049;
            }

        a {
            color: #2196F3;
        }

        h");
                WriteLiteral(@"r {
            border: 1px solid lightgrey;
        }

        span.price {
            float: right;
            color: grey;
        }

        .media(max-width: 800px) {
            .row

        {
            flex-direction: column-reverse;
        }

        .col-25 {
            margin-bottom: 20px;
        }
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e031808a5f7d53ce5126079e6b3d413c5f915377317", async() => {
                WriteLiteral("\r\n    <h2>Thanh Toán</h2>\r\n    <p>Điền thông tin chi tiết khách hàng tại đây.</p>\r\n    <div class=\"row\">\r\n        <div class=\"col-75\">\r\n            <div class=\"container\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e031808a5f7d53ce5126079e6b3d413c5f915377778", async() => {
                    WriteLiteral(@"

                    <div class=""row"">
                        <div class=""col-50"">
                            <h3>Địa Chỉ Thanh Toán</h3>
                            <label for=""fname""><i class=""fa fa-user""></i> Họ và tên</label>
                            <input type=""text"" id=""fname"" name=""firstname"" placeholder=""Nguyễn Văn A"">
                            <label for=""email""><i class=""fa fa-envelope""></i> Email</label>
                            <input type=""text"" id=""email"" name=""email"" placeholder=""nguyenvana@gmail.com"">
                            <label for=""adr""><i class=""fa fa-address-card-o""></i> Địa Chỉ</label>
                            <input type=""text"" id=""adr"" name=""address"" placeholder=""500-NguyenLuongBang"">
                            <label for=""city""><i class=""fa fa-institution""></i> Thành Phố</label>
                            <input type=""text"" id=""city"" name=""city"" placeholder=""Da Nang"">

                            <div class=""row"">
                                <");
                    WriteLiteral(@"div class=""col-50"">
                                    <label for=""state"">Quận/Huyện</label>
                                    <input type=""text"" id=""state"" name=""state"" placeholder=""NY"">
                                </div>
                                <div class=""col-50"">
                                    <label for=""zip"">Mã Bưu Chính</label>
                                    <input type=""text"" id=""zip"" name=""zip"" placeholder=""10001"">
                                </div>
                            </div>
                        </div>

                        <div class=""col-50"">
                            <h3>Payment</h3>
                            <label for=""fname"">Thẻ Được Chấp Nhận</label>
                            <div class=""icon-container"">
                                <i class=""fa fa-cc-visa"" style=""color:navy;""></i>
                                <i class=""fa fa-cc-amex"" style=""color:blue;""></i>
                                <i class=""fa fa-cc-mastercard"" ");
                    WriteLiteral(@"style=""color:red;""></i>
                                <i class=""fa fa-cc-discover"" style=""color:orange;""></i>
                            </div>
                            <label for=""cname"">Tên Chủ Thẻ</label>
                            <input type=""text"" id=""cname"" name=""cardname"" placeholder=""Nguyễn Văn A"">
                            <label for=""ccnum"">Số Thẻ</label>
                            <input type=""text"" id=""ccnum"" name=""cardnumber"" placeholder=""1111-2222-3333-4444"">
                            <label for=""expmonth"">Tháng Hết Hạn</label>
                            <input type=""text"" id=""expmonth"" name=""expmonth"" placeholder=""Tháng 1"">
                            <div class=""row"">
                                <div class=""col-50"">
                                    <label for=""expyear"">Năm Hết Hạn</label>
                                    <input type=""text"" id=""expyear"" name=""expyear"" placeholder=""2018"">
                                </div>
                               ");
                    WriteLiteral(@" <div class=""col-50"">
                                    <label for=""cvv"">Mã Xác Minh</label>
                                    <input type=""text"" id=""cvv"" name=""cvv"" placeholder=""352"">
                                </div>
                            </div>
                        </div>

                    </div>
                    <label>
                        <input type=""checkbox"" checked=""checked"" name=""sameadr""> Địa chỉ trùng với thanh toán
                    </label>
                    <div style=""text-align:center;display:flex"">
                        <a href=""/BookTicket/Success"" style=""text-decoration: none"" class=""btn"">Thanh Toán</a>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 188 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.ChuyenBay_ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 191 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.TenKhach));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 194 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 197 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 200 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 204 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.GiaVe));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 210 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 214 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.ChuyenBay_ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 217 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenKhach));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 220 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 223 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 226 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 229 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
               Write(Html.DisplayFor(modelItem => item.GiaVe));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 232 "D:\PBL3-TicketWeb\TicketWeb\Views\BookTicket\Payment.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
