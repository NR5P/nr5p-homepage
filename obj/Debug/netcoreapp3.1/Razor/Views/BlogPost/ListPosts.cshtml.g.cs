#pragma checksum "/home/nathan/Desktop/nr5p-homepage/Views/BlogPost/ListPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e92667a8861ef52e0fb779ed2580739ff8abfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogPost_ListPosts), @"mvc.1.0.view", @"/Views/BlogPost/ListPosts.cshtml")]
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
#line 1 "/home/nathan/Desktop/nr5p-homepage/Views/_ViewImports.cshtml"
using nr5p_homepage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e92667a8861ef52e0fb779ed2580739ff8abfd", @"/Views/BlogPost/ListPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269c24eb397b042b5a4cf75bb4437e22d07a21bc", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogPost_ListPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPost>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h1>blog posts</h1>\n");
#nullable restore
#line 5 "/home/nathan/Desktop/nr5p-homepage/Views/BlogPost/ListPosts.cshtml"
 foreach (var post in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <h2>");
#nullable restore
#line 8 "/home/nathan/Desktop/nr5p-homepage/Views/BlogPost/ListPosts.cshtml"
       Write(post.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <h2>");
#nullable restore
#line 9 "/home/nathan/Desktop/nr5p-homepage/Views/BlogPost/ListPosts.cshtml"
       Write(post.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <h2>");
#nullable restore
#line 10 "/home/nathan/Desktop/nr5p-homepage/Views/BlogPost/ListPosts.cshtml"
       Write(post.body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    </div>\n");
#nullable restore
#line 12 "/home/nathan/Desktop/nr5p-homepage/Views/BlogPost/ListPosts.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
