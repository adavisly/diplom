#pragma checksum "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Account\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377a6a67a763957b45b5de656138dccca6b0f262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserProfile), @"mvc.1.0.view", @"/Views/Account/UserProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377a6a67a763957b45b5de656138dccca6b0f262", @"/Views/Account/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458e8edccf0d83bd6204cd4f1b390da15013b10f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicBookReader.Models.User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logout-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/ComicBook/1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comicbook-preview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f2625574", async() => {
                WriteLiteral(@"
    <style>
        .status-nav {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-left: 50px;
    margin-right: 50px;
}

.review-nav, .reading-nav, .read-nav, .wish-nav, .favourite-nav {
    cursor: pointer;
    padding-right: 50px;
    padding-left: 50px;
    padding-top: 10px;
    padding-bottom: 10px;
    border-radius: 10px;
}

.reading-nav {
    background-color: #e8e2a2;
}

    .review-nav:hover, .reading-nav:hover, .read-nav:hover, .wish-nav:hover, .favourite-nav:hover {
        
        color: #aaa;
    }

.review-mark {
    float: right;
    display: flex;
}

.reviews {
    margin-left: 150px;
    margin-right: 150px;
}

.user-logo-review {
    height: 50px;
    width: 50px;
}
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f2627332", async() => {
                WriteLiteral("\r\n    <section class=\"content\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f2627633", async() => {
                    WriteLiteral("Выйти");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"user-info\">\r\n            <img class=\"user-logo\"");
                BeginWriteAttribute("src", " src=\"", 1168, "\"", 1190, 1);
#nullable restore
#line 55 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Account\UserProfile.cshtml"
WriteAttributeValue("", 1174, Model.UserImage, 1174, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div>\r\n                <h5 class=\"user-name\">");
#nullable restore
#line 57 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Account\UserProfile.cshtml"
                                 Write(Model.UserFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 57 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Account\UserProfile.cshtml"
                                                      Write(Model.UserLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                <button type=""button"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"" class=""change-info-btn btn btn-primary"">Изменить информацию</button>
            </div>
        </div>
  
  <!-- Modal -->
  <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h5 class=""modal-title"" id=""exampleModalLabel"">Изменить информацию</h5>
          <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
            
            <input type=""file"" id=""formControlFile"">
            <div class=""info-change"">
                <div>
                    <img class=""user-logo place""");
                BeginWriteAttribute("src", " src=\"", 2162, "\"", 2184, 1);
#nullable restore
#line 75 "F:\GitHub\ComicBookReader-ASP-MVC\ComicBookReader\ComicBookReader\Views\Account\UserProfile.cshtml"
WriteAttributeValue("", 2168, Model.UserImage, 2168, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"info-change\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f26211676", async() => {
                    WriteLiteral(@"
                        <div>
                            <div class=""info-change"">
                                <div class=""form-group"">
                                    <label >Имя</label><br />
                                    <input class=""input-item"" type=""text""  />
                                    <span  />
                                </div>
                                <div class=""form-group"">
                                    <label >Текущий пароль</label><br />
                                    <input class=""input-item""  />
                                    <span />
                                </div>
                            </div>
                            <div class=""info-change"">
                                <div class=""form-group"">
                                    <label >Фамилия</label><br />
                                    <input class=""input-item"" type=""text""  />
                                    <span  />
                      ");
                    WriteLiteral(@"          </div>
                                <div class=""form-group"">
                                    <label >Новый пароль</label><br />
                                    <input class=""input-item"" />
                                    <span />
                                </div>
                            </div>
                            <div class=""info-change"">
                                <div class=""form-group"">
                                    <label >Email</label><br />
                                    <input class=""input-item"" type=""text"" />
                                    <span  />
                                </div>
                                <div class=""form-group"">
                                    <label >Подтвердите пароль</label><br />
                                    <input class=""input-item""  />
                                    <span />
                                </div>
                            </div>
                    ");
                    WriteLiteral("        \r\n                            <div class=\"form-group\">\r\n                                <input class=\"sign-in\" type=\"submit\" value=\"Сохранить\" />\r\n                            </div>\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            
        </div>
      </div>
    </div>
  </div>
    </section>

    <section class=""content"">
        <div class=""status-nav"">
            <a class=""reading-nav"" onclick=""showBlock(1);""><h5>Читаю</h5></a>
            <a class=""read-nav"" onclick=""showBlock(2);""><h5>Прочитано</h5></a>
            <a class=""wish-nav"" onclick=""showBlock(3);""><h5>Хочу прочитать</h5></a>
            <a class=""favourite-nav"" onclick=""showBlock(4);""><h5>Любимое</h5></a>
            <a class=""review-nav"" onclick=""showBlock(5);""><h5>Мои отзывы</h5></a>
        </div>
        <hr />
            <div class=""reading"" style=""display: block;"">
                <div class=""comicbook-previews"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f26216194", async() => {
                    WriteLiteral("\r\n                                <img class=\"img-comicbook\" src=\"/img/ComicBooks/Avatar_The_Promise/cover.jpg\" />\r\n                                <p>Аватар: Легенда об Аанге - Поиск</p>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"read\" style=\"display: none;\">\r\n                <div class=\"comicbook-previews\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f26217829", async() => {
                    WriteLiteral("\r\n                                <img class=\"img-comicbook\" src=\"/img/ComicBooks/Avatar_The_Promise/cover.jpg\" />\r\n                                <p>Аватар: Легенда об Аанге - Поиск2</p>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"wish\" style=\"display: none;\">\r\n                <div class=\"comicbook-previews\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f26219465", async() => {
                    WriteLiteral("\r\n                                <img class=\"img-comicbook\" src=\"/img/ComicBooks/Avatar_The_Promise/cover.jpg\" />\r\n                                <p>Аватар: Легенда об Аанге - Поиск3</p>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"favourite\" style=\"display: none;\">\r\n                <div class=\"comicbook-previews\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377a6a67a763957b45b5de656138dccca6b0f26221106", async() => {
                    WriteLiteral("\r\n                                <img class=\"img-comicbook\" src=\"/img/ComicBooks/Avatar_The_Promise/cover.jpg\" />\r\n                                <p>Аватар: Легенда об Аанге - Поиск4</p>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            <div class=""reviews"" style=""display: none;"">
                <div class=""review"">
                    <div class=""review-mark"">
                        <img class=""star-icon rev-star"" src=""/img/star_icon.png"" />
                        <p class=""rev-star"">5 / 5</p>
                    </div>
                        <p>Название</p>
                    <p class=""review-value"">Отзыв</p>
                </div>
            </div>
    </section>
    ");
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
            WriteLiteral(@"
    <script>

        var reading = document.getElementsByClassName(""reading"")[0];
        var read = document.getElementsByClassName(""read"")[0];
        var wish = document.getElementsByClassName(""wish"")[0];
        var favourite = document.getElementsByClassName(""favourite"")[0];
        var reviews = document.getElementsByClassName(""reviews"")[0];

        var reading_nav = document.getElementsByClassName(""reading-nav"")[0];
        var read_nav = document.getElementsByClassName(""read-nav"")[0];
        var wish_nav = document.getElementsByClassName(""wish-nav"")[0];
        var favourite_nav = document.getElementsByClassName(""favourite-nav"")[0];
        var review_nav = document.getElementsByClassName(""review-nav"")[0];


        var st = 1;
        
        function showBlock(stat) {
            
            if (st == 1) { hideThisBlock(reading, reading_nav);  }
            else if (st == 2) { hideThisBlock(read, read_nav); }
            else if (st == 3) { hideThisBlock(wish, wish_nav); ");
            WriteLiteral(@"}
            else if (st == 4) { hideThisBlock(favourite, favourite_nav); }
            else if (st == 5) { hideThisBlock(reviews, review_nav); }

            if (stat == 1) { 
                showThisBlock(reading, reading_nav); 
            } else if (stat == 2) { 
                showThisBlock(read, read_nav); 
            } else if (stat == 3) { 
                showThisBlock(wish, wish_nav); 
            } else if (stat == 4) { 
                showThisBlock(favourite, favourite_nav); 
            } else if (stat == 5) { 
                showThisBlock(reviews, review_nav); 
            }

            st = stat;
        }
        
        function showThisBlock(thisBlocks, thisBlock_navs) {
            thisBlocks.style.display = ""block"";
            thisBlock_navs.style.backgroundColor = ""#e8e2a2"";
        }

        function hideThisBlock(thisBlockh, thisBlock_navh) {
            thisBlockh.style.display = ""none"";
            thisBlock_navh.style.backgroundColor = ""#fff"";

  ");
            WriteLiteral(@"          /*
            thisBlock_navh.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })

            thisBlock_navh.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            */
        }


    </script>
    
    <script>
        
        /*
        function showReading() {

            reading.style.display = ""block"";
            read.style.display = ""none"";
            wish.style.display = ""none"";
            favourite.style.display = ""none"";
            reviews.style.display = ""none"";

            read_nav.style.backgroundColor = ""#fff"";
            wish_nav.style.backgroundColor = ""#fff"";
            favourite_nav.style.backgroundColor = ""#fff"";
            reviews_nav.style.backgroundColor = ""#fff"";

            read_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            wis");
            WriteLiteral(@"h_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            favourite_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            reviews_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })

            read_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            wish_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            favourite_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            reviews_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })

            reading_nav.style.backgroundColor = ""#e8e2a2"";
        }

   ");
            WriteLiteral(@"     function showRead() {

            reading.style.display = ""none"";
            read.style.display = ""block"";
            wish.style.display = ""none"";
            favourite.style.display = ""none"";
            reviews.style.display = ""none"";

            reading_nav.style.backgroundColor = ""#fff"";
            wish_nav.style.backgroundColor = ""#fff"";
            favourite_nav.style.backgroundColor = ""#fff"";
            reviews_nav.style.backgroundColor = ""#fff"";

            reading_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            wish_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            favourite_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            reviews_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";");
            WriteLiteral(@"
            })

            reading_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            wish_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            favourite_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            reviews_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })

            read_nav.style.backgroundColor = ""#e8e2a2"";
        }

        function showWish() {

            reading.style.display = ""none"";
            read.style.display = ""none"";
            wish.style.display = ""block"";
            favourite.style.display = ""none"";
            reviews.style.display = ""none"";

            read_nav.style.backgroundColor = ""#fff"";
            reading_nav.style.backgroundColor = ""#fff"";
            favourite");
            WriteLiteral(@"_nav.style.backgroundColor = ""#fff"";
            reviews_nav.style.backgroundColor = ""#fff"";

            read_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            reading_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            favourite_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            reviews_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })

            reading_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            read_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            favourite_nav.addEventListener(""mouseout"", function() {
               this.style.ba");
            WriteLiteral(@"ckgroundColor = ""#fff"";
            })
            reviews_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })

            wish_nav.style.backgroundColor = ""#e8e2a2"";
        }

        function showFavourite() {

            reading.style.display = ""none"";
            read.style.display = ""none"";
            wish.style.display = ""none"";
            favourite.style.display = ""block"";
            reviews.style.display = ""none"";

            read_nav.style.backgroundColor = ""#fff"";
            wish_nav.style.backgroundColor = ""#fff"";
            reading_nav.style.backgroundColor = ""#fff"";
            reviews_nav.style.backgroundColor = ""#fff"";

            read_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            wish_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            rea");
            WriteLiteral(@"ding_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            reviews_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })

            reading_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            wish_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            read_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            reviews_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })

            favourite_nav.style.backgroundColor = ""#e8e2a2"";
        }

        function showReviews() {

            reading.style.display = ""none"";
            read.style.display = ""none"";
            wish.st");
            WriteLiteral(@"yle.display = ""none"";
            favourite.style.display = ""none"";
            reviews.style.display = ""block"";

            read_nav.style.backgroundColor = ""#fff"";
            wish_nav.style.backgroundColor = ""#fff"";
            favourite_nav.style.backgroundColor = ""#fff"";
            reading_nav.style.backgroundColor = ""#fff"";

            read_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            wish_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            favourite_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })
            reading_nav.addEventListener(""mouseover"", function() {
               this.style.backgroundColor = ""#e8e2a2"";
            })

            reading_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
  ");
            WriteLiteral(@"          })
            wish_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            favourite_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })
            read_nav.addEventListener(""mouseout"", function() {
               this.style.backgroundColor = ""#fff"";
            })

            reviews_nav.style.backgroundColor = ""#e8e2a2"";
        }
        */
    </script>
   
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComicBookReader.Models.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
