#pragma checksum "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4678cb4fd789cbf9ba7b505ce86965725668a2c7"
// <auto-generated/>
#pragma warning disable 1591
namespace TuitionsOnline.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using TuitionsOnline.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using TuitionsOnline.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "box col-5 align-content-md-center");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"hometext1\">\r\n            Tuitions Online\r\n        </div>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(7, "<div class=\"hometext2\">\r\n            Bringing Teachers and Students of India Together\r\n        </div>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"hometext3\">\r\n            Opening Soon For Students !\r\n        </div>\r\n        <br>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "btn-default font-weight-bolder hometext4");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Pages\Index.razor"
                                                                                               OpenTeachersForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Teachers please click here to Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        <br>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.AddMarkupContent(19, "<div class=\"box col-7\">\r\n        <div class=\"container\">\r\n            <img src=\"Image/TuitionsOnline1.png\" class=\"responsive\" width=\"768\" height=\"563\">\r\n        </div>\r\n    </div>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(21, "<div class=\"row\">\r\n    <div class=\"container\">\r\n        <img src=\"Image/HowWeWork.png\" class=\"responsive\" width=\"768\" height=\"563\">\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(22, "<div class=\"row\">\r\n\r\n\r\n\r\n    <div>\r\n            <div class=\"headertext\">Benefits for Students</div>\r\n        </div>\r\n    \r\n    <div class=\"box\">\r\n        <img class=\"responsive\" src=\"Image/BenefitsForStudents.png\">\r\n        <div class=\"text1 font-weight-bold\">\r\n            Find the best teacher for yourself.\r\n        </div>\r\n        <div class=\"text2 font-weight-bold\">\r\n            Buy only as many classes as you need.\r\n        </div>\r\n        <div class=\"text3 font-weight-bold\">\r\n            Use the innumerable options available to you.\r\n        </div>\r\n        <div class=\"text4 font-weight-bold\">\r\n            You have the ability to choose another teacher if you need to.\r\n        </div>\r\n        <div class=\"text5 font-weight-bold\">\r\n            Pick and choose a schedule + teacher combination that works for you.\r\n        </div>\r\n        <div class=\"text6 font-weight-bold\">\r\n            Learn from the comfort of your home.\r\n        </div>\r\n    </div>\r\n    <br>\r\n    <h3 class=\"headertext\">Benefits for Teachers</h3>\r\n    <div class=\"box\">\r\n        <img class=\"responsive\" src=\"Image/benefitsForTeachers.png\">\r\n        <div class=\"text1ig2 font-weight-bold\">\r\n            Let students find you.  You have more options now.\r\n        </div>\r\n        <div class=\"text2ig2 font-weight-bold\">\r\n            Teach from the comfort of your home.\r\n        </div>\r\n        <div class=\"text3ig2 font-weight-bold\">\r\n            Collect your fee effortlessly and in advance.\r\n        </div>\r\n        <div class=\"text4ig2 font-weight-bold\">\r\n            Pick and choose a schedule + student  combination that works for you.\r\n        </div>\r\n        <div class=\"text5ig2 font-weight-bold\">\r\n            Your location is no longer a constraint.\r\n        </div>\r\n        <div class=\"text6ig2 font-weight-bold\">\r\n            Scale up and scale down your tuitions according to your needs using our scheduling engine.\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "D:\Projects\12_17_2020\TuitionsOnline\TuitionsOnline\Client\Pages\Index.razor"
      
    public void OpenTeachersForm()
    {
        BlazoredModal.Show("", typeof(TeacherRegistrationForm));
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService BlazoredModal { get; set; }
    }
}
#pragma warning restore 1591
