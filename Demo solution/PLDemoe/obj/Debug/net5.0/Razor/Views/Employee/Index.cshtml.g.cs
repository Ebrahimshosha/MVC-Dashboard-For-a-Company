#pragma checksum "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2c33fe41753dee583d236ff86197d3d35ef16eb269cae75da64fc081aac0dd0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\_ViewImports.cshtml"
using DALDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\_ViewImports.cshtml"
using PLDemoe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\_ViewImports.cshtml"
using PLDemoe.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\_ViewImports.cshtml"
using BLLDemo.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2c33fe41753dee583d236ff86197d3d35ef16eb269cae75da64fc081aac0dd0d", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"196e6e385c964519cc50441f2d2663b44c5cba50b11fbc624672ec1f2663b5a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-8 offset-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Employee Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
  
	ViewData["Title"] = "All Employee";

	//string VDataMessage = ViewData["Message"] as string; // Enforce Type Safty → Requires Casting [Strongly Typed] [Faster]
	//var VBagMessage = ViewBag.Message; // Can't Enforce Type Safty → Not Requires Casting [Weekly Typed]

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
 if (TempData["Message"] is not null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div id=\"MessageDiv\" class=\"alert alert-success\">\r\n\r\n\t\t");
#nullable restore
#line 14 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
            WriteLiteral("\r\n\r\n\t\t");
#nullable restore
#line 16 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
Write(TempData.Peek("Message"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";  ");
            WriteLiteral("\r\n\r\n\r\n\t</div>\r\n");
#nullable restore
#line 20 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>All Employee</h1>\r\n\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c33fe41753dee583d236ff86197d3d35ef16eb269cae75da64fc081aac0dd0d8963", async() => {
                WriteLiteral("Create New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row justify-content-center align-items-center mt-5\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c33fe41753dee583d236ff86197d3d35ef16eb269cae75da64fc081aac0dd0d10520", async() => {
                WriteLiteral("\r\n\t\t<div class=\"col-8\">\r\n\t\t\t<input type=\"text\" class=\"form-control\" name=\"SearchValue\" placeholder=\"Search By Name\" />\r\n\t\t</div>\r\n\t\t<div class=\"col-4\">\r\n\t\t\t<input type=\"submit\" value=\"Search\" class=\"btn btn-success\" />\r\n\t\t</div>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<br />\r\n");
#nullable restore
#line 43 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<table class=\" mt-4 table table-striped table-hover\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>");
#nullable restore
#line 48 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 49 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 50 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 51 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 52 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 53 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 54 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 55 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 56 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 57 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
   Write(Html.DisplayNameFor(E=>E.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>Details</th>\r\n\t\t\t\t<th>Updates</th>\r\n\t\t\t\t<th>Delete</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 64 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
    foreach (var Emp in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 67 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c33fe41753dee583d236ff86197d3d35ef16eb269cae75da64fc081aac0dd0d16184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1920, "~/Files/Images/", 1920, 15, true);
#nullable restore
#line 69 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 1935, Emp.ImageName, 1935, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 71 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Emp.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 72 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Emp.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 73 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Emp.Department?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\t\t\t\t\t<td> ");
#nullable restore
#line 75 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Html.DisplayFor(M=>Emp.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\t\t\t\t\t<td>\r\n");
#nullable restore
#line 78 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
       if(Emp.IsActive==true)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<i class=\"fa-solid fa-circle\" style=\"color :green\"></i>\r\n");
#nullable restore
#line 81 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<i class=\"fa-solid fa-circle\" style=\"color :red\"></i>\r\n");
#nullable restore
#line 85 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</td>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 87 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Html.DisplayFor(M=>Emp.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 88 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Emp.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td> ");
#nullable restore
#line 89 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
     Write(Emp.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c33fe41753dee583d236ff86197d3d35ef16eb269cae75da64fc081aac0dd0d20865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 90 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Emp.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 92 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
#nullable restore
#line 95 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"mt-4 alert alert-warning\">\r\n\t\t<h3>There is No Employees :( </h3>\r\n\t</div>\r\n");
#nullable restore
#line 101 "E:\Route\Back-end\7 ASP.NET MVC\Demoes\Session 3&4\Demoe solution\PLDemoe\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591