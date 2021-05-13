#pragma checksum "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c2c45a7ec283affa633536b6212e34fedda8f93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\_ViewImports.cshtml"
using SlideShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\_ViewImports.cshtml"
using SlideShow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2c45a7ec283affa633536b6212e34fedda8f93", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e897ef5e81538d78d70efaf5813d82bf613e176", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SlideShow.Models.Slides>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card"">
    
    <br />
    <div></div>
    <div class=""row"">
        <div class=""col-2"">
            <div style=""float:left""  id=""pause"" >
                <button type=""button"" id=""pause"" onclick=""setPause()"" class=""btn btn-outline-danger"">Pause</button>
            </div>
            
            <div style=""float:left""  id=""play"">
                <button type=""button""  id=""play"" onclick=""setPlay()""class=""btn btn-outline-primary"">Play</button>
            </div>
            
        </div>
        <div class=""col-8"">
            <h2 style=""text-align:center"">Abuni's Slideshow</h2>
            <p style=""text-align:center"">
                <i>Click the pause/play button to pause or play.</i><br />
                <i>Click the sequential/random button to change the mode.</i><br />
                <i>Hovering over the slide show pauses it too.</i><br /> 
            </p>
        </div>
        <div class=""col-2"">
            <div style=""float:right"" id=""sequential"">
         ");
            WriteLiteral(@"       <button type=""button"" id=""sequential"" onclick=""setSequential()"" class=""btn btn-outline-success"">Sequential</button>
            </div>

            <div style=""float:right"" id=""random"">
                <button type=""button"" onclick=""setRandom()"" class=""btn btn-outline-secondary"">Random</button>
            </div>
        </div>
    </div> 
    <br />
    <div id=""carouselExampleControls"" data-interval=""1000"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
");
#nullable restore
#line 41 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml"
             foreach (var item in Model.getImages())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\" >\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1753, "\"", 1781, 1);
#nullable restore
#line 44 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml"
WriteAttributeValue("", 1759, Url.Content(item.Src), 1759, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"max-height: 500px; margin: 0 auto;\" class=\"d-block w-100\">\r\n                    <div class=\"carousel-caption\">\r\n                        <h5> ( ");
#nullable restore
#line 46 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml"
                          Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )  ");
#nullable restore
#line 46 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml"
                                         Write(item.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\abuni\source\repos\SlideShow\SlideShow\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SlideShow.Models.Slides> Html { get; private set; }
    }
}
#pragma warning restore 1591