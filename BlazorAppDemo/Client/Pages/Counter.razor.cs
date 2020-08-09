using BlazorAppDemo.Client.Helpers;
using BlazorAppDemo.Client.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDemo.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonServices _singletonServices { get; set; }
        [Inject] TransientServices _transientServices { get; set; }
        [Inject] IJSRuntime _js { get; set; }
        //[CascadingParameter(Name = "Color")] public string Color { get; set; }
        //[CascadingParameter(Name = "Size")] public string Size { get; set; }
        [CascadingParameter] public CssParam CssParam { get; set; }

        private string selectedColor;
        private int currentCount = 0;
        private static int currentCountStatic = 0;
        List<Movie> movies;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++; currentCountStatic++;
            _transientServices.Value = currentCount;
            _singletonServices.Value = currentCount;
            await _js.InvokeVoidAsync("dotnetStaticInvocation");
        }
        private async Task IncrementCountJS()
        {
            await _js.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this));
        }

        protected override void OnInitialized()
        {
            selectedColor = "has-text-danger";

            movies = new List<Movie>()
            {
                new Movie { Title = "Tardes Felices", ReleasDate = new DateTime(2018, 5, 5) },
                new Movie { Title = "Show de Fantástico", ReleasDate = new DateTime(1998, 10, 12) },
                new Movie { Title = "Ciudad Bendita", ReleasDate = new DateTime(2007, 11, 1) }
            };

        }

        public void OnSelectedColorChange()
        {
            switch (CssParam.Color)
            {
                case "red":
                    selectedColor = "has-text-danger";
                    break;
                case "green":
                    selectedColor = "has-text-success";
                    break;
                case "blue":
                    selectedColor = "has-text-link";
                    break;
                default:
                    // code block
                    break;
            }
            //StateHasChanged();
        }

        //https://docs.microsoft.com/es-es/aspnet/core/blazor/call-dotnet-from-javascript?view=aspnetcore-3.1
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }


    }
}
