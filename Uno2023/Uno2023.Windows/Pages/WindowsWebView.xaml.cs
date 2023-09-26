using Microsoft.UI.Xaml.Controls;

using Uno2023.Infrastructure.Pages;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UnoWinUIQuickStart.Pages;
public sealed partial class WindowsWebView : UserControl, IWebView {
    public WindowsWebView() {
        this.InitializeComponent();
    }

    public void OpenPage(Uri uri) {
        WebViewControl.Source = uri;
    }
}
