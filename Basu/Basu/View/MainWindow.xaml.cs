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
using System.Windows.Threading;

namespace Basu
{
    
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            View.LinePage LinePag = new View.LinePage(MainFrame);
            View.BusStopPage BusStopPag = new View.BusStopPage(MainFrame);
            View.FavouritesPage FavouritesPag = new View.FavouritesPage(MainFrame);
            View.MenuPage Menu = new View.MenuPage(MainFrame,LinePag, BusStopPag, FavouritesPag);
            MainFrame.Content = Menu;

            //Timer
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, 
            delegate
            {
                this.ClockLBL.Content = DateTime.Now.ToString("HH:mm");
            }, 
            this.Dispatcher);


        }
    }
}
