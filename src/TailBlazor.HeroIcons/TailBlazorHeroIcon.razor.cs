using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net.Http;

namespace TailBlazor.HeroIcons
{
    public class TailBlazorHeroIconBase : ComponentBase
    {

        [Inject] protected NavigationManager NavigationManager { get; set; }

        [Parameter] public HeroIcon Icon { get; set; }
        [Parameter] public int Width { get; set; } = 24;
        [Parameter] public int Height { get; set; } = 24;
        [Parameter] public int StrokeWidth { get; set; } = 2;
        [Parameter] public string Class { get; set; }
        [Parameter] public IconStyle IconStyle { get; set; } = IconStyle.Outline;
        [Parameter] public bool EnableComments { get; set; } = false;

        protected string _classStroke = "stroke-current ";
        protected string _svgIcon = "";
        protected string _svgIconComment = "";

        protected override async Task OnInitializedAsync()
        {
            _classStroke += Class;

            if (EnableComments)
            {
                // HeroIcon: annotation (style: outlined, size: 64x64, stroke (colour): text-grey-500, stroke-width: 2)
                _svgIconComment = $"<!-- TailBlazor.HeroIcon: {EnumExtension.GetEnumDescription(Icon)} (style: {IconStyle.Outline.ToString()}, size: {Height}x{Width}, stroke (colour): {Class}, stroke-width: {StrokeWidth}) -->";
            }

            var client = new HttpClient();
            var icon = (await client.GetAsync(NavigationManager.BaseUri + "_content/TailBlazor.HeroIcons/icons/" +
                                              EnumExtension.GetEnumDescription(IconStyle) + "/" + EnumExtension.GetEnumDescription(Icon) + ".svg"))
                .Content;
            await using var stream = await icon.ReadAsStreamAsync();
            var root = (await XDocument.LoadAsync(stream, LoadOptions.PreserveWhitespace, CancellationToken.None)).Root;
            root?.SetAttributeValue("width", Width);
            root?.SetAttributeValue("height", Height);
            root?.SetAttributeValue("stroke", "");
            root?.SetAttributeValue("class", _classStroke);
            foreach (var xelement in root?.Descendants().Select((Func<XElement, XElement>)(path => path)) ??
                                     new List<XElement>())
            {
                if (xelement.Attribute("stroke-width") != null)
                    xelement.SetAttributeValue("stroke-width", StrokeWidth);
                if (xelement.Attribute("fill") != null)
                    xelement.SetAttributeValue("fill", StrokeWidth);
            }

            _svgIcon = root?.ToString();
        }
    }
}
