#pragma checksum "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa60753dd80a20aee31adea1d7f04fe4144f2cd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_ShowPage), @"mvc.1.0.view", @"/Views/Pages/ShowPage.cshtml")]
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
#line 1 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\_ViewImports.cshtml"
using MyCMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\_ViewImports.cshtml"
using MyCMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
using DataLayer.Convertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
using DataLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa60753dd80a20aee31adea1d7f04fe4144f2cd6", @"/Views/Pages/ShowPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11be028b993dfd6765bf292c464bf3a71a49565d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_ShowPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataLayer.Models.Page>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\"><a href=\"/\">خانه </a></li>\r\n    <li class=\"breadcrumb-item\"><a href=\"#\">اخبار </a></li>\r\n    <li class=\"breadcrumb-item\">");
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item active\">");
#nullable restore
#line 13 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n</ul>\r\n\r\n<section class=\"single-news border-radius\">\r\n    <header>\r\n        <h2>\r\n            ");
#nullable restore
#line 19 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n        <span> <i class=\"fa fa-calendar\"></i> انتشار : ");
#nullable restore
#line 21 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
                                                  Write(Model.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </header>\r\n    <article>\r\n        <img class=\"img-thumbnail\" style=\"width: 100%;margin: 0 0 30px 0\"");
            BeginWriteAttribute("src", " src=\"", 744, "\"", 770, 2);
            WriteAttributeValue("", 750, "/images/", 750, 8, true);
#nullable restore
#line 24 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
WriteAttributeValue("", 758, Model.Image, 758, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 771, "\"", 789, 1);
#nullable restore
#line 24 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
WriteAttributeValue("", 777, Model.Image, 777, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <p class=\"badge\" style=\"background: #666EE8; color: #ffffff;border-radius: 3px\">\r\n            <span> تعداد بازدید</span>\r\n            ");
#nullable restore
#line 27 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
       Write(Model.Visit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa60753dd80a20aee31adea1d7f04fe4144f2cd66022", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 30 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ShortDescription);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 32 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <hr />\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa60753dd80a20aee31adea1d7f04fe4144f2cd67767", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 36 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 38 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
       Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </article>\r\n</section>\r\n\r\n<div class=\"keywords border-radius\">\r\n");
#nullable restore
#line 44 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
     foreach (var item in Model.Tags.Split('-'))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1372, "\"", 1379, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 46 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 47 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<section class=\"comment-layer\">\r\n    <header> <i class=\"fa fa-comments\"></i><h5> دیدگاه کاربران </h5><span> 25 دیدگاه </span> </header>\r\n    <ul id=\"lstComment\">\r\n    </ul>\r\n\r\n\r\n\r\n");
#nullable restore
#line 58 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h6> شما هم دیدگاه خود را ارسال کنید </h6>
        <div class=""comment-form"">
            <div>
                <input id=""name"" placeholder="" نام و نام خانوادگی"" required=""true"" type=""text"">
                <input id=""email"" placeholder="" ایمیل خود را وارد نمایید "" required=""true"" type=""email"">
                <input id=""website"" placeholder="" سایت خود را وارد نمایید "" type=""url"">
            </div>
            <textarea id=""comment"" placeholder="" متن دیدگاه""> </textarea>
            <button class=""btn btn-block btn-success"" onclick=""btnSave()"">
                ثبت دیدگاه ارزشمند شما
            </button>
        </div>
");
#nullable restore
#line 72 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert comment-form alert-warning\">\r\n            <h1>برای نظر دادن ابتدا وارد سایت شوید</h1>\r\n        </div>\r\n");
#nullable restore
#line 78 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $.getJSON(\"/Comment/GetAllComments?id=");
#nullable restore
#line 84 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
                                         Write(Model.PageId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
            (res) => {
                $.each(res,
                    (key, val) => {
                        var item = '<li>' +
                            '<img src=""/images/thumb.png"">' +
                            '<div>' +
                            '<span> ' +
                            val.name +
                            ' </span>' +
                            ' <span> ' +
                            val.createDate +
                            ' </span>' +
                            '</div>' +
                            '<p>' +
                            val.comment +
                            '</p>' +
                            '</li>';
                        $(""#lstComment"").append(item);
                    });
            });

        function btnSave() {
            $.ajax({
                url: ""/Comment/AddComment"",
                type: ""get"",
                data: {
                    pageId: ");
#nullable restore
#line 111 "D:\Larn\ASP.NET Core\MyCMSCore\MyCMS\Views\Pages\ShowPage.cshtml"
                       Write(Model.PageId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
                    name: $(""#name"").val(),
                    email: $(""#email"").val(),
                    webSite: $(""#website"").val(),
                    comment: $(""#comment"").val()
                }
            }).done((res) => {
                alert(""نظر شما ثبت شد"");
                $(""#name"").val("""");
                $(""#email"").val("""");
                $(""#website"").val("""");
                $(""#comment"").val("""");
                refreshComments(res);
            });
        }

        function refreshComments(res) {
                var item = '<li>' +
                    '<img src=""/images/thumb.png"">' +
                    '<div>' +
                    '<span> ' +
                    res.name +
                    ' </span>' +
                    ' <span> ' +
                    res.createDate +
                    ' </span>' +
                    '</div>' +
                    '<p>' +
                    res.comment +
                    '</p>' +
                ");
                WriteLiteral("    \'</li>\';\r\n                $(\"#lstComment\").append(item);\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataLayer.Models.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
