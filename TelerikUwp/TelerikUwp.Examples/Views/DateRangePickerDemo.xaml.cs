using Windows.UI.Xaml.Controls;
using TelerikUwp.ExtendedControls.EventArgs;

namespace TelerikUwp.Examples.Views
{
    public sealed partial class DateRangePickerDemo : Page
    {
        public DateRangePickerDemo()
        {
            this.InitializeComponent();
        }

        private void MyDateRangePicker_OnDateRangeValueChanged(object sender, DateRangeChangedEventArgs e)
        {
            StartDateTextBlock.Text = e.StartDate.ToString("MM/dd/yyyy hh:mm tt");
            EndDateTextBlock.Text = e.EndDate.ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}
