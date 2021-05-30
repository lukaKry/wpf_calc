using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Calc
{
    public class MyApplication 
    {
        
        public Calculator Calculator { get; set; }
        public Display MainDisplay { get; set; }
        public Display AdditionalDisplay { get; set; }
        public Display MemoryDisplay { get; set; }

        public MyApplication()
        {
            Calculator = new Calculator();
            MainDisplay = new Display();
            AdditionalDisplay = new Display();
            MemoryDisplay = new Display();
        }
        
    }
}
