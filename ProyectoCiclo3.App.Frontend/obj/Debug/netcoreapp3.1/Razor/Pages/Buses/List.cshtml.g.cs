#pragma checksum "C:\Users\DarkSide\Google Drive\MisionTIC\Desarrollo de Sofware\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Buses\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3494b88b318b3fbd4d2107a386e627468de044ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Buses.Pages_Buses_List), @"mvc.1.0.razor-page", @"/Pages/Buses/List.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Buses
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
#line 1 "C:\Users\DarkSide\Google Drive\MisionTIC\Desarrollo de Sofware\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3494b88b318b3fbd4d2107a386e627468de044ae", @"/Pages/Buses/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buses_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 
<table class=""table table-striped table-hover"">
  <thead>
    <tr>
      <th scope=""col"">ID</th>
      <th scope=""col"">Marca</th>
      <th scope=""col"">Modelo</th>
      <th scope=""col"">Kilometraje</th>
      <th scope=""col"">Número de Asientos</th>
      <th scope=""col"">Placa</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope=""row"">1</th>
      <td>Mazda</td>
      <td>CX5</td>
      <td>8500</td>
      <td>5</td>
      <td>XBN850</td>
    </tr>
    <tr>
      <th scope=""row"">2</th>
      <td>Toyota</td>
      <td>CX5</td>
      <td>8500</td>
      <td>5</td>
      <td>XBN850</td>
    </tr>
    <tr>
      <th scope=""row"">3</th>
      <td>Honda</td>
      <td>CX5</td>
      <td>8500</td>
      <td>5</td>
      <td>XBN850</td>
    </tr>
  </tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Buses_List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Buses_List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Buses_List>)PageContext?.ViewData;
        public Pages_Buses_List Model => ViewData.Model;
    }
}
#pragma warning restore 1591
