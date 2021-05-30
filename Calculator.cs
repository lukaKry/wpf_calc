using System;
using System.Collections.Generic;

namespace WpfApp_Calc
{
    public class Calculator
    {
        public List<Equation> Memory { get; set; }
        public Calculations Calculations { get; set; }
        public Equation CurrentEquation { get; set; } = new();


        public void ChangeLastSymbolInTheMemory(string symbol)
        {
            CurrentEquation.Symbols[^1] = symbol;
        }
        
        public void AddNumberToTheMemory(string number) 
        {
            CurrentEquation.Numbers.Add(Double.Parse(number));
        }

        public void AddSymbolToTheMemory(string buttonUid)
        {
            CurrentEquation.Symbols.Add(buttonUid);
        }


        public string GetLastEquation()
        {
            string a = "b";
            return a;
        }

        public void Calculate()
        {
            Calculations = new Calculations(CurrentEquation);
            CurrentEquation.Result = Calculations.MakeCalculations();
        }
    }
}