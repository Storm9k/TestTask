#pragma checksum "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b56af5278170ab9b09d16e751a7daca149d4ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_ThirdTaskResult), @"mvc.1.0.view", @"/Views/Task/ThirdTaskResult.cshtml")]
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
#line 1 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\_ViewImports.cshtml"
using TestTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\_ViewImports.cshtml"
using TestTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b56af5278170ab9b09d16e751a7daca149d4ae", @"/Views/Task/ThirdTaskResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cf8f63ba1d33f6434e3ef320625887168eb93", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_ThirdTaskResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThirdTask>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
  

    ViewData["Title"] = "ThirdTaskResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>ThirdTaskResult</h4>\r\n\r\n<div>\r\n    Строка ");
#nullable restore
#line 11 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
      Write(Model.userinput);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
     if (Model.Result())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
   Write(Html.Label("является палиндромом"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
                                           
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
   Write(Html.Label("не является палиндромом"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\ThirdTaskResult.cshtml"
                                              
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThirdTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
