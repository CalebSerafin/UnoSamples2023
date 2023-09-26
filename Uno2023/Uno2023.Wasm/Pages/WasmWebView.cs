using System;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;

using Uno.Foundation;
using Uno.UI.Runtime.WebAssembly;

using Uno2023.Infrastructure.Pages;

namespace Uno2023.Wasm.Pages;

[ContentProperty(Name = "container")]
[HtmlElement("iframe")] // PrismJS requires a <code> element
public partial class WasmWebView : FrameworkElement, IWebView {
    public WasmWebView() {
        this.Width = 400;
        this.Height = 400;
    }

    public void OpenPage(Uri uri) {
        string escapedUri = WebAssemblyRuntime.EscapeJs(uri.ToString());
        this.SetHtmlAttribute("src", escapedUri);
    }


}
