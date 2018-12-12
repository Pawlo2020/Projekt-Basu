using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basu.View
{
    /// <summary>
    /// Logika interakcji dla klasy BusStopPage.xaml
    /// </summary>
    public partial class BusStopPage : Page
    {
        Frame MainFrame;
        public BusStopPage(Frame MainFrame)
        {
            this.MainFrame = MainFrame;
            ViewModel.DataLoader Loader = new ViewModel.DataLoader();
            ViewModel.DataSetter Setter = new ViewModel.DataSetter();
            InitializeComponent();
            Setter.setBusStops(LV, Loader.getBusStops());
        }
    }
}
