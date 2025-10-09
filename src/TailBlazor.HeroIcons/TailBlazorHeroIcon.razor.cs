using System;
using System.Reflection;
using System.Threading;
using System.Xml.Linq;
using Microsoft.AspNetCore.Components;

namespace TailBlazor.HeroIcons
{
    public class TailBlazorHeroIconBase : ComponentBase
    {
        private const string ResourcePrefix = "TailBlazor.HeroIcons.icons.";
        private static readonly Assembly IconAssembly = typeof(TailBlazorHeroIconBase).Assembly;

        [Parameter] public HeroIcon Icon { get; set; }
        [Parameter] public int Width { get; set; } = 24;
        [Parameter] public int Height { get; set; } = 24;
        [Parameter] public int StrokeWidth { get; set; } = 2;
        [Parameter] public string? Class { get; set; }
        [Parameter] public IconStyle IconStyle { get; set; } = IconStyle.Outline;
        [Parameter] public bool EnableComments { get; set; }

        protected string _svgIcon = string.Empty;
        protected string _svgIconComment = string.Empty;

        private string _classStroke = string.Empty;

        protected override async Task OnParametersSetAsync()
        {
            _classStroke = "stroke-current";

            if (!string.IsNullOrWhiteSpace(Class))
            {
                _classStroke += $" {Class}";
            }

            if (EnableComments)
            {
                _svgIconComment = $"<!-- TailBlazor.HeroIcon: {EnumExtension.GetEnumDescription(Icon)} (style: {EnumExtension.GetEnumDescription(IconStyle)}, size: {Height}x{Width}, stroke (colour): {Class}, stroke-width: {StrokeWidth}) -->";
            }
            else
            {
                _svgIconComment = string.Empty;
            }

            var iconStyleName = EnumExtension.GetEnumDescription(IconStyle);
            var iconName = EnumExtension.GetEnumDescription(Icon);
            var resourceName = $"{ResourcePrefix}{iconStyleName}.{iconName}.svg";

            await using var resourceStream = IconAssembly.GetManifestResourceStream(resourceName)
                ?? throw new InvalidOperationException($"Could not find embedded icon resource '{resourceName}'.");

            var document = await XDocument.LoadAsync(resourceStream, LoadOptions.PreserveWhitespace, CancellationToken.None);

            if (document.Root is null)
            {
                throw new InvalidOperationException($"The SVG document for icon '{iconName}' is empty.");
            }

            document.Root.SetAttributeValue("width", Width);
            document.Root.SetAttributeValue("height", Height);
            document.Root.SetAttributeValue("stroke", null);
            document.Root.SetAttributeValue("class", _classStroke);

            foreach (var path in document.Root.Descendants())
            {
                if (path.Attribute("stroke-width") != null)
                {
                    path.SetAttributeValue("stroke-width", StrokeWidth);
                }
            }

            _svgIcon = document.Root.ToString(SaveOptions.DisableFormatting);
        }
    }
}
