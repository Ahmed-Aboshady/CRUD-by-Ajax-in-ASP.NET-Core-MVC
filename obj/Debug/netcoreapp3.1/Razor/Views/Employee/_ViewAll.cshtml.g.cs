#pragma checksum "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6db1ef4f54d3c774b90d0b5b35f42f9e1e24521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee__ViewAll), @"mvc.1.0.view", @"/Views/Employee/_ViewAll.cshtml")]
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
#line 1 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\_ViewImports.cshtml"
using CRUDbyAjaxinASP.NETCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\_ViewImports.cshtml"
using CRUDbyAjaxinASP.NETCoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6db1ef4f54d3c774b90d0b5b35f42f9e1e24521", @"/Views/Employee/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61cb881071f35dea0ea84bfeed60e75cd9e3c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CRUDbyAjaxinASP.NETCoreMVC.Models.employeemodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Age
            </th>
            <th>
                Salary
            </th>
            <th>
                Moblie
            </th>
            <th>
                Date
            </th>
            <th>
                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 458, "\"", 561, 4);
            WriteAttributeValue("", 468, "showInPopup(\'", 468, 13, true);
#nullable restore
#line 23 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
WriteAttributeValue("", 481, Url.Action("AddOrEdit","Employee",null,Context.Request.Scheme), 481, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 544, "\',\'New", 544, 6, true);
            WriteAttributeValue(" ", 550, "Employee\')", 551, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\">\r\n                    <i class=\"fas fa-plus\"></i>\r\n                    New Employee\r\n                </a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
               Write(item.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
               Write(item.salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
               Write(item.moblie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1265, "\"", 1384, 4);
            WriteAttributeValue("", 1275, "showInPopup(\'", 1275, 13, true);
#nullable restore
#line 50 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
WriteAttributeValue("", 1288, Url.Action("AddOrEdit","Employee",new {id=item.id },Context.Request.Scheme), 1288, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1364, "\',\'Update", 1364, 9, true);
            WriteAttributeValue(" ", 1373, "Employee\')", 1374, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i>Edit</a>\r\n                    |\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6db1ef4f54d3c774b90d0b5b35f42f9e1e245218451", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
                                                WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "F:\2-oop\Core\CRUDbyAjaxinASP.NETCoreMVC\CRUDbyAjaxinASP.NETCoreMVC\Views\Employee\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CRUDbyAjaxinASP.NETCoreMVC.Models.employeemodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
