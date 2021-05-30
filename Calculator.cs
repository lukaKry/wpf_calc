using System.Collections.Generic;

namespace WpfApp_Calc
{
    public class Calculator
    {
        public List<Equation> Memory { get; set; }
        public Calculations Calculations { get; set; }


        public void AddNumberToTheMemory() 
        { 
        
        }

        public void AddSymbolToTheMemory()
        {

        }

        public void EditSymbolInTheMemory()
        {

        }

        public string GetLastEquation()
        {
            string a = "b";
            return a;
        }

        public void Calculate()
        {
            Calculations = new Calculations(GetLastEquation());
        }
    }
}