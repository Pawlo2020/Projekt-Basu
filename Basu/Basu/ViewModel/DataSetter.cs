using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Basu.ViewModel
{
    class DataSetter
    {
        class Item
        {
            int ID;
            int hour;
            int minute;
        }

        public void setLines(ListView listView, List<string> list) 
        {
            foreach(String item in list)
            {
                listView.Items.Add(new Model.Line { lineNumber = item });
            }
        }






    }
}
