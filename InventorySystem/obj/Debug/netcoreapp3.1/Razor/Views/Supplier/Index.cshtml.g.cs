#pragma checksum "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f0650f282c48d092a75c1378f08d8fc015d38e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Index), @"mvc.1.0.view", @"/Views/Supplier/Index.cshtml")]
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
#line 1 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\_ViewImports.cshtml"
using InventorySystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\_ViewImports.cshtml"
using InventorySystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f0650f282c48d092a75c1378f08d8fc015d38e4", @"/Views/Supplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08ca94934fdec9c383665cb0a4ad5df7ff12d6ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Supplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Supplier>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:4rem;width:4rem;border-radius:100%;box-shadow:.1rem .1rem black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
  
    ViewData["Title"] = "Supplier";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""container"">

    <div class=""text-center"">
        <h2>Supplier Summary</h2>
    </div>
    <div>
        <a href=""/supplier/CreateSupplier"" class=""btn btn-primary btn-info"">Add Supplier</a>
    </div>

    <table class=""table"">

        <tr>
            <th>");
#nullable restore
#line 23 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.sup_id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 26 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 27 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 28 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.image));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
           Write(Html.DisplayNameFor(a => a.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 33 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
          
            foreach (var sup in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
                   Write(sup.sup_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
                   Write(sup.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
                   Write(sup.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
                   Write(sup.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
                   Write(sup.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   \r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f0650f282c48d092a75c1378f08d8fc015d38e47877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1234, "~/images/", 1234, 9, true);
#nullable restore
#line 43 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
AddHtmlAttributeValue("", 1243, sup.image, 1243, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                       \r\n                        <div class=\"custom-control custom-switch\">\r\n                            <input   type=\"checkbox\" class=\"custom-control-input btn-status\" id=\"customSwitch1\" data-id=\"");
#nullable restore
#line 48 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
                                                                                                                    Write(sup.sup_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" checked>\r\n                            \r\n                        </div>\r\n\r\n\r\n\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1756, "\"", 1800, 2);
            WriteAttributeValue("", 1763, "/supplier/Editsupplier?id=", 1763, 26, true);
#nullable restore
#line 56 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
WriteAttributeValue("", 1789, sup.sup_id, 1789, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info edit-msg btn-sm\">Edit</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1875, "\"", 1913, 2);
            WriteAttributeValue("", 1882, "/supplier/Delete?id=", 1882, 20, true);
#nullable restore
#line 57 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
WriteAttributeValue("", 1902, sup.sup_id, 1902, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info delete-msg btn-sm\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Roshan\Desktop\InventorySystem\InventorySystem\Views\Supplier\Index.cshtml"
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
       
        <script>
            $(document).ready(function () {
                
                $('.btn-status').bootstrapToggle({
                    on: 'Enabled',
                    off: 'Disabled'
                });

                $("".edit-msg"").on('click', function () {
                    event.preventDefault();
                    var editmsg = confirm(""do you want to update?"");
                    if (editmsg == true) {
                        window.location.href = $(this).attr('href');
                    }
                })

                $('.btn-status').on('change', function () {
                    event.preventDefault();
                    var status = $(this).is("":checked"");
                    var id = $(this).data('id');
                    var url = `/Supplier/IsEnabledDisabled?id=${id}&status=${status}`;
                    console.log(id);
                    console.log(status);
                    console.log(url);
                    $.ajax({
 ");
                WriteLiteral(@"                       url: url,
                        type: 'get',
                        dataType: 'json',
                        success: function () {
                            alert(""success"");
                        }
                    })
                })
            })
        </script>

    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Supplier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
