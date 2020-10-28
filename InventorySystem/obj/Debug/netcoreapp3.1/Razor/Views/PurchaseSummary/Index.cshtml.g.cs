#pragma checksum "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8741a7443a525cb8cf29276bee10b6124f2b34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseSummary_Index), @"mvc.1.0.view", @"/Views/PurchaseSummary/Index.cshtml")]
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
#line 1 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\_ViewImports.cshtml"
using InventorySystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\_ViewImports.cshtml"
using InventorySystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8741a7443a525cb8cf29276bee10b6124f2b34", @"/Views/PurchaseSummary/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08ca94934fdec9c383665cb0a4ad5df7ff12d6ca", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseSummary_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventorySystem.Models.PurchaseSummary>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
  
    ViewData["Title"] = "PurchasseSummary";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        .my-custom-scrollbar {\r\n            position: relative;\r\n           \r\n            overflow: auto;\r\n        }\r\n\r\n        .table-wrapper-scroll-y {\r\n            display: block;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\" text-center\">Purchase Summary</div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb8741a7443a525cb8cf29276bee10b6124f2b344924", async() => {
                WriteLiteral("New Purchase");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""row"">
        <div class=""col-md-12 table-wrapper-scroll-y my-custom-scrollbar"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Purchase_id</th>
                        <th>Supplier</th>
                        <th>Total</th>
                        <th>Discount</th>
                        <th>Vat</th>
                        <th>Net-Total</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                      
                        foreach (var summary in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                               Write(summary.pch_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                               Write(summary.supvalue.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                               Write(summary.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                               Write(summary.discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                               Write(summary.vat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                               Write(summary.net_total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a class=\"btn btn-info btn-details btn-sm\" data-toggle=\"modal\" data-target=\"#myModal\">show details</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1894, "\"", 1933, 2);
            WriteAttributeValue("", 1901, "purchase/Bill?id=", 1901, 17, true);
#nullable restore
#line 52 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
WriteAttributeValue("", 1918, summary.pch_id, 1918, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-bill btn-sm\">Bill</a>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Roshan\Desktop\InventorySystem Revised\InventorySystem\Views\PurchaseSummary\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div id=""myModal"" class=""modal fade"" role=""dialog"">
            <div class=""modal-dialog"">

                <!-- Modal content-->
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                       
                    </div>
                    <div class=""modal-body"">
                        <div class=""col-md-12 display"" style=""display:none"">
                            <table class=""table table-data"">
                                <thead>
                                    <tr>
                                        <th>product</th>
                                        <th>quantity</th>
                                        <th>price</th>
                                        <th>Total</th>
                                    </tr>
                                ");
            WriteLiteral(@"</thead>
                                <tbody>
                                    <tr></tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>

            </div>
        </div>
       

    </div>
    </div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            $('.btn-details').on('click', function () {
                event.preventDefault();
                var id = $(this).closest('tr').find('td:first-child').text();
                url = `/purchasesummary/showdetails?id=${id}`;

                $.ajax({
                    url: url,
                    type: 'get',
                    dataType: 'json',
                    success: function (data) {
                        $('.display').css({ ""display"": ""block"" });
                        $('.table-data tbody tr').remove();
                        for (var i = 0; i < data.length; i++) {
                            $('.table-data tbody').append(
                                `
                            <tr>
                                <td>${data[i].product}</td>
                                   <td>${data[i].qty}</td>
                                       <td>${data[i].price}</td>
                                  ");
                WriteLiteral("  <td>${data[i].total}</td>\r\n                            </tr>\r\n                                        `\r\n                            )\r\n                        }\r\n\r\n                    }\r\n                })\r\n            })\r\n        })\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventorySystem.Models.PurchaseSummary>> Html { get; private set; }
    }
}
#pragma warning restore 1591
