using Loki.Entities;
using Microsoft.AspNetCore.Components;

namespace Loki.Components
{
    public partial class LokiTd : LokiComponentBase
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}