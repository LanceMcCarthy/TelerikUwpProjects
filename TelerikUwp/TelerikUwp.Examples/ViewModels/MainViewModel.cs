using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TelerikUwp.Examples.Views;

namespace TelerikUwp.Examples.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Demos = new ObservableCollection<Demo>()
            {
                new Demo { DemoTitle = "DateRangePicker Demo", GlyphIcon ="", DemoPage = typeof(DateRangePickerDemo)}
            };
        }

        public ObservableCollection<Demo> Demos { get; set; }

        #region INPC

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    public class Demo
    {
        public Type DemoPage { get; set; }
        public string DemoTitle { get; set; }
        public string GlyphIcon { get; set; }
    }
}
