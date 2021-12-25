﻿using BlazorComponentUtilities;

namespace BlazorStrap
{
    public partial class BSDiv : BlazorStrapBase
    {
        private string? ClassBuilder => new CssBuilder()
         .AddClass(LayoutClass, !string.IsNullOrEmpty(LayoutClass))
         .AddClass(Class, !string.IsNullOrEmpty(Class))
         .Build().ToNullString();
    }
}
