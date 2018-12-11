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
        private XmlDocument reader;
        public List<string> busStopList;
        public List<string> linesList;
        //private Model.Timetable _timetable;

        public DataLoader()
        {
            XmlDocument reader = new XmlDocument();
            this.reader = reader;
            this.reader.Load("rozklad.xml");
        }

        public List<string> removeDuplicates(List<string> List)
        {
            var distinctList = new List<string>();
            var container = new List<string>();

            foreach (var item in List) {
                if (!container.Contains(item))
                {
                    distinctList.Add(item);
                    container.Add(item);
                }   
            }
            return distinctList;
        }

        public List<string> getLines()
        {
            
            linesList = new List<string>();

            foreach (XmlNode node in reader.SelectNodes("//id-przystanku[@Id]"))
            {
                linesList.Add(node.Attributes["Id"].Value);
            }

            return linesList;

        }
        public List<string> getBusStops()
        {
            busStopList = new List<string>();

            foreach(XmlNode node in reader.SelectNodes("//przystanek"))
            {
                busStopList.Add(node.InnerText);
            }

            busStopList = removeDuplicates(busStopList);
            busStopList.Sort();

            foreach(var item in busStopList)
            {
                Console.WriteLine(item);
            }


            return busStopList;
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
