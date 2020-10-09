using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Michael_Peroxaan
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void showAlertDialog(object sender, RoutedEventArgs e)
        {
            await new Windows.UI.Popups.MessageDialog("Michael Peroxaan", "Michael Peroxaan").ShowAsync();
        }
    }
}
