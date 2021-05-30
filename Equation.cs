using System.Collections.Generic;

namespace WpfApp_Calc
{
    public class Equation
    {
        public List<int> Numbers { get; set; } = new();
        public List<string> Symbols { get; set; } = new();
    }
}