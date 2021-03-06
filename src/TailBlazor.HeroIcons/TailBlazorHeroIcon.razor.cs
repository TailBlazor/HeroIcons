﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

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

            var baseUri = NavigationManager.BaseUri;
            var token = new CancellationToken();

            var document = await Task.Run(() => {
                    return XDocument.Load($"{baseUri}_content/TailBlazor.HeroIcons/icons/{EnumExtension.GetEnumDescription(IconStyle)}/{EnumExtension.GetEnumDescription(Icon)}.svg");
            });


            //XDocument document =
            //    await XDocument.LoadAsync($"{baseUri}_content/TailBlazor.HeroIcons/icons/{EnumExtension.GetEnumDescription(IconStyle)}/{EnumExtension.GetEnumDescription(Icon)}.svg", LoadOptions.None, token);

            XElement svg_Element = document.Root;

            svg_Element.SetAttributeValue("width", Width);
            svg_Element.SetAttributeValue("height", Height);
            svg_Element.SetAttributeValue("stroke", "");
            svg_Element.SetAttributeValue("class", _classStroke);

            IEnumerable<XElement> descendants = from path in svg_Element.Descendants() select path;

            foreach (XElement path in descendants)
            {
                if (path.Attribute("stroke-width") != null)
                {
                    path.SetAttributeValue("stroke-width", StrokeWidth);
                }
                if (path.Attribute("fill") != null)
                {
                    path.SetAttributeValue("fill", StrokeWidth);
                }
            }

            _svgIcon = svg_Element.ToString();
        }
    }
}
