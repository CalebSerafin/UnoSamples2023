using Uno2023.Infrastructure.Pages;

namespace Uno2023;

public sealed partial class MainPage : Page {
    public MainPage() {
        this.InitializeComponent();

        IWebView webView = App.Host!.Services.GetRequiredService<IWebView>();

        WebViewContentControl.Content = webView;
        Uri pageUri = new Uri("https://platform.uno/docs/articles/interop/wasm-javascript-1.html");
        webView.OpenPage(pageUri);
    }
}
