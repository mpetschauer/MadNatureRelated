// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Maqs.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\Maqs\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Maqs\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Maqs\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Maqs\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Maqs\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Maqs\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Maqs\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Maqs\_Imports.razor"
using Maqs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Maqs\_Imports.razor"
using Maqs.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Maqs\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\Maqs\_Imports.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Dev\Maqs\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Maqs\Pages\ContactUs.razor"
using Maqs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Maqs\Pages\ContactUs.razor"
using Maqs.Modules;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Maqs\Pages\ContactUs.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Maqs\Pages\ContactUs.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactUs")]
    public partial class ContactUs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Dev\Maqs\Pages\ContactUs.razor"
       


    EmailModel emailInfo = new EmailModel { };
    bool submitted = false;


    private string emailValue = "";
    private string commentValue = "";


    private void OnEmailInput(ChangeEventArgs changeEvent)
    {
        emailInfo.EmailAddress = (string)changeEvent.Value;
    }

    private void OnCommentInput(ChangeEventArgs changeEvent)
    {
        emailInfo.Comments = (string)changeEvent.Value;
    }

    private void GetData()
    {
        submitted = true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591
