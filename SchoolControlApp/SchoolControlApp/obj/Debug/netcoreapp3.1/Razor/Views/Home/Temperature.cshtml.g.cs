#pragma checksum "C:\Users\user\source\repos\SchoolControlApp\SchoolControlApp\Views\Home\Temperature.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d76ef463e00feb515dd738e1490e7de36a0f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Temperature), @"mvc.1.0.view", @"/Views/Home/Temperature.cshtml")]
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
#line 1 "C:\Users\user\source\repos\SchoolControlApp\SchoolControlApp\Views\_ViewImports.cshtml"
using SchoolFaceControllApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\SchoolControlApp\SchoolControlApp\Views\_ViewImports.cshtml"
using SchoolFaceControllApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d76ef463e00feb515dd738e1490e7de36a0f38", @"/Views/Home/Temperature.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f5b943be11f8f477c9ef718eecd5c082b22f79", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Temperature : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "TIP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "KORPUS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "TƏHSİL BAZASI", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "TƏHSİL SƏVİYYƏSİ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "TƏHSİL MÜDDƏTİ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "HƏRARƏT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f385038", async() => {
                WriteLiteral(@"





    <!-- header section starts  -->
    <div class=""topbar "">
        <div class=""logo"">
            T.S.X.B.D.P.T
        </div>
        <div class=""user-info"">
            <a href=""#"" class=""set-drop"">
                user@gmail.com <img class=""drop"" src=""./icons/drop.svg""");
                BeginWriteAttribute("alt", " alt=\"", 300, "\"", 306, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <ul class=""setting-dropdown"" id=""set-dropdown"">
                    <li><a href=""/settings.html"">Profil ayarları</a></li>
                    <li><a href=""/settings.html"">Cıxış</a></li>
                </ul>
            </a>

        </div>
    </div>

    <header>
        <div class=""homepage"">
            <div class=""d-flex align-center top"">
                <a href=""./dashboard.html"" class=""d-flex align-center white"">
                    <img src=""./icons/homee.svg""");
                BeginWriteAttribute("alt", " alt=\"", 812, "\"", 818, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <p>ANA SƏHİFƏ</p>
                </a>
            </div>
        </div>

        <nav class=""navbar"">
            <ul>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/user.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 1133, "\"", 1139, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">İŞCİLƏR </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 1289, "\"", 1295, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu1"" id=""sub-dropdown"">
                        <li><a href=""#"">Müəllimlər</a></li>
                        <li><a href=""#"">Muhafizəcilər</a></li>
                        <li><a href=""#"">Aşbazlar</a></li>
                        <li><a href=""#"">Xadiməcilər</a></li>
                        <li><a href=""#"">Gecikənlər</a></li>
                        <li><a href=""#"">Hərarəti yüksək olanlar</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/students.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 2010, "\"", 2016, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">ŞAGİRDLƏR </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2168, "\"", 2174, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu2"" id=""sub-dropdown"">
                        <li><a href=""#"">Bütün şagirdlər</a></li>
                        <li><a href=""#"">Gecikənlər</a></li>
                        <li><a href=""#"">Qayıb limitini aşanlar</a></li>
                        <li><a href=""#"">Hərarəti yüksək olanlar</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/ixtisas.png"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 2781, "\"", 2787, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">IXTISAS </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 2937, "\"", 2943, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu3"" id=""sub-dropdown"">
                        <li><a href=""#"">Bütün ixtisaslar</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/corpus.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 3342, "\"", 3348, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">KORPUS </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3497, "\"", 3503, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu4"" id=""sub-dropdown"">
                        <li><a href=""#"">5 № Korpus</a></li>
                        <li><a href=""#"">2 № Korpus</a></li>
                        <li><a href=""#"">1 № Korpus</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/course.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 4018, "\"", 4024, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">KURS </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4171, "\"", 4177, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu5"" id=""sub-dropdown"">
                        <li><a href=""#"">1 Kurs</a></li>
                        <li><a href=""#"">2 Kurs</a></li>
                        <li><a href=""#"">3 Kurs</a></li>
                        <li><a href=""#"">4 Kurs</a></li>
                        <li><a href=""#"">1 il</a></li>
                        <li><a href=""#"">6 ay</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/data.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 4845, "\"", 4851, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">TƏHSİL BAZASI </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 5007, "\"", 5013, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu6"" id=""sub-dropdown"">
                        <li><a href=""#"">Ümumi orta </a></li>
                        <li><a href=""#"">Tam orta</a></li>

                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/time.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 5466, "\"", 5472, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">TƏHSİL MÜDDƏTİ </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 5629, "\"", 5635, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu7"" id=""sub-dropdown"">
                        <li><a href=""#"">1 il</a></li>
                        <li><a href=""#"">2 il</a></li>
                        <li><a href=""#"">3 il</a></li>
                        <li><a href=""#"">4 il</a></li>
                        <li><a href=""#"">6 ay</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/level.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 6241, "\"", 6247, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">TƏHSİL SƏVİYYƏSİ </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 6406, "\"", 6412, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu8"" id=""sub-dropdown"">
                        <li><a href=""#"">İlk peşə</a></li>
                        <li><a href=""#"">Texniki peşə</a></li>
                        <li><a href=""#"">Yüksək texniki peşə</a></li>
                    </ul>
                </li>
                <li class=""item-list"">
                    <div class=""d-flex align-center"">
                        <img src=""./icons/payment.svg"" class=""icon-list""");
                BeginWriteAttribute("alt", " alt=\"", 6937, "\"", 6943, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <a href=\"./teachers.html\">TƏHSİL ÖDƏNİŞİ </a>\r\n                        <img class=\"drop\" id=\"down-arrow\" src=\"./icons/drop.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 7100, "\"", 7106, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <ul class=""dashboard-dropdown-menu menu9"" id=""sub-dropdown"">
                        <li><a href=""#"">Dövlət hesabına</a></li>
                        <li><a href=""#"">Ödənişli əsaslarla</a></li>

                    </ul>
                </li>
            </ul>
        </nav>



    </header>

    <!-- header section ends -->
    <!-- home section starts  -->

    <section class=""home"" id=""home"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""form-container"">
                    <div class=""search"">
                        <input type=""text"" placeholder=""AXTAR..."">
                    </div>
                    <div class=""select"">
                        <select>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3816411", async() => {
                    WriteLiteral("TIP");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"select\">\r\n                        <select>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3817809", async() => {
                    WriteLiteral("KORPUS");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"select\">\r\n                        <select>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3819210", async() => {
                    WriteLiteral("KURS");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"select\">\r\n                        <select>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3820609", async() => {
                    WriteLiteral("GRUP №");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"select\">\r\n                        <select>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3822010", async() => {
                    WriteLiteral("IXTISAS KODU");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"download\">\r\n                        <div class=\"download-img\">\r\n                            <button> <img src=\"./icons/download.png\"");
                BeginWriteAttribute("alt", " alt=\"", 9009, "\"", 9015, 0);
                EndWriteAttribute();
                WriteLiteral("></button>\r\n                        </div>\r\n                        <div class=\"print-img\">\r\n                            <button> <img src=\"./icons/print.png\"");
                BeginWriteAttribute("alt", " alt=\"", 9174, "\"", 9180, 0);
                EndWriteAttribute();
                WriteLiteral(@"></button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row mt-1"">
                <div class=""col-12"">
                    <div class=""form-container"">

                        <div class=""search"">
                            <input type=""date"" placeholder=""AXTAR..."">
                        </div>
                        <div class=""select"">
                            <select>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3824472", async() => {
                    WriteLiteral("TƏHSİL BAZASI");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"select\">\r\n                            <select>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3825900", async() => {
                    WriteLiteral("TƏHSİL SƏVİYYƏSİ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"select\">\r\n                            <select>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3827331", async() => {
                    WriteLiteral("TƏHSİL MÜDDƏTİ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"select\">\r\n                            <select>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3828760", async() => {
                    WriteLiteral("TƏHSİL MÜDDƏTİ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"select\">\r\n                            <select>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d76ef463e00feb515dd738e1490e7de36a0f3830189", async() => {
                    WriteLiteral("HƏRARƏT");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""select"">
                            <div class=""edit-late"">
                                <button class=""edit-btn"">DÜZƏLİŞ ET</button>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <!-- dynamic table start -->
        <div class=""row mt-4"">
            <div class=""col-12"">
                <table>
                    <thead>
                        <tr>
                            <th>İD</th>
                            <th>AD</th>
                            <th>SOYAD</th>
                            <th>ATA ADI</th>
                            <th>TİP</th>
                            <th>KORPUS</th>
                            <th>KURS</th>
                            <th>GRUP №</th>
                            <th>QAYIB LİMİTİNİ</th>
                          ");
                WriteLiteral(@"  <th>İXTİSAS KODU</th>
                            <th>TƏHSİL BAZASI</th>
                            <th>TƏHSİL SƏVİYYƏSİ</th>
                            <th>TƏHSİL MÜDDƏTİ</th>
                            <th>TƏHSİL ÖDƏNİŞİ</th>
                            <th>STATUS</th>

                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th>1</th>
                            <td>Agshin</td>
                            <td>Poladlı</td>
                            <td>Səməndar</td>
                            <td>Şagird</td>
                            <td>1</td>
                            <td>2</td>
                            <td>123</td>
                            <td class=""danger"">AŞIB</td>
                            <td>43532</td>
                            <td>Ümumi orta təhsil</td>
                            <td>Texniki peşə</td>
                            <td>1 il</td>
                      ");
                WriteLiteral(@"      <td>Dövlət hesabına</td>
                            <td>AKTİVDİR</td>
                        </tr>
                        <tr>
                            <th>1</th>
                            <td>Agshin</td>
                            <td>Poladlı</td>
                            <td>Səməndar</td>
                            <td>Şagird</td>
                            <td>1</td>
                            <td>2</td>
                            <td>123</td>
                            <td class=""danger"">AŞIB</td>
                            <td>43532</td>
                            <td>Ümumi orta təhsil</td>
                            <td>Texniki peşə</td>
                            <td>1 il</td>
                            <td>Dövlət hesabına</td>
                            <td>AKTİVDİR</td>
                        </tr>
                        <tr>
                            <th>1</th>
                            <td>Agshin</td>
                            <td>Poladlı<");
                WriteLiteral(@"/td>
                            <td>Səməndar</td>
                            <td>Şagird</td>
                            <td>1</td>
                            <td>2</td>
                            <td>123</td>
                            <td class=""danger"">AŞIB</td>
                            <td>43532</td>
                            <td>Ümumi orta təhsil</td>
                            <td>Texniki peşə</td>
                            <td>1 il</td>
                            <td>Dövlət hesabına</td>
                            <td>AKTİVDİR</td>
                        </tr>
                        <tr>
                            <th>1</th>
                            <td>Agshin</td>
                            <td>Poladlı</td>
                            <td>Səməndar</td>
                            <td>Şagird</td>
                            <td>1</td>
                            <td>2</td>
                            <td>123</td>
                            <td class=""danger");
                WriteLiteral(@""">AŞIB</td>
                            <td>43532</td>
                            <td>Ümumi orta təhsil</td>
                            <td>Texniki peşə</td>
                            <td>1 il</td>
                            <td>Dövlət hesabına</td>
                            <td>AKTİVDİR</td>
                        </tr>
                        <tr>
                            <th>1</th>
                            <td>Agshin</td>
                            <td>Poladlı</td>
                            <td>Səməndar</td>
                            <td>Şagird</td>
                            <td>1</td>
                            <td>2</td>
                            <td>123</td>
                            <td class=""danger"">AŞIB</td>
                            <td>43532</td>
                            <td>Ümumi orta təhsil</td>
                            <td>Texniki peşə</td>
                            <td>1 il</td>
                            <td>Dövlət hesabına</td>
    ");
                WriteLiteral(@"                        <td>AKTİVDİR</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <!-- dynamic table start -->
    </section>



    <!-- custom js file link  -->
    <script src=""app.js""></script>

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