using Windows.UI.Xaml.Controls;
using TelerikUwp.Examples.ViewModels;

namespace TelerikUwp.Examples
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ListViewBase_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedDemo = e.ClickedItem as Demo;
            Frame.Navigate(selectedDemo?.DemoPage);
        }
    }
}
