#pragma checksum "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11165059b2ba2d3dbfba27a4c7f1e908b16ee7d1"
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
#line 1 "C:\Users\Сергей\Downloads\MVC_application-main\Views\_ViewImports.cshtml"
using FirstWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Сергей\Downloads\MVC_application-main\Views\_ViewImports.cshtml"
using FirstWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11165059b2ba2d3dbfba27a4c7f1e908b16ee7d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e1c8f2250685b405a9888685baa4b2eba8efec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Страница приветствия";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Добрый день, пользователь!</h1>\n\n    <p>Этот ресурс создан для тестирования новой системы авторизации</a>.</p>\n    <h2 class=\"display-3\">Войти в личный кабинет</h2>\n\n\n");
#nullable restore
#line 12 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
     using (Html.BeginForm("Login", "Home", null, FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
   Write(Html.LabelFor(x => Model.login));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
   Write(Html.EditorFor(x => Model.login));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
   Write(Html.LabelFor(x => Model.password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
   Write(Html.EditorFor(x => Model.password, new { type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Авторизоваться\">\n");
#nullable restore
#line 19 "C:\Users\Сергей\Downloads\MVC_application-main\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
