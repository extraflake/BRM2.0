#pragma checksum "D:\Github\BRM2.0\CLIENT\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbf95b494924608984f1d563f9468d6c45f1d397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Index.cshtml", typeof(AspNetCore.Views_Customers_Index))]
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
#line 1 "D:\Github\BRM2.0\CLIENT\Views\_ViewImports.cshtml"
using CLIENT;

#line default
#line hidden
#line 2 "D:\Github\BRM2.0\CLIENT\Views\_ViewImports.cshtml"
using CLIENT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf95b494924608984f1d563f9468d6c45f1d397", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705514d41fa213e299212dd0a1d48cc26af8314f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\Github\BRM2.0\CLIENT\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdministrator.cshtml";

#line default
#line hidden
            BeginContext(103, 2580, true);
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
                    Address
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Phone
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Relation Manager
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Employee Id
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    District
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"">
                    Relation Manager Phone Number
                </th>
                <th style=""background-color:skyblue;color:white;text-align:center"" class=""no-sort"">
                    Action
                </th>
            </tr");
            WriteLiteral(@">
        </thead>
    </table>
</div>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myModalLabel"">Customer Form</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
");
            EndContext();
            BeginContext(2749, 837, true);
            WriteLiteral(@"                    <label for=""Id"">Id</label>
                    <input type=""text"" class=""form-control"" id=""Id"" placeholder=""Id"" />
                </div>
                <div class=""form-group"">
                    <label for=""Name"">Name</label>
                    <input type=""text"" class=""form-control"" id=""Name"" placeholder=""Name"" />
                </div>
                <div class=""form-group"">
                    <label for=""Address"">Address</label>
                    <input type=""text"" class=""form-control"" id=""Address"" placeholder=""Address"" />
                </div>
                <div class=""form-group"">
                    <label for=""Relation_Manager"">Relation Manager</label>
                    <select id=""Relation_Manager"" class=""pc form-control"" name=""Relation_Manager"">
                        ");
            EndContext();
            BeginContext(3586, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b64271e9dd843a498458d00f615f19b", async() => {
                BeginContext(3594, 23, true);
                WriteLiteral("Select Relation Manager");
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
            BeginContext(3626, 276, true);
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""District"">District</label>
                    <select id=""District"" class=""pc form-control district"" name=""District"">
                        ");
            EndContext();
            BeginContext(3902, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98e607a8b86344b19296d12a129b5091", async() => {
                BeginContext(3910, 15, true);
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
            BeginContext(3934, 1075, true);
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label for=""Phone"">Phone</label>
                    <div class=""form-inline"">
                        <input type=""number"" class=""form-control col-md-2"" placeholder=""+62"" disabled=""disabled"" />
                        <input type=""text"" class=""form-control col-md-10"" id=""Phone"" name=""phone"" placeholder=""Phone Number"" onkeypress=""return isNumberKey(event)"" />
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" style=""background-color:skyblue;border-color:skyblue"" id=""Save"" onclick=""Save();"">Add</button>
                <button type=""button"" class=""btn btn-primary"" style=""background-color:skyblue;border-color:skyblue"" id=""Update"" onclick=""Update();"">Update</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
     ");
            WriteLiteral("       </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(7793, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7813, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7819, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4d28cc49f604a6aa8957c5977526e4b", async() => {
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
                BeginContext(7896, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(7904, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ffcc98d94f4184a8967c6767eb0256", async() => {
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
                BeginContext(7968, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7974, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aac45810d5e45c299848b14d9b519e7", async() => {
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
                BeginContext(8042, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8048, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9cac2c1ecd64ac0a20a067132d245c9", async() => {
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
                BeginContext(8105, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8111, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aaa3030f0d694b55829f854be99b337d", async() => {
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
                BeginContext(8168, 13012, true);
                WriteLiteral(@"

    <script>
        var table = null;
        $(document).ready(function () {
            debugger;
            table = $('#table').DataTable({
                ""serverside"": true,
                ""filter"": true,
                ""orderMulti"": false,
                ""lengthMenu"": [[5, 10, 25, 50, 100], [5, 10, 25, 50, 100]],
                ""ajax"": {
                    ""url"": ""/Customers/LoadCustomer"",
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
           ");
                WriteLiteral(@"                 ""className"": ""text-center""
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
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [6],
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [7],
                            ""className"": ""text-center""
                        },
                        {
                            ""targets"": [8],
                            ""searchable"": false,
                            ""orderable"": false
 ");
                WriteLiteral(@"                       }],
                ""order"": [[1, 'asc']],
                ""columns"": [
                    {
                        render: function (data, type, row, meta) {
                            return meta.row + meta.settings._iDisplayStart + 1 + "".""
                        }
                    },
                    { ""data"": ""name"", ""name"": ""name"", ""autoWidth"": true },
                    { ""data"": ""address"", ""name"": ""address"", ""autoWidth"": true },
                    { ""data"": ""phone"", ""name"": ""phone"", ""autoWidth"": true },
                    { ""data"": ""relation_manager"", ""name"": ""relation_manager"", ""autoWidth"": true },
                    { ""data"": ""employee_id"", ""name"": ""employee_id"", ""autoWidth"": true },
                    { ""data"": ""district"", ""name"": ""district"", ""autoWidth"": true },
                    { ""data"": ""phone_relation_manager"", ""name"": ""phone_relation_manager"", ""autoWidth"": true },
                    {
                        ""render"": function (data, typ");
                WriteLiteral(@"e, full, meta) {
                            return "" <td><button type='button' class='btn btn-info' onclick=GetById('"" + full.id + ""');>Edit</button> <button type='button' class='btn btn-danger' onclick=Delete('"" + full.id + ""');>Delete</button ></td >"";
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

        var Districts = []
        function LoadDistrict(element) {
            //debugger;
            if (Districts.length == 0) {
                $.ajax({
                    type: ""Get"",
                    url: ""/Customers/LoadDistrict"",
                    success: function (data) {
                        //debugger;
                        //Departments = data.data;
                      ");
                WriteLiteral(@"  Districts = data;
                        renderDistrict(element);
                    }
                })
            }
            else {
                renderDistrict(element);
            }
        }

        function renderDistrict(element) {
            //debugger;
            var $ele = $(element);
            $ele.empty();
            $ele.append($('<option/>').val('0').text('Select District').hide());
            $.each(Districts, function (i, val) {
                //$.each(Departments.data, function (i, val) {
                //debugger;
                $ele.append($('<option/>').val(val.id).text(val.name));
            })
        }
        LoadDistrict($('#District'));

        var Employees = []
        function LoadEmployee(element) {
            //debugger;
            if (Employees.length == 0) {
                $.ajax({
                    type: ""Get"",
                    url: ""/Customers/LoadRM"",
                    success: function (data) {
              ");
                WriteLiteral(@"          //debugger;
                        //Departments = data.data;
                        Employees = data;
                        renderEmployee(element);
                    }
                })
            }
            else {
                renderEmployee(element);
            }
        }

        function renderEmployee(element) {
            //debugger;
            var $ele = $(element);
            $ele.empty();
            $ele.append($('<option/>').val('0').text('Select Relation Manager').hide());
            $.each(Employees, function (i, val) {
                //$.each(Departments.data, function (i, val) {
                //debugger;
                $ele.append($('<option/>').val(val.id).text(val.fullname));
            })
        }
        LoadEmployee($('#Relation_Manager'));

        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                r");
                WriteLiteral(@"eturn false;
            return true;
        }

        function ClearScreen() {
            $('#Id').val('');
            $('#Name').val('');
            $('#Address').val('');
            $('#Phone').val('');
            $('#Relation_Manager').val('');
            $('#District').val('');
            $('#Update').hide();
            $('#Save').show();
        }

        function GetById(id) {
            debugger;
            $.ajax({
                url: ""/Customers/GetById/"",
                data: { id: id }
            }).then((result) => {
                debugger;
                if (result) {
                    $('#Id').val(result.id);
                    $('#Id').prop('disabled', true);
                    $('#Name').val(result.name);
                    $('#Address').val(result.address);
                    $('#Phone').val(result.phone);
                    $('#Relation_Manager').val(result.relation_manager);
                    $('#District').val(result.district);
   ");
                WriteLiteral(@"                 $('#myModal').modal('show');
                    $('#Update').show();
                    $('#Save').hide();
                }
            })
        }

        function Save() {
            if ($('#Id').val() == 0) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
                    title: 'Please Full Fill The Id',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            else if ($('#Name').val() == 0) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
                    title: 'Please Full Fill The Customer Name',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            else if ($('#Address').val() == 0) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
            ");
                WriteLiteral(@"        title: 'Please Full Fill The Address',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            else if ($('#Phone').val() == 0) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
                    title: 'Please Full Fill The Phone',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            else if ($('#Relation Manager').val() == 0) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
                    title: 'Please Select The Relation Manager',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            else if ($('#District').val() == 0) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
                    title: '");
                WriteLiteral(@"Please Select The District',
                    showConfirmButton: false,
                    timer: 1500
                });
            }
            else {
                debugger;
                var Customer = new Object();
                Customer.id = $('#Id').val();
                Customer.name = $('#Name').val();
                Customer.address = $('#Address').val();
                Customer.phone = $('#Phone').val();
                Customer.relation_manager = $('#Relation_Manager').val();
                Customer.district = $('#District').val();
                $.ajax({
                    type: 'POST',
                    url: '/Customers/Insert/',
                    data: Customer
                }).then((result) => {
                    debugger;
                    if (result.statusCode == 201 || result.statusCode == 204 || result.statusCode == 200) {
                        Swal.fire({
                            position: 'center',
                            type:");
                WriteLiteral(@" 'success',
                            title: 'Customer Added Successfully'
                        });
                        table.ajax.reload();
                    } else {
                        Swal.fire('Error', 'Failed to Input', 'error');
                        ClearScreen();
                    }
                })
            }
        }

        function Update() {
            debugger;
            var Customer = new Object();
            Customer.id = $('#Id').val();
            Customer.name = $('#Name').val();
            Customer.address = $('#Address').val();
            Customer.phone = $('#Phone').val();
            Customer.relation_manager = $('#Relation_Manager').val();
            Customer.district = $('#District').val();
            $.ajax({
                type: ""POST"",
                url: '/Customers/Update/',
                data: Customer
            }).then((result) => {
                debugger;
                if (result.statusCode == 201 || resul");
                WriteLiteral(@"t.statusCode == 204 || result.statusCode == 200) {
                    Swal.fire({
                        position: 'center',
                        type: 'success',
                        title: 'Customer Updated Successfully'
                    });
                    table.ajax.reload();
                } else {
                    Swal.fire('Error', 'Failed to Update', 'error');
                    ClearScreen();
                }
            })
        }

        function Delete(id) {
            Swal.fire({
                title: 'Are you sure?',
                text: ""You won't be able to revert this!"",
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                if (result.value) {
                    debugger;
                    $.ajax({
                        url: ""/Customers/Delete/"",
            ");
                WriteLiteral(@"            data: { id: id }
                    }).then((result) => {
                        debugger;
                        if (result.statusCode == 200) {
                            Swal.fire({
                                position: 'center',
                                type: 'success',
                                title: 'Delete Successfully'
                            });
                            table.ajax.reload();
                        } else {
                            Swal.fire('Error', 'Failed to Delete', 'error');
                            ClearScreen();
                        }
                    })
                };
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(21183, 298, true);
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
