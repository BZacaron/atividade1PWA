#pragma checksum "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\atividade1PWA\Atividade1\Atividade1\Views\Shared\Recuperar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63527855aadba7eae0b46121a170d876e399a8f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Recuperar), @"mvc.1.0.view", @"/Views/Shared/Recuperar.cshtml")]
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
#line 1 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\atividade1PWA\Atividade1\Atividade1\Views\_ViewImports.cshtml"
using Atividade1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\atividade1PWA\Atividade1\Atividade1\Views\_ViewImports.cshtml"
using Atividade1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63527855aadba7eae0b46121a170d876e399a8f5", @"/Views/Shared/Recuperar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ed4c3d785faa28005bfa3f4321b875554ce590", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Recuperar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\atividade1PWA\Atividade1\Atividade1\Views\Shared\Recuperar.cshtml"
  
    ViewData["Title"] = "Esqueceu sua senha?";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\Windows 10\Desktop\Bernardo\Faculdade\3º semestre\Programação Windows Avançada\Projetos\atividade1PWA\Atividade1\Atividade1\Views\Shared\Recuperar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"text-center\">\r\n    <label for=\"email\">E-mail:</label>\r\n    <input type=\"text\" name=\"email\" /><br />\r\n\r\n    <input type=\"button\" value=\"Resgatar\" onclick=\"location.href= \'/Home/Login\'\"/>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
