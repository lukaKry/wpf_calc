using System.Collections.Generic;

namespace WpfApp_Calc
{
    public class Equation
    {
        public List<double> Numbers { get; set; } = new();
        public List<string> Symbols { get; set; } = new();
        public double Result { get; set; }
    }
}