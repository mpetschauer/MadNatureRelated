#pragma checksum "C:\Dev\Maqs\Pages\ContactUs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12cf7ae5fcaf3c689afde7459c3fcc289fa7bf46"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Dev\Maqs\Pages\ContactUs.razor"
using Maqs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Maqs\Pages\ContactUs.razor"
using Maqs.Modules;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Maqs\Pages\ContactUs.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Maqs\Pages\ContactUs.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "contact-background");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"contact-header\">\r\n        <h3>Contact us</h3>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<p class=""prompt"">
            M.A.D Nature Creations is dedicated towards customer satisfaction and answering any questions you may have.
            Please enter a bit of information down below, click submit, and our team will get back to you as quick as possible!
        </p>

        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "text-align: center");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "action", "GetData");
            __builder.AddAttribute(13, "method", "post");
            __builder.AddMarkupContent(14, "\r\n                Email Address: <br> ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "class", "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "id", "emailValue");
            __builder.AddAttribute(19, "name", "emailValue");
            __builder.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Dev\Maqs\Pages\ContactUs.razor"
                                                                                                                                          OnEmailInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Dev\Maqs\Pages\ContactUs.razor"
                                                                                                                   emailValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emailValue = __value, emailValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                <br>\r\n                Comments: <br> ");
            __builder.OpenElement(24, "textarea");
            __builder.AddAttribute(25, "id", "commentValue");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "name", "commentValue");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 24 "C:\Dev\Maqs\Pages\ContactUs.razor"
                                                                                                     commentValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Dev\Maqs\Pages\ContactUs.razor"
                                                                                                                             OnCommentInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "input");
            __builder.AddAttribute(31, "style", "width: 708px; height:250px");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                <br>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            if(!submitted)\r\n            {\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "sumbit-btn");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Dev\Maqs\Pages\ContactUs.razor"
                                                GetData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            }\r\n           <label href=\"{% if submitted = true%}Submitted{%else%}{% endif %}\"></label>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(42, "<style>\r\n        .contact-header {\r\n            margin-left: auto;\r\n            margin-right: auto;\r\n            display: block;\r\n            border-bottom: 3px solid black;\r\n            border-top: 3px solid black;\r\n            text-align: center;\r\n            background-color: lightgreen;\r\n            opacity: .9;\r\n        }\r\n\r\n        #blazor-error-ui {\r\n            background: lightyellow;\r\n            bottom: 0;\r\n            box-shadow: 0 -1px 2px rgba(0, 0, 0, 0.2);\r\n            display: none;\r\n            left: 0;\r\n            padding: 0.6rem 1.25rem 0.7rem 1.25rem;\r\n            position: fixed;\r\n            width: 100%;\r\n            z-index: 1000;\r\n        }\r\n\r\n            #blazor-error-ui .dismiss {\r\n                cursor: pointer;\r\n                position: absolute;\r\n                right: 0.75rem;\r\n                top: 0.5rem;\r\n            }\r\n\r\n        .submit-btn {\r\n            width: 600px;\r\n            margin-left: auto;\r\n            margin-right: auto;\r\n            display: block;\r\n            text-align: center;\r\n        }\r\n\r\n\r\n        .contact-background {\r\n            background-image: url(img/ContactUsImg.png);\r\n            background-position: center center;\r\n            background-repeat: no-repeat;\r\n            width: 100%;\r\n            height: 90%;\r\n            position: fixed;\r\n            top: 100px;\r\n            left: 0;\r\n            overflow: scroll;\r\n            background-color: white;\r\n            background-size: cover;\r\n        }\r\n\r\n\r\n        .prompt {\r\n            margin-right: auto;\r\n            margin-left: auto;\r\n            margin-top: 50px;\r\n            padding: 10px;\r\n            display: block;\r\n            text-align: center;\r\n            font-family: \'Lucida Handwriting\';\r\n            font-size: 18px;\r\n            opacity: .60;\r\n            color: black;\r\n            border-radius: 2px;\r\n            box-shadow: 1px 1px 3px white;\r\n            background-color: lightgray;\r\n        }\r\n\r\n        .container {\r\n            opacity: .90;\r\n            border-radius: 2px;\r\n            box-shadow: 1px 1px 3px white;\r\n            background-color: lightgray;\r\n            margin-top: 20px\r\n        }\r\n\r\n        .input {\r\n            text-align: center;\r\n            width: 700px;\r\n        }\r\n    </style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Dev\Maqs\Pages\ContactUs.razor"
       


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
    }
}
#pragma warning restore 1591
