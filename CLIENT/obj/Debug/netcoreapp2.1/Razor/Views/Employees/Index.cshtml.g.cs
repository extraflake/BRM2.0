#pragma checksum "D:\Metrodata\BRM2.0\CLIENT\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76c60e8444cc5f2803c972a35f1e0c0652961c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
#line 1 "D:\Metrodata\BRM2.0\CLIENT\Views\_ViewImports.cshtml"
using CLIENT;

#line default
#line hidden
#line 2 "D:\Metrodata\BRM2.0\CLIENT\Views\_ViewImports.cshtml"
using CLIENT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76c60e8444cc5f2803c972a35f1e0c0652961c1", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705514d41fa213e299212dd0a1d48cc26af8314f", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables/responsive.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2/sweetalert2@9.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/uploaddownload.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Metrodata\BRM2.0\CLIENT\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Participant";
    Layout = "~/Views/Shared/_LayoutAdministrator.cshtml";

#line default
#line hidden
            BeginContext(109, 3211, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-4 form-inline"">
            <div class=""upload-btn-wrapper"">
                <button class=""fa fa-cloud-upload btn btn-up""></button>
                <input type=""file"" name=""formFile"" id=""formFile"" onchange=""uploadFile('formFile');"" />
            </div>
            <div class=""upload-btn-wrapper"">
                <button type=""button"" id=""Create"" class=""btn right fa fa-plus-circle btn-add"" data-toggle=""modal"" data-target=""#myModal"" onclick=""ClearScreen();""></button>
            </div>
        </div>
    </div>
    <br />
    <table class=""table dt-responsive nowrap"" id=""table"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr>
                <th style=""background-color:skyblue;color:white;text-align:center;width:100px"">
                    No.
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Name
                </th>
");
            WriteLiteral(@"                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Email
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Location
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Phone
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"" class=""no-sort"">
                    Action
                </th>
            </tr>
        </thead>
    </table>
</div>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myModalLabel"">Employee Form</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            </di");
            WriteLiteral(@"v>
            <div class=""modal-body"">
                <div class=""form-group"" hidden=""hidden"">
                    <label for=""Id"">Id</label>
                    <input type=""text"" class=""form-control"" id=""Id"" placeholder=""Id"" />
                </div>
                <div class=""form-group"">
                    <label for=""FirstName"">First Name</label>
                    <input type=""text"" class=""form-control"" id=""FirstName"" placeholder=""First Name"" />
                </div>
                <div class=""form-group"">
                    <label for=""LastName"">Last Name</label>
                    <input type=""text"" class=""form-control"" id=""LastName"" placeholder=""Last Name"" />
                </div>
                <div class=""form-group"" id=""emailclass"">
                    <label for=""Email"">Email</label>
                    <input type=""email"" class=""form-control"" id=""Email"" placeholder=""Email"" />
                </div>
                <div class=""form-group"">
                    <label ");
            WriteLiteral("for=\"Hiring_Location\">Hiring Location</label>\r\n                    <select id=\"Province\" class=\"pc form-control\">\r\n                        ");
            EndContext();
            BeginContext(3320, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8b376923f048ffab25288fab9492f6", async() => {
                BeginContext(3328, 15, true);
                WriteLiteral("Select Province");
                EndContext();
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
            EndContext();
            BeginContext(3352, 200, true);
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <select id=\"District\" class=\"pc form-control district\">\r\n                        ");
            EndContext();
            BeginContext(3552, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5df2f33da1450583ad9301149d996c", async() => {
                BeginContext(3560, 15, true);
                WriteLiteral("Select District");
                EndContext();
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
            EndContext();
            BeginContext(3584, 317, true);
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""Phone"">Phone</label>
                    <div class=""form-inline"">
                        <input type=""number"" class=""form-control col-md-2"" placeholder=""+62"" disabled=""disabled"" />
");
            EndContext();
            BeginContext(4073, 912, true);
            WriteLiteral(@"                        <input type=""text"" class=""form-control col-md-10"" id=""Phone"" name=""phone"" placeholder=""Phone Number"" />
                    </div>
                </div>
                <div class=""form-group"" hidden=""hidden"">
                    <input type=""text"" class=""form-control"" id=""hiddenfield"" placeholder=""Last Name"" />
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" style=""background-color:skyblue;border-color:skyblue"" id=""Save"" onclick=""Validate();"">Add</button>
                <button type=""button"" class=""btn btn-primary"" style=""background-color:skyblue;border-color:skyblue"" id=""Update"" onclick=""Validate();"">Update</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(7769, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7789, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7795, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91c71567c5684794a5fc3fa4d5661bf8", async() => {
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
                EndContext();
                BeginContext(7872, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(7880, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d651042b577b40bd93d207d812aec178", async() => {
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
                EndContext();
                BeginContext(7944, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7950, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e12605f49b3c4e64b0693122cf5cec8c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8018, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8024, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e924af77ba834a20a6d2cd369dd8ea60", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8081, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8087, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60393c227f1c498fa0cc1e47674ac427", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8144, 2899, true);
                WriteLiteral(@"

    <script>
        var table = null;
        $(document).ready(function () {
            table = $('#table').DataTable({
                ""serverside"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""lengthMenu"": [[5, 10, 25, 50, 100], [5, 10, 25, 50, 100]],
                ""ajax"": {
                    ""url"": ""/Employees/LoadEmployee"",
                    ""dataSrc"": ''
                },
                ""columnDefs"":
                    [
                        {
                            ""targets"": [0],
                            ""searchable"": false,
                            ""orderable"": false,
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [1],
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [2],
                            ""class");
                WriteLiteral(@"Name"": ""text-center""
                        },
                        {
                            ""targets"": [3],
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [4],
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [5],
                            ""searchable"": false,
                            ""orderable"": false
                        }],
                ""order"": [[ 1, 'asc' ]],
                ""columns"": [
                    { ""data"": ""id"", ""name"": ""id"", ""autoWidth"": true },
                    { ""data"": ""name"", ""name"": ""name"", ""autoWidth"": true },
                    { ""data"": ""email"", ""name"": ""email"", ""autoWidth"": true },
                    { ""data"": ""location"", ""name"": ""location"", ""autoWidth"": true },
                    { ""data"": ""phone"", ""name"": ""phone"", ""autoWidth"": true },
   ");
                WriteLiteral(@"                 {
                        ""render"": function (data, type, full, meta) {
                            return '<a class=""btn btn-info"" href=""#"" onclick=""GetById(' + full.id + ')"">Edit</a> <a class=""btn btn-danger"" href=""#"" onclick=""Delete(' + full.id + ')"">Delete</a>';
                        }
                    }
                ]
            });
            table.on('order.dt search.dt', function () {
                table.column(0, { search: 'applied', order: 'applied' }).nodes().each(function (cell, i) {
                    cell.innerHTML = i + 1;
                });
            }).draw();
        });
        function LoadData() {
            $.ajax({
                url: ""/Employees/LoadEmployee"",
                type: ""GET"",
                dataType: ""json""
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(11046, 296, true);
            WriteLiteral(@"
<style>
    #Progress_Status {
        width: 50%;
        background-color: #ddd;
    }

    #myprogressBar {
        width: 1%;
        height: 35px;
        background-color: #4CAF50;
        text-align: center;
        line-height: 32px;
        color: black;
    }
</style>
");
            EndContext();
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
