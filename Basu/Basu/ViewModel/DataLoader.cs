using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace Basu.ViewModel
{
    

    class DataLoader
    {
        private Dictionary<string, string> Dict;
        private Model.Line _line;
        private Model.BusStop _busStop;
        //private Model.Timetable _timetable;

        public void getData()
        {
            //Get data from XML
            //parse hours and minutes to Dictionary

            Dict = new Dictionary<string, string>();


        }

        public void setTimeTable(ListView lista)
        {
            //for loop
            //Creating new object
            //
        }




    }
}
