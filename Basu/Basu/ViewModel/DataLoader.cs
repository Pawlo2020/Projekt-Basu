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
        private XmlDocument reader;
        public List<string> linesList;
        //private Model.Timetable _timetable;

        public DataLoader()
        {
            XmlDocument reader = new XmlDocument();
            this.reader = reader;
            Console.WriteLine("Loader");
        }

        public List<string> getLines()
        {
            reader.Load("rozklad.xml");
            linesList = new List<string>();

            foreach(XmlNode node in reader.SelectNodes("//id-przystanku[@Id]"))
            {
                linesList.Add(node.Attributes["Id"].Value);
            }

            foreach (var item in linesList)
            {
                Console.WriteLine(item);
            }

            return linesList;



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
