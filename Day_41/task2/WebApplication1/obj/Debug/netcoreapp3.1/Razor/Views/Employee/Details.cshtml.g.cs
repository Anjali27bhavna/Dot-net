#pragma checksum "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "651ec45871b661af6981c30765f57f3a5086fe1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"651ec45871b661af6981c30765f57f3a5086fe1c", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.EmployeeDetailsViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651ec45871b661af6981c30765f57f3a5086fe1c3369", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 5 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651ec45871b661af6981c30765f57f3a5086fe1c4597", async() => {
                WriteLiteral("\r\n    <div class=\"jumbotron-fluid\">\r\n        <h1>");
#nullable restore
#line 9 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
       Write(Model.Header);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    </div>\r\n    <div>\r\n        Employee id : ");
#nullable restore
#line 12 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
                 Write(Model.employee.EmployeeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Employee name : ");
#nullable restore
#line 15 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
                   Write(Model.employee.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Employee Salary : ");
#nullable restore
#line 18 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
                     Write(Model.employee.Salary);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Employee Gender : ");
#nullable restore
#line 21 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
                     Write(Model.employee.Gender);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        Department name : ");
#nullable restore
#line 24 "C:\Users\Anjali.Saini\Desktop\Dot net\Day_41\task2\WebApplication1\Views\Employee\Details.cshtml"
                     Write(Model.department.DepName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
