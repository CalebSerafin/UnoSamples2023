using Microsoft.Extensions.DependencyInjection;

using Uno2023.Infrastructure.Pages;
using Uno2023.Wasm.Pages;

namespace Uno2023.Wasm;

public class Program {
    private static App? app;

    public static int Main(string[] args) {
        Microsoft.UI.Xaml.Application.Start(_ => {
            app = new AppHead();
            App.ConfigureServices((context, services) => {
                services.AddTransient<IWebView, WasmWebView>();
            });
        });

        return 0;
    }
}
