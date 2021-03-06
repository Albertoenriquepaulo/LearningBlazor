﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Helpers
{
    //https://docs.microsoft.com/es-es/aspnet/core/blazor/call-dotnet-from-javascript?view=aspnetcore-3.1
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Example of InvokeVoidAsync");
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("myFunction", message);
        }
    }
}
