#pragma checksum "E:\OSSM_project-main\OSSM_project-main\OSSSM_1\Views\Shared\Patient_Add.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Patient_Add), @"mvc.1.0.view", @"/Views/Shared/Patient_Add.cshtml")]
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
#line 1 "E:\OSSM_project-main\OSSM_project-main\OSSSM_1\Views\_ViewImports.cshtml"
using OSSSM_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\OSSM_project-main\OSSM_project-main\OSSSM_1\Views\_ViewImports.cshtml"
using OSSSM_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e7", @"/Views/Shared/Patient_Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a14eea3970414465915873abdad2b887d0adfb3a63081bbdfd27760f8286391e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Patient_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Patient_Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<!--phần đầu-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e75076", async() => {
                WriteLiteral(@"
    <title>Thêm bệnh án</title>
    <meta charset=""utf-8"">
    <link rel=""stylesheet"" href=""trangchinh.css"">
    <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css"">
    <script src=""https://kit.fontawesome.com/2f8895050a.js"" crossorigin=""anonymous""></script>
    <style>
        .list-group.item3 {
            background-color: #001F54;
            color: #FEFCFB !important;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e76614", async() => {
                WriteLiteral(@"
        <div class=""surgery-content"">
            <div class=""surgery-navigator"">
                <div class=""surgery-major-button"">
                    <!-- nghiệp vụ -->
                    <div class=""dropdown"">
                        <button class=""dropbtn"">
                            NGHIỆP VỤ
                            <div class=""dropbtn-icon""><i class=""fa-solid fa-user-tie""></i></div>
                        </button>
                        <div class=""dropdown-content"">
                            <a href=""benhan_them.html"">Thêm bệnh án</a>
                            <a href=""benhnhan_luu.html"">Lưu bệnh án</a>
                        </div>
                    </div>
                </div>
                <div class=""surgery-major-title"">
                    <i class=""fa-solid fa-chevron-right""></i>
                    THÊM BỆNH ÁN
                </div>
            </div> <br>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e77856", async() => {
                    WriteLiteral(@"
                <div class=""medicalrecord-filling-form p2"">
                <div class=""row 1"">
                    <div class=""surgery-form patientname"">
                        <label for=""patient-name"">Họ và tên bệnh nhân</label>
                        <input name=""pname"" type=""text"" id=""patient-name"">
                    </div>
                    <div class=""medicalrecord patient-dateofbirth"">
                        <label for=""birthday"">Ngày sinh</label>
                        <input type=""datetime-local"" id=""birthday"" name=""Pbirthday"">
                    </div>
                    <div class=""medicalrecord patient-sex"">
                        <label for=""surgery-form-roomcode"">Giới tính</label>
                        <select name=""pgender"" id=""surgery-form-roomcode"">
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e79009", async() => {
                        WriteLiteral("Nam");
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
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ed6666e8b0976b0fecbf2ec710116e2a52739f00cf2120213af97c38ab61e710345", async() => {
                        WriteLiteral("Nữ");
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
                    WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""row 2"">
                    <div class=""medicalrecord patient-number"">
                        <label for=""patient-number"">Số điện thoại</label>
                        <input name=""pphonenumber"" type=""number"" id=""patient-number"">
                    </div>
                    <div class=""medicalrecord patient-ID"">
                        <label for=""patient-id"">Số CMT/CCCD</label>
                        <input name=""pID""type=""number"" id=""patient-id"">
                    </div>
                </div>
                <div class=""surgery-form patient-address"">
                    <label for=""patient-address"">Địa chỉ</label>
                    <input name=""paddress"" type=""text"" id=""patient-address"">
                </div><br>
                <div class=""row 3"">
                    <div class=""medicalrecord symptom"">
                        <label for=""symptom"">Triệu chứng</label>");
                    WriteLiteral(@"
                        <input name=""symtom"" type=""text"" id=""symptom"">
                    </div>
                    <div class=""medicalrecord disease"">
                        <label for=""dissease"">Chẩn đoán</label>
                        <input name=""disease"" type=""text"" id=""diagnose"">
                    </div> <br>
                </div>
                <div class=""row 4"">
                    <div class=""medicalrecord timein"" action=""/action_page.php"">
                        <label for=""birthdaytime"">Thời gian vào viện</label>
                        <input type=""datetime-local"" id=""birthdaytime"" name=""Checkintime"">
                    </div>
                </div>
            </div>
                <div class=""submit-reset-button p1"">
                <div class=""submit-button"">
                    <button type=""submit"" id=""submit-button"">
                        <i class=""fa-solid fa-floppy-disk""></i>
                        LƯU
                    </button>
                </div");
                    WriteLiteral(@">
                <div class=""reset-button"">
                    <button id=""reset-button"">
                        <i class=""fa-solid fa-arrows-rotate""></i>
                        LÀM LẠI
                    </button>
                </div>
            </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
