#pragma checksum "D:\Projeler\CoreBlog\CoreBlog\Views\Shared\FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210467d0be7bfd5d5f367d6a2f5f12d983d5dbc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FooterPartial), @"mvc.1.0.view", @"/Views/Shared/FooterPartial.cshtml")]
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
#line 1 "D:\Projeler\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeler\CoreBlog\CoreBlog\Views\_ViewImports.cshtml"
using CoreBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210467d0be7bfd5d5f367d6a2f5f12d983d5dbc7", @"/Views/Shared/FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beebd3fcfe81dd21734633461d6f42f4f9027d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkımızda</h3>
                <p>Blog (Türkçe: ağ günlüğü, günce) veya Weblog (Türkçe: Ağ kütüğü) teknik bilgi gerektirmeden, kendi istedikleri şeyleri, kendi istedikleri şekilde yazan insanların oluşturabildikleri, günlüğe benzeyen web siteleridir. Genellikle güncelden eskiye doğru sıralanmış yazı ve yorumların yayınlandığı, web tabanlı bir yayını belirtir...</p>
                <div class=""read"">
                    <a href=""/About/Index"" class=""btn btn-primary read-m"">Devamını Oku</a>
                </div>
            </div>
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                ");
#nullable restore
#line 12 "D:\Projeler\CoreBlog\CoreBlog\Views\Shared\FooterPartial.cshtml"
           Write(await Component.InvokeAsync("BlogLast3Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left\">\r\n                ");
#nullable restore
#line 15 "D:\Projeler\CoreBlog\CoreBlog\Views\Shared\FooterPartial.cshtml"
           Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
                                <span>Google+</span>
                            </a>
        ");
            WriteLiteral(@"                </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-pinterest-p""></i>
                                <span>Pinterest</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
#nullable restore
#line 52 "D:\Projeler\CoreBlog\CoreBlog\Views\Shared\FooterPartial.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Weblog. All Rights Reserved | Design by\r\n                    <a href=\"http://w3layouts.com/\">W3layouts</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>");
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
