using Loki.Entities;
using Loki.Utilities;
using Microsoft.AspNetCore.Components;

namespace Loki.Components
{
    public partial class LokiDrawer : LokiComponentBase
    {
        private string _cssClass => new CssClassBuilder()
            .AddClass("loki-drawer")
            .AddClass(Class)
            .Build();

        [Parameter] public string Class { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}