#pragma checksum "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17bb7d6d7d0035dd6be36f4315e8369f250ebfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Index), @"mvc.1.0.view", @"/Views/Car/Index.cshtml")]
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
#line 2 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
using Task_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17bb7d6d7d0035dd6be36f4315e8369f250ebfa", @"/Views/Car/Index.cshtml")]
    public class Views_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cars>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul style=\"border: 1px solid black\">\r\n");
#nullable restore
#line 9 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li style=\"list-style: none\">Cars Id: ");
#nullable restore
#line 11 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cars Brands: ");
#nullable restore
#line 11 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
                                                             Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cars Models: ");
#nullable restore
#line 11 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
                                                                                        Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cars Average: ");
#nullable restore
#line 11 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
                                                                                                                    Write(item.Average);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cars Prices: ");
#nullable restore
#line 11 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
                                                                                                                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cars Year: ");
#nullable restore
#line 11 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
                                                                                                                                                                          Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\Users\Imac\Desktop\CODE_ACADEMY-tasks\back_end_tasks\Task_2\Task_2\Task_2\Views\Car\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591