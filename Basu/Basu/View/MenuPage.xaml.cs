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
    /// Logika interakcji dla klasy MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        Frame MainFrame;
        Page LinePag;
        Page BusStopPag;
        Page FavouritesPag;
        public MenuPage(Frame MainFrame, Page LinePag, Page BusStopPag, Page FavouritesPag)
        {
            this.FavouritesPag = FavouritesPag;
            this.LinePag = LinePag;
            this.BusStopPag = BusStopPag;
            this.MainFrame = MainFrame;
            InitializeComponent();
            
        }

        private void LineCat_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = LinePag;
        }

        private void BusStopCat_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = BusStopPag;
        }

        private void FavButCat_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = FavouritesPag;
        }
    }
}
