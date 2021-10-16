using Loki.Entities;
using Microsoft.AspNetCore.Components;

namespace Loki.Components
{
    public partial class LokiTh : LokiComponentBase
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}