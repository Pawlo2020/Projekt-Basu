using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;
namespace Basu.ViewModel
{
    class DataLoader
    {
        private Dictionary<string, string> Dict;
        private Model.Line _line;
        private Model.BusStop _busStop;
        private XmlReader reader;
        public List<string> linesList;
        //private Model.Timetable _timetable;

        DataLoader()
        {
            XmlReader Reader = XmlReader.Create("rozklad.xml");
        }

        public void getLines()
        {
            linesList = new List<string>();
            while (reader.Read())
            {
                
            }



        }


        public void getBusStops()
        {

        }


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
