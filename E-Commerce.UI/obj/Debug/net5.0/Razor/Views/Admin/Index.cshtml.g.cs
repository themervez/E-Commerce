#pragma checksum "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce708206bd49594166d1361c894e0e124da8262f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\_ViewImports.cshtml"
using E_Commerce.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\_ViewImports.cshtml"
using E_Commerce.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\_ViewImports.cshtml"
using E_Commerce.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce708206bd49594166d1361c894e0e124da8262f", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab3ebadea11b42b597966b3ec6b7e302f3108a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Admin Products</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
 if (Model.Products.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Image</th>
                <th>Name</th>
                <th>Price</th>
                <th>Edit</th>
                <th>Delete</th>
            </tr>
        </thead>
");
#nullable restore
#line 23 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
         foreach (var item in Model.Products)
        {
            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce708206bd49594166d1361c894e0e124da8262f5082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 644, "~/img/", 644, 6, true);
#nullable restore
#line 29 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 650, item.ImageUrl, 650, 14, false);

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
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 801, "\"", 832, 2);
            WriteAttributeValue("", 808, "/Admin/Products/", 808, 16, true);
#nullable restore
#line 33 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
WriteAttributeValue("", 824, item.ID, 824, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Edit</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 902, "\"", 931, 2);
            WriteAttributeValue("", 909, "/Admin/Delete/", 909, 14, true);
#nullable restore
#line 34 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
WriteAttributeValue("", 923, item.ID, 923, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 38 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <h4>There Are No Products!</h4>\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\Merve\Documents\GitHub\E-Commerce\E-Commerce.UI\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591