using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Clock.ViewModel;

namespace Clock
{
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindow
            {
                DataContext = new AnalogClock()
            };
            mw.Show();
        }
        
    }
}
