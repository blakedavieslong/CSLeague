#pragma checksum "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6a32e8c5c19415629ff0ab7e8ad1391d086fdb9bf474fb7bf1e287902c7337e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Team), @"mvc.1.0.razor-page", @"/Pages/Teams/Team.cshtml")]
namespace League.Pages.Teams
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\GitHub Repository\C#League\Pages\_ViewImports.cshtml"
using League

#nullable disable
    ;
#nullable restore
#line 2 "C:\GitHub Repository\C#League\Pages\_ViewImports.cshtml"
using League.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", 
    // language=Route
#nullable restore
#line 1 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
      "{id}"

#line default
#line hidden
#nullable disable
    )]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6a32e8c5c19415629ff0ab7e8ad1391d086fdb9bf474fb7bf1e287902c7337e7", @"/Pages/Teams/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"195367c123bfe7cfe62f179190b0cab3c4c6654bf09071bb82836bfca053cc3a", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Teams_Team : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("NFL Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none; color: inherit;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
  
  ViewData["Title"] = "NFL Teams";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a32e8c5c19415629ff0ab7e8ad1391d086fdb9bf474fb7bf1e287902c7337e74829", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 118, "~/image/nfl/logo/", 118, 17, true);
            AddHtmlAttributeValue("", 135, 
#nullable restore
#line 8 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                 Model.CurrentTeam.TeamId

#line default
#line hidden
#nullable disable
            , 135, 27, false);
            AddHtmlAttributeValue("", 162, ".png", 162, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h1 class=\"display-4\">");
            Write(
#nullable restore
#line 9 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                           Model.CurrentTeam.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"pair\">\r\n    <hr class=\"separator\">\r\n    <label>Team Name: </label><p>");
            Write(
#nullable restore
#line 14 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                  Model.CurrentTeam.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Division ID: </label><p>");
            Write(
#nullable restore
#line 15 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                    Model.CurrentTeam.DivisionId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Location: </label><p>");
            Write(
#nullable restore
#line 16 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                 Model.CurrentTeam.Location

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Wins: </label><p>");
            Write(
#nullable restore
#line 17 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                             Model.CurrentTeam.Win

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Losses: </label><p>");
            Write(
#nullable restore
#line 18 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                               Model.CurrentTeam.Loss

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Ties: </label><p>");
            Write(
#nullable restore
#line 19 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                             Model.CurrentTeam.Tie

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Points For: </label><p>");
            Write(
#nullable restore
#line 20 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                   Model.CurrentTeam.PointsFor

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Points Against: </label><p>");
            Write(
#nullable restore
#line 21 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                       Model.CurrentTeam.PointsAgainst

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
</div>

<div class=""text-center"">
    <h2 class=""display-5"">Players</h2>
    <div class=""d-flex bg-primary text-white"" style=""display: flex;"">
        <div class=""p-2"" style=""flex: 1"">
            Name
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Position
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Height
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Weight
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Age
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Birth Date
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Rating
        </div>
        <div class=""p-2"" style=""flex: 1"">
            Rank
        </div>
    </div>
");
#nullable restore
#line 52 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
     foreach (Player player in @Model.PlayerList)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a32e8c5c19415629ff0ab7e8ad1391d086fdb9bf474fb7bf1e287902c7337e710376", async() => {
                WriteLiteral("\r\n            <div class=\"teamListing\">\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 57 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Name

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 60 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Position

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 63 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Height

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 66 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Weight

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 69 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Age

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 72 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.BirthDate.Value.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 75 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Rating

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n                <div class=\"teamElement\">\r\n                    ");
                Write(
#nullable restore
#line 78 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                     player.Rank

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 54 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                            player.PlayerId

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n<div class=\"pair stadium\">\r\n    <label>Stadium: </label><p>");
            Write(
#nullable restore
#line 85 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                Model.CurrentTeam.Stadium

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Capacity: </label><p>");
            Write(
#nullable restore
#line 86 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                 Model.CurrentTeam.Capacity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Address: </label><p>");
            Write(
#nullable restore
#line 87 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                Model.CurrentTeam.Address

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>City: </label><p>");
            Write(
#nullable restore
#line 88 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                             Model.CurrentTeam.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>State: </label><p>");
            Write(
#nullable restore
#line 89 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                              Model.CurrentTeam.State

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Zip: </label><p>");
            Write(
#nullable restore
#line 90 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                            Model.CurrentTeam.Zip

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Latitude: </label><p>");
            Write(
#nullable restore
#line 91 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                 Model.CurrentTeam.Latitude

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n    <label>Longitude: </label><p>");
            Write(
#nullable restore
#line 92 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                  Model.CurrentTeam.Longitude

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"text-center\">\r\n    <div class=\"image-container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a32e8c5c19415629ff0ab7e8ad1391d086fdb9bf474fb7bf1e287902c7337e718211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3322, "~/image/nfl/stadium/", 3322, 20, true);
            AddHtmlAttributeValue("", 3342, 
#nullable restore
#line 96 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                        Model.CurrentTeam.TeamId

#line default
#line hidden
#nullable disable
            , 3342, 27, false);
            AddHtmlAttributeValue("", 3369, ".jpg", 3369, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3380, 
#nullable restore
#line 96 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                                                              Model.CurrentTeam.Name

#line default
#line hidden
#nullable disable
            , 3380, 25, false);
            AddHtmlAttributeValue("", 3405, "\'s", 3405, 2, true);
            AddHtmlAttributeValue(" ", 3407, "Stadium", 3408, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"image-container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a32e8c5c19415629ff0ab7e8ad1391d086fdb9bf474fb7bf1e287902c7337e720604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3486, "~/image/nfl/seating/", 3486, 20, true);
            AddHtmlAttributeValue("", 3506, 
#nullable restore
#line 99 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                        Model.CurrentTeam.TeamId

#line default
#line hidden
#nullable disable
            , 3506, 27, false);
            AddHtmlAttributeValue("", 3533, ".png", 3533, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3544, 
#nullable restore
#line 99 "C:\GitHub Repository\C#League\Pages\Teams\Team.cshtml"
                                                                              Model.CurrentTeam.Name

#line default
#line hidden
#nullable disable
            , 3544, 25, false);
            AddHtmlAttributeValue("", 3569, "\'s", 3569, 2, true);
            AddHtmlAttributeValue(" ", 3571, "Seating", 3572, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel>)PageContext?.ViewData;
        public TeamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
