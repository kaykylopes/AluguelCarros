#pragma checksum "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4ccb7bdf478c16b3151fd103b10009287d1957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CarrosAlugados_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CarrosAlugados/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CarrosAlugados/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CarrosAlugados_Default))]
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
#line 1 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\_ViewImports.cshtml"
using AluguelCarros;

#line default
#line hidden
#line 2 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\_ViewImports.cshtml"
using AluguelCarros.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4ccb7bdf478c16b3151fd103b10009287d1957", @"/Views/Shared/Components/CarrosAlugados/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719f5ed436d95cc99fb2d50d73887460511b7e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CarrosAlugados_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AluguelCarros.Models.Aluguel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 4 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(112, 124, true);
            WriteLiteral("        <div class=\"col-4\">\r\n            <div class=\"cartoes\">\r\n                <div class=\"card\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 236, "\"", 271, 1);
#line 9 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
WriteAttributeValue("", 242, Url.Content(item.Carro.Foto), 242, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(272, 128, true);
            WriteLiteral(" class=\"card-img-top img-fluid\" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(401, 16, false);
#line 11 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                          Write(item.Carro.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(417, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(421, 15, false);
#line 11 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                                              Write(item.Carro.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(436, 35, true);
            WriteLiteral("</h5>\r\n                        <h5>");
            EndContext();
            BeginContext(472, 11, false);
#line 12 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                       Write(item.Inicio);

#line default
#line hidden
            EndContext();
            BeginContext(483, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(487, 8, false);
#line 12 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                      Write(item.Fim);

#line default
#line hidden
            EndContext();
            BeginContext(495, 72, true);
            WriteLiteral("</h5>\r\n                        <h5><span class=\"badge badge-success\">R$ ");
            EndContext();
            BeginContext(568, 15, false);
#line 13 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                                            Write(item.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(583, 105, true);
            WriteLiteral(",00</span></h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Users\KAYKY\source\repos\AluguelCarros\AluguelCarros\Views\Shared\Components\CarrosAlugados\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(695, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AluguelCarros.Models.Aluguel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
