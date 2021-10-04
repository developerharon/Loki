using Loki.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Loki.Components
{
    public partial class LokiButton : LokiComponentBase
    {
        [Parameter] public string Class { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public bool Disabled { get; set; }
        [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }

        private void OnClickHandler(MouseEventArgs e)
        {
            if (Disabled)
                return;

            OnClick.InvokeAsync(e);
        }
    }
}
