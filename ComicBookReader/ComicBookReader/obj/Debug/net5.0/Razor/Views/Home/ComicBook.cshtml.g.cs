#pragma checksum "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdd85c153512662450b6a4568f2e0b62825647d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ComicBook), @"mvc.1.0.view", @"/Views/Home/ComicBook.cshtml")]
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
#line 1 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\_ViewImports.cshtml"
using ComicBookReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\_ViewImports.cshtml"
using ComicBookReader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdd85c153512662450b6a4568f2e0b62825647d", @"/Views/Home/ComicBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458e8edccf0d83bd6204cd4f1b390da15013b10f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ComicBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicBookReader.Models.ComicBook>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chapter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd85c153512662450b6a4568f2e0b62825647d3843", async() => {
                WriteLiteral(@"
    <section class=""content comicbook-page"">
        <div class=""cb-info-user"">
            <div class=""cb-info cbuser-info"">
                <img class=""star-icon rev-star"" src=""/img/star_icon.png"" />
                <h5 class=""rev-star"">4.7 / 5</h5>
                <p class=""rev-count"">27</p>
            </div>
            <div><a class=""review-btn"">Добавить в любимые</a></div>
            <div><a class=""review-btn col change-info-btn btn btn-primary"" type=""button"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">Оставить отзыв</a></div>
            <div class = ""cb-status"">
                <select>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd85c153512662450b6a4568f2e0b62825647d4771", async() => {
                    WriteLiteral("Добавить в список");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd85c153512662450b6a4568f2e0b62825647d5816", async() => {
                    WriteLiteral("Хочу прочитать");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd85c153512662450b6a4568f2e0b62825647d6858", async() => {
                    WriteLiteral("Читаю");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd85c153512662450b6a4568f2e0b62825647d7891", async() => {
                    WriteLiteral("Прочитано");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n        </div>\r\n        <div class=\"cb-info\">\r\n            <img class=\"cover-img\"");
                BeginWriteAttribute("src", " src=\"", 1012, "\"", 1039, 1);
#nullable restore
#line 25 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
WriteAttributeValue("", 1018, Model.ComicBookCover, 1018, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"cb-info-text\">\r\n                <h5>");
#nullable restore
#line 27 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
               Write(Model.ComicBookTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                <p class=\"cb-info-item\">Год выхода: ");
#nullable restore
#line 28 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                                               Write(Model.ComicBookYear);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                <p class=\"cb-info-item\">Язык: ");
#nullable restore
#line 29 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                                         Write(Model.ComicBookLanguage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p class=\"cb-info-item\">Авторы: \r\n");
#nullable restore
#line 31 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                     foreach (var author in @Model.Authors)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a>");
#nullable restore
#line 33 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                      Write(author.AuthorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 34 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </p>\r\n                <p class=\"cb-info-item\">Жанры: \r\n");
#nullable restore
#line 37 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                     foreach (var genre in @Model.Genres)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a>");
#nullable restore
#line 39 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                      Write(genre.GenreName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 40 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </p>\r\n                <p class=\"cb-info-item\">Описание: ");
#nullable restore
#line 42 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                                             Write(Model.ComicBookDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
            </div>
        </div>

          <!-- Modal -->
  <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h5 class=""modal-title"" id=""exampleModalLabel"">Оставить отзыв</h5>
          <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
            <div class=""info-change"">
                <div>
                        <div class=""img-username"">
                                <p>Ваша оценка:</p>
                                <a href=""#""><img class=""star-icon rev-star currev"" src=""/img/star_icon.png"" /></a>
                                <a href=""#""><img class=""star-icon rev-star currev"" src=""/img/star_icon.png"" /></a>
                                <a href=""#""><img class=""star-icon rev-star currev"" src=""/img/sta");
                WriteLiteral(@"r_icon.png"" /></a>
                                <a href=""#""><img class=""star-icon rev-star currev"" src=""/img/star_icon.png"" /></a>
                                <a href=""#""><img class=""star-icon rev-star currev"" src=""/img/star_icon.png"" /></a>
                        </div>
                        <textarea class=""review-input""></textarea>
                            <div class=""form-group"">
                                <input class=""sign-in"" type=""submit"" value=""Отправить"" />
                            </div>
                        </div>
                </div>
            </div>
      </div>
    </div>
    </div>
    </section>
    <section class=""content"">
        <div class=""chapters-reviews"">
            <a class=""ch"" onclick=""showChapters()""><h5>Главы</h5></a>
            <a class=""rev"" onclick=""showReviews()""><h5>Отзывы</h5></a>
        </div>
        <hr />
            <div class=""chapters"">
");
#nullable restore
#line 83 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
             for (int i = 0; i < @Model.Chapters.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd85c153512662450b6a4568f2e0b62825647d15001", async() => {
                    WriteLiteral("<h5>");
#nullable restore
#line 85 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
                                                                                                    Write(Model.Chapters.ElementAt(i).ChapterName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h5>");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3891, "~/Home/ComicChapter/", 3891, 20, true);
#nullable restore
#line 85 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
AddHtmlAttributeValue("", 3911, Model.Chapters.ElementAt(i).ChapterId, 3911, 38, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <hr />\r\n");
#nullable restore
#line 87 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Home\ComicBook.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                
            </div>
            <div class=""reviews"">
                <div class=""review"">
                    <div class=""review-mark"">
                        <img class=""star-icon rev-star"" src=""/img/star_icon.png"" />
                        <p class=""rev-star"">5 / 5</p>
                    </div>
                    <div class=""img-username"">
                        <img class=""user-logo-review"" src=""/img/user_logo.png"" />
                        <p>Username</p>
                    </div>
                    <p class=""review-value"">Отзыв</p>
                </div>
            </div>
    </section>

    <script defer src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js""></script>
    <script src=""js/home.js""></script>
    <script>

        var");
                WriteLiteral(@" reviews = document.getElementsByClassName(""reviews"");
        var chapters = document.getElementsByClassName(""chapters"");

        var rev = document.getElementsByClassName(""rev"");
        var ch = document.getElementsByClassName(""ch"");
        

        function showReviews() {

            chapters[0].style.display = ""none"";
            ch[0].style.backgroundColor = ""#fff"";

            ch[0].addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })

            reviews[0].style.display = ""block"";
            rev[0].style.backgroundColor = ""#e8e2a2"";
        }

        function showChapters() {
          
            chapters[0].style.display = ""block"";
            ch[0].style.backgroundColor = ""#e8e2a2"";

            reviews[0].style.display = ""none"";
            rev[0].style.backgroundColor = ""#fff"";

            rev[0].addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
    ");
                WriteLiteral("        })\r\n        } \r\n    </script>\r\n");
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
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComicBookReader.Models.ComicBook> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
