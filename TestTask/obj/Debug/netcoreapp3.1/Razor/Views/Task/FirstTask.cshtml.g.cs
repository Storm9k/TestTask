#pragma checksum "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\FirstTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42902413889b168d0b908f18452ab2f80cfc606d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_FirstTask), @"mvc.1.0.view", @"/Views/Task/FirstTask.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42902413889b168d0b908f18452ab2f80cfc606d", @"/Views/Task/FirstTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cf8f63ba1d33f6434e3ef320625887168eb93", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_FirstTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\FirstTask.cshtml"
  
    ViewData["Title"] = "FirstTask";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FirstTask</h1>\r\n\r\n<div>\r\n    <h4>Массив содержит числа:</h4>\r\n    \r\n");
#nullable restore
#line 12 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\FirstTask.cshtml"
         foreach (int i in ViewBag.Array)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 14 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\FirstTask.cshtml"
          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\r\n");
#nullable restore
#line 15 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\FirstTask.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h4>Сумма сложения каждого второго нечетного числа из массива чисел:</h4>\r\n        ");
#nullable restore
#line 18 "C:\Users\Vlad\source\repos\TestTask\TestTask\Views\Task\FirstTask.cshtml"
   Write(ViewBag.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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