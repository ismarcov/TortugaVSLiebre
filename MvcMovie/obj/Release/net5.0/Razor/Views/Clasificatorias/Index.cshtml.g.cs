#pragma checksum "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5051a067da995c6f1ec42fd4f987802ca1c88c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clasificatorias_Index), @"mvc.1.0.view", @"/Views/Clasificatorias/Index.cshtml")]
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
#line 1 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5051a067da995c6f1ec42fd4f987802ca1c88c2e", @"/Views/Clasificatorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Clasificatorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TortugaLiebre.Models.Clasificatorias>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
  
    ViewData["Title"] = "Clasificatorias";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tabla de Clasificatorias</h1>\r\n\r\n<table class=\"table table-striped table-bordered table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumCarrera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ganador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaCarrera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apostadores));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ganancias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumCarrera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ganador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaCarrera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apostadores));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ganancias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>            \r\n        </tr>\r\n");
#nullable restore
#line 48 "F:\Workspace\TortugaLiebre\MvcMovie\MvcMovie\MvcMovie\Views\Clasificatorias\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TortugaLiebre.Models.Clasificatorias>> Html { get; private set; }
    }
}
#pragma warning restore 1591
