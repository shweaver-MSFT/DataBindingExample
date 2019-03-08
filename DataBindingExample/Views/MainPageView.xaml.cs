using DataBindingExample.Models;
using DataBindingExample.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace DataBindingExample.Views
{
    public sealed partial class MainPageView : Page
    {
        public MainPageView()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }

        private void HyperlinkButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var dataItem = (CarouselDataItemModel)(sender as HyperlinkButton).CommandParameter;
            System.Diagnostics.Debug.WriteLine($"HyperlinkButton_Tapped: {dataItem.Id}");
        }
    }
}
