#pragma checksum "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a13da6a97823271f9a50f8d1c5fbd14aaacee6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminContactUs_Update), @"mvc.1.0.view", @"/Views/AdminContactUs/Update.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a13da6a97823271f9a50f8d1c5fbd14aaacee6", @"/Views/AdminContactUs/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ae501c9594dd0807d3c8f531a8ee631f98fd85", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminContactUs_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmPuanlamaSitesi.Models.Siniflar.ContactUs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"margin-right:750px; margin-top:100px; color:aqua\">\n    <br />\n");
#nullable restore
#line 9 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
     using (Html.BeginForm("UpdateContactUs", "AdminContactUs", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label>ID</label>\n        <br />\n");
#nullable restore
#line 13 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
   Write(Html.TextBoxFor(x => x.ID, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n        <label>Başlık</label>\n        <br />\n");
#nullable restore
#line 17 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n        <label>EMail</label>\n        <br />\n");
#nullable restore
#line 21 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n        <label>Telefon Numarası</label>\n        <br />\n");
#nullable restore
#line 25 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Telefon, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n        <label>Adres</label>\n        <br />\n");
#nullable restore
#line 29 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Adres, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n        <div style=\"margin-top:10px;\">\n            <button class=\"btn btn-primary\">Update Information</button>\n        </div>\n");
#nullable restore
#line 34 "C:\Users\emree\Desktop\Web Programlama\web_programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Update.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmPuanlamaSitesi.Models.Siniflar.ContactUs> Html { get; private set; }
    }
}
#pragma warning restore 1591
