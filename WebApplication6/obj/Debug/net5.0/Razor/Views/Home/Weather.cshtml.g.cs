#pragma checksum "C:\Users\yazilim.park10\source\repos\WebApplication6\WebApplication6\Views\Home\Weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca5e2ecca7fb043541e4b87ca49261bea4b23f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Weather), @"mvc.1.0.view", @"/Views/Home/Weather.cshtml")]
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
#line 1 "C:\Users\yazilim.park10\source\repos\WebApplication6\WebApplication6\Views\_ViewImports.cshtml"
using WebApplication6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yazilim.park10\source\repos\WebApplication6\WebApplication6\Views\_ViewImports.cshtml"
using WebApplication6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca5e2ecca7fb043541e4b87ca49261bea4b23f8", @"/Views/Home/Weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865b2ca0dedbd6d16882aa8f14a3148527d098b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Weather : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/weather.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/weather.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca5e2ecca7fb043541e4b87ca49261bea4b23f84530", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>JS Weather App</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ca5e2ecca7fb043541e4b87ca49261bea4b23f85008", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/1b4be7268f.js\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca5e2ecca7fb043541e4b87ca49261bea4b23f86996", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""app"">
            <div class=""header"">
                <h1>Weather App</h1>
                <input type=""text"" id=""searchBar"" placeholder=""Enter a city..."">
            </div>
            <div class=""content"">
                <div class=""city"">Istanbul, TR</div>
                <div class=""temp"">15°C</div>
                <div class=""weather-icon"">
                    <img class=""img"" id=""main-img"" src=""http://openweathermap.org/img/wn/10d@2x.png"" width=""45%""");
                BeginWriteAttribute("alt", " alt=\"", 932, "\"", 938, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""desc"">Gunesli</div>
                </div>

                <div class=""content-info"">

                    <div class=""feels"">15°C</div>
                    <div class=""humidity"">19</div>
                </div>

            </div>
        </div>
        <div class=""content-city"">
            <div class=""popular-city"" id=""london"">
                <h2>London | GB</h2>
                <hr>
                <div class=""popTemp"" id=""london-temp"">15°C</div>
                <div class=""weather-icon"">
                    <img id=""london-img"" src=""http://openweathermap.org/img/wn/10d@2x.png"" width=""38%""");
                BeginWriteAttribute("alt", " alt=\"", 1592, "\"", 1598, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""popDesc"" id=""london-desc"">Gunesli</div>
                </div>
                <div class=""infos"">
                    <div id=""london-humidity""><i class=""fas fa-tint fa-fw""></i></div>
                    <div id=""london-wind""><i class=""fas fa-wind fa-fw""></i></div>
                </div>
            </div>
            <div class=""popular-city"" id=""istanbul"">
                <h2>Istanbul | TR</h2>
                <hr>
                <div class=""popTemp"" id=""istanbul-temp"">15°C</div>
                <div class=""weather-icon"">
                    <img id=""ist-img"" src=""http://openweathermap.org/img/wn/10d@2x.png"" width=""38%""");
                BeginWriteAttribute("alt", " alt=\"", 2277, "\"", 2283, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""popDesc"" id=""ist-desc"">Gunesli</div>
                </div>
                <div class=""infos"">
                    <div id=""ist-humidity""><i class=""fas fa-tint fa-fw""></i></div>
                    <div id=""ist-wind""><i class=""fas fa-wind fa-fw""></i></div>
                </div>
            </div>
            <div class=""popular-city"" id=""newyork"">
                <h2>New York | US</h2>
                <hr>
                <div class=""popTemp"" id=""ny-temp"">15°C</div>
                <div class=""weather-icon"">
                    <img id=""ny-img"" src=""http://openweathermap.org/img/wn/10d@2x.png"" width=""38%""");
                BeginWriteAttribute("alt", " alt=\"", 2945, "\"", 2951, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""popDesc"" id=""ny-desc"">Gunesli</div>
                </div>
                <div class=""infos"">
                    <div id=""ny-humidity""><i class=""fas fa-tint fa-fw""></i></div>
                    <div id=""ny-wind""><i class=""fas fa-wind fa-fw""></i></div>
                </div>
            </div>
            <div class=""popular-city"" id=""berlin"">
                <h2>Berlin | DE</h2>
                <hr>
                <div class=""popTemp"" id=""berlin-temp"">15°C</div>
                <div class=""weather-icon"">
                    <img id=""berlin-img"" src=""http://openweathermap.org/img/wn/10d@2x.png"" width=""38%""");
                BeginWriteAttribute("alt", " alt=\"", 3615, "\"", 3621, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""popDesc"" id=""berlin-desc"">Gunesli</div>
                </div>
                <div class=""infos"">
                    <div id=""berlin-humidity""><i class=""fas fa-tint fa-fw""></i></div>
                    <div id=""berlin-wind""><i class=""fas fa-wind fa-fw""></i></div>
                </div>
            </div>
        </div>
    </div>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca5e2ecca7fb043541e4b87ca49261bea4b23f811723", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
