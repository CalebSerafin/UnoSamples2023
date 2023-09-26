using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

using Uno2023;
using Uno2023.Infrastructure.Pages;

using UnoWinUIQuickStart.Pages;

namespace UnoWinUIQuickStart;

public class Program {
    static void Main(string[] args) {
        App.ConfigureServices((context, services) => {
            services.AddTransient<IWebView, WindowsWebView>();
        });

        // Very hacky.
        typeof(Uno2023.Program).GetMethod("Main", BindingFlags.Static | BindingFlags.NonPublic)!.Invoke(null, new object[] { args });
    }
}
