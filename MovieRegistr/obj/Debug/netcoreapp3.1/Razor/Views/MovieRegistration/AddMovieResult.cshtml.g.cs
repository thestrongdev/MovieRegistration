#pragma checksum "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5090fcae94a5754d037df28a42ab475f5ce8377b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieRegistration_AddMovieResult), @"mvc.1.0.view", @"/Views/MovieRegistration/AddMovieResult.cshtml")]
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
#line 1 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\_ViewImports.cshtml"
using MovieRegistr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\_ViewImports.cshtml"
using MovieRegistr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5090fcae94a5754d037df28a42ab475f5ce8377b", @"/Views/MovieRegistration/AddMovieResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c929da22d47826eab053fcd157c082e0fccdb617", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieRegistration_AddMovieResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieRegistr.Models.AddMovieResultViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovieRegistration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMovieForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
     foreach (var movie in Model.Movies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"list-group-item\">\r\n\r\n        <p>Movie ");
#nullable restore
#line 14 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
            Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered</p>\r\n\r\n        <p>ID: ");
#nullable restore
#line 16 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
          Write(movie.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Title: ");
#nullable restore
#line 17 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
             Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Genre: ");
#nullable restore
#line 18 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
             Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Year: ");
#nullable restore
#line 19 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
            Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Actors: ");
#nullable restore
#line 20 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
              Write(movie.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Directors: ");
#nullable restore
#line 21 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
                 Write(movie.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5090fcae94a5754d037df28a42ab475f5ce8377b6111", async() => {
                WriteLiteral("Add Another Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </li>\r\n");
#nullable restore
#line 26 "C:\Users\goods\source\repos\MovieRegistr\MovieRegistr\Views\MovieRegistration\AddMovieResult.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieRegistr.Models.AddMovieResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
