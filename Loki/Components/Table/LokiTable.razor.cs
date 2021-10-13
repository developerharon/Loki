using Loki.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Loki.Components
{
    public partial class LokiTable<T> : LokiComponentBase
    {
        [Parameter] public RenderFragment HeaderTemplate { get; set; }
        [Parameter] public RenderFragment<T> RowTemplate {  get; set; }
        [Parameter] public RenderFragment FooterTemplate { get; set; }
        [Parameter] public IEnumerable<T> Data { get; set; }
    }
}