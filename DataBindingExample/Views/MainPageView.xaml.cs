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
            System.Diagnostics.Debug.WriteLine("HyperlinkButton_Tapped");
        }
    }
}
