﻿using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorStrap
{
    public partial class BSFormGroup : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> UnknownParameters { get; set; }

        protected string Classname =>
        new CssBuilder()
            .AddClass("form-check", IsCheck)
            .AddClass("form-group", !IsCheck)
            .AddClass("row", IsRow)
            .AddClass(Class)
        .Build();

        [Parameter] public bool IsRow { get; set; }
        [Parameter] public bool IsCheck { get; set; }
        [Parameter] public string Class { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
