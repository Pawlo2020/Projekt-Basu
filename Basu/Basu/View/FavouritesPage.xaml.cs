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
    /// Logika interakcji dla klasy FavouritesPage.xaml
    /// </summary>
    public partial class FavouritesPage : Page
    {
        Frame MainFrame;
        public FavouritesPage(Frame MainFrame)
        {
            this.MainFrame = MainFrame;
            InitializeComponent();
        }
    }
}
