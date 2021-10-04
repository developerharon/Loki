using Loki.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace Loki.Components
{
    public partial class LokiAvatar : LokiComponentBase
    {
        [Parameter] public string Class { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }

        private async Task OnClickHandler(MouseEventArgs e)
        {
            await OnClick.InvokeAsync(e);
        }
    }
}
