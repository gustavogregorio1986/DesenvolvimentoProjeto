#pragma checksum "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3678357573e4c094da2eb2705f5309c01567d1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Protocolo_Consultar), @"mvc.1.0.view", @"/Views/Protocolo/Consultar.cshtml")]
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
#line 1 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\_ViewImports.cshtml"
using Desenvolvimento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\_ViewImports.cshtml"
using Desenvolvimento.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3678357573e4c094da2eb2705f5309c01567d1d0", @"/Views/Protocolo/Consultar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11c964cb3d0f7b5bd09168b1485bd9a633f0c25", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Protocolo_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProtocoloModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
  
    ViewData["Title"] = "Consultar Protocolo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">Consultar Protocolo</h2>\r\n</div>\r\n\r\n  <br/>\r\n\r\n");
#nullable restore
#line 12 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
     if(TempData["MensagemSucesso"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"alert alert-success\" role=\"alert\">\r\n           <button type=\"button\" class=\"btn btn-danger btn-sm close-alert\" arial-label=\"Close\">X</button>\r\n           ");
#nullable restore
#line 16 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
      Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>   \r\n");
#nullable restore
#line 18 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
     if(TempData["MensagemErro"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"alert alert-success\" role=\"alert\">\r\n           <button type=\"button\" class=\"btn btn-danger btn-sm close-alert\" arial-label=\"Close\">X</button>\r\n           ");
#nullable restore
#line 24 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
      Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>   \r\n");
#nullable restore
#line 26 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br/>


<table class=""table"" id=""table-protocolos"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Nome</th>
      <th scope=""col"">E-mail</th>
      <th scope=""col"">Numero Protocolo</th>
      <th scope=""col"">Tipo</th>
      <th scope=""col"">Data do protocolo</th>
      <th scope=""col""></th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 44 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
     if(Model != null && Model.Any())
    {
        foreach(var protocolo in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 49 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
                           Write(protocolo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 50 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
               Write(protocolo.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
               Write(protocolo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
               Write(protocolo.NumProtocolo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
               Write(protocolo.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
               Write(protocolo.DataProtocolo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                  <a role=\"button\" class=\"btn btn-primary\">Editar</a>\r\n                  <a role=\"button\" class=\"btn btn-danger\">Apagar</a>\r\n              </td>\r\n            </tr>        \r\n");
#nullable restore
#line 60 "C:\DesenvProjeto\Desenvolvimento\Desenvolvimento\Views\Protocolo\Consultar.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProtocoloModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
