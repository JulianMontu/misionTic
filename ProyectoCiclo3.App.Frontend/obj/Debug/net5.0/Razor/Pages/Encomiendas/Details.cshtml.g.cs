#pragma checksum "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e930f8657d3e28e54315a19b7c0693f6607fa218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Encomiendas.Pages_Encomiendas_Details), @"mvc.1.0.razor-page", @"/Pages/Encomiendas/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Encomiendas
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
#line 1 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e930f8657d3e28e54315a19b7c0693f6607fa218", @"/Pages/Encomiendas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489d2d6cfbe8da160b6d3b7af72ec123e9ec6804", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Encomiendas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml"
  
  var enc = Model.encomiendas;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul class=\"list-group list-group-flush\">\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml"
                                      Write(enc.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"> <b>Descripcion: </b> ");
#nullable restore
#line 9 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml"
                                               Write(enc.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"> <b>Peso: </b> ");
#nullable restore
#line 10 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml"
                                        Write(enc.peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"> <b>Tipo: </b> ");
#nullable restore
#line 11 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml"
                                        Write(enc.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n  <li class=\"list-group-item\"> <b>Presentacion: </b> ");
#nullable restore
#line 12 "E:\misionTic-feature-Julian\ejercicio_base_ciclo3_MT-main\ProyectoCiclo3.App.Frontend\Pages\Encomiendas\Details.cshtml"
                                                Write(enc.presentacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsEncomiendaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsEncomiendaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsEncomiendaModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsEncomiendaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591