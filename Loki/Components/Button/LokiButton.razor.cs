using Loki.Colors;
using Loki.Entities;
using Loki.Utilities;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Loki.Components
{
    public partial class LokiButton : LokiComponentBase
    {
        protected string _cssClass => new CssClassBuilder()
            .AddClass("loki-button")
            .AddClass($"loki-button-{Variant.ToString()}")
            .AddClass($"loki-button-{Variant.ToString()}-{Color.ToString()}")
            .AddClass($"loki-button-{Variant.ToString()}-{Color.ToString()}-hoverable", Hoverable)
            .AddClass("loki-button-disabled", Disabled)
            .AddClass(Class)
            .Build();

        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public EventCallback OnClick { get; set; }
        [Parameter] public string Class { get; set; }
        [Parameter] public string Style { get; set; }

        [Parameter] public Variant Variant { get; set; } = Variant.Filled;
        [Parameter] public Color Color { get; set; } = Color.Default;
        [Parameter] public bool Hoverable { get; set; } = false;
        [Parameter] public bool Disabled { get; set; } = false;

        private async Task HandleOnClick()
        {
            await OnClick.InvokeAsync();
        }

        
    }
}