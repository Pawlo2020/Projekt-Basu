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
            //-------Blok kodu - utworzenie obiektów ob klas widoku
            InitializeComponent();
            View.LinePage LinePag = new View.LinePage(MainFrame);
            View.BusStopPage BusStopPag = new View.BusStopPage(MainFrame);
            View.FavouritesPage FavouritesPag = new View.FavouritesPage(MainFrame);
            View.MenuPage Menu = new View.MenuPage(MainFrame,LinePag, BusStopPag, FavouritesPag);
            MainFrame.Content = Menu;
            //---------------------------

            //----------Blok kodu - Czasomierz oparty na System.Threading
            DispatcherTimer Timer = new DispatcherTimer();      //Utworzenie obiektu Timer (czasomierza) klasy DispatcherTimer
            Timer.Tick += new EventHandler(clockEv);            //Przypisanie wywołania zdarzenia do każdego cyklu timera
            Timer.Interval = new TimeSpan(0, 0, 1);             //Interwał czasowy TimeSpan - jedna sekunda
            Timer.Start();                                      //Wystartowanie czasomierza
        }

        //Implementacja zdarzenia clockEv - 
        private void clockEv(object sender, EventArgs e)
        {
            DateTime time;          //Zmienna time zdolna do przechowywania czasu systemowego
            time = DateTime.Now;    //Przypisanie aktualnego czasu systemowego
            ClockLBL.Content = time.ToString("HH:mm:ss");   //Wyświetlenie aktualnej godziny, minuty oraz sekundy na label'u ClockLBL, przy pomocy zmiennej time,
                                                            //która została sparsowana przez ToString w formacie żądanej godziny
        }
    }
}
