#pragma checksum "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27624068c05d89d6477cf16514104edc88c7530a"
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
#line 1 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\_ViewImports.cshtml"
using Beryllium_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\_ViewImports.cshtml"
using Beryllium_Back_End.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27624068c05d89d6477cf16514104edc88c7530a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a76fdc89cc3f25ba6b7ed9058345c7a715752506", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section id=\"slider\">\r\n        <div class=\"container\">\r\n            <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-bs-ride=\"carousel\">\r\n                <div class=\"carousel-indicators\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                      
                        var indicator = 0;
                        var slayd = 0;

                        foreach (Slider sliders in Model.Sliders)
                        {
                            slayd++;
                            var itemIndicator = indicator++ == 0 ? "active" : "";


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type = \"button\" data-bs-target = \"#carouselExampleIndicators\" data-bs-slide-to = \"");
#nullable restore
#line 21 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                                                                                                                  Write(indicator -1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 737, "\"", 759, 1);
#nullable restore
#line 21 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
WriteAttributeValue("", 745, itemIndicator, 745, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-current=\"true\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 780, "\"", 805, 2);
            WriteAttributeValue("", 793, "Slide", 793, 5, true);
#nullable restore
#line 21 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 798, slayd, 799, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n");
#nullable restore
#line 22 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 26 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                      
                        var i = 0;

                        foreach (Slider slider in Model.Sliders)
                        {
                            var itemClass = i++ == 0 ? "carousel-item active" : "carousel-item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1223, "\"", 1241, 1);
#nullable restore
#line 32 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
WriteAttributeValue("", 1231, itemClass, 1231, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1281, "\"", 1321, 2);
            WriteAttributeValue("", 1287, "/assets/Image/Slider/", 1287, 21, true);
#nullable restore
#line 33 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
WriteAttributeValue("", 1308, slider.Image, 1308, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\" alt=\"...\">\r\n                            </div>\r\n");
#nullable restore
#line 35 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
        </div>
    </section>
    <section id=""carousel"">
        <div class=""container"">
            <div class=""row"">
                <div class=""title text-center mt-5 col-md-12 col-sm-12 col-12"">
                    <h1>");
#nullable restore
#line 53 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                   Write(layoutservice.GetDatas().Result.FirstOrDefault(i => i.Key == "CarouselTitle").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"w-75 text-center\">");
#nullable restore
#line 54 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                                           Write(layoutservice.GetDatas().Result.FirstOrDefault(i => i.Key == "CarouselSubTitle").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"owl-carousel owl-theme mt-3\">\r\n");
#nullable restore
#line 57 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                     foreach (Carousel carousel in Model.Carousels)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2826, "\"", 2870, 2);
            WriteAttributeValue("", 2832, "/assets/Image/Carousel/", 2832, 23, true);
#nullable restore
#line 60 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
WriteAttributeValue("", 2855, carousel.Image, 2855, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2871, "\"", 2877, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h4 class=\"mt-3\">");
#nullable restore
#line 61 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                                        Write(carousel.Lacation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 62 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                          Write(carousel.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 64 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </section>
    <section id=""news-section"" class=""py-5"">
        <div class=""container mt-5"">
            <div class=""row"">
                <div class=""news col-lg-6 col-md-12 col-sm-12"">
                    <strong>News</strong>
");
#nullable restore
#line 74 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                     foreach (News news in Model.News)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"news-today\">\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 3518, "\"", 3525, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"date\">");
#nullable restore
#line 77 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                                                  Write(news.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 3594, "\"", 3601, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                                      Write(news.TitleNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h4>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 3663, "\"", 3670, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                                     Write(news.DescriptionNews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""testimonial col-lg-6 col-md-12 col-sm-12"">
                    <div class=""testimanials"">
                        <strong>Testimonials</strong>
                        <p class=""comment"">“Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.“</p>
                        <p>— John Doe Dueller</p>
                    </div>
                    <div class=""testimanials mt-5"">
                        <p class=""comment"">“Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod erat tincidunt. Donec tincidunt volutpat erat.“</p>
                        <p>— John Doe Dueller</p>
                    </div>
                </div>
                <div class=""btn btn-secondary mt-5 button col-7 col-lg-3"">MORE NEWS</div>
            </div>
        </div>
    </section>
    <section id=""archit");
            WriteLiteral("ect\" class=\"py-5\">\r\n        <div class=\"container mt-4\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 101 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                 foreach (Work work in Model.Works)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"box col-lg-4 d-flex justify-content-between\">\r\n                        <div class=\"icon\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 5096, "\"", 5118, 1);
#nullable restore
#line 105 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
WriteAttributeValue("", 5104, work.WorkIcon, 5104, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        </div>\r\n                        <div class=\"text ms-4\">\r\n                            <strong>");
#nullable restore
#line 108 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                               Write(work.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <p>");
#nullable restore
#line 109 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                          Write(work.WorkDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5356, "\"", 5363, 0);
            EndWriteAttribute();
            WriteLiteral(">Lean More</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 113 "C:\Users\M S I\source\repos\Beryllium Back-End\Beryllium Back-End\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n\r\n\r\n<button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"0\" class=\"active\" aria-current=\"true\" aria-label=\"Slide 1\"></button>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Beryllium_Back_End.Service.LayoutService layoutservice { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
