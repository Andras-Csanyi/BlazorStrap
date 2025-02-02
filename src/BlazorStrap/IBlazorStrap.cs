﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace BlazorStrap
{
    public interface IBlazorStrap
    {
        
        Toaster Toaster { get; }
        Theme CurrentTheme { get; }
        Task SetBootstrapCss();
        Task SetBootstrapCss(string version);
        Task SetBootstrapCss(string theme, string version);
        Task SetBootstrapCss(Theme theme, string version);
    }
}