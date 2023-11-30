using System;

namespace TelerikMauiAppSupportTelerikVS2022;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        pdfViewer.Source = @"C:\Progress\Telerik\PdfSearchNETMaui\TelerikMauiAppSupportTelerikVS2022\Platforms\Windows\Documents\The Sweet Gesture.pdf";
    }
    
 

}

