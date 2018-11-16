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
            View.MenuPage Menu = new View.MenuPage(MainFrame,LinePag, BusStopPag);
            MainFrame.Content = Menu;
        }
    }
}
