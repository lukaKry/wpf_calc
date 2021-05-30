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
        

        public void NumberButtonIsClicked( string buttonUid )
        {
            MainDisplay.AddToDisplay(buttonUid);
        }

        public void SymbolButtonIsClicked(string buttonUid )
        {
            // AdditionalDisplay.AddToDisplay(buttonUid);
             AdditionalDisplay.AddToDisplay($"{MainDisplay.Content} {buttonUid} ");
           
            Calculator.AddSymbolToTheMemory(buttonUid);
            Calculator.AddNumberToTheMemory(MainDisplay.Content);

            // AdditionalDisplay.AddToDisplay($"{Calculator.CurrentEquation.Numbers[^1]} {Calculator.CurrentEquation.Symbols[^1]} ");

            MainDisplay.ClearDisplay();
        }

        public void SymbolChange ( string buttonUid )
        {
            Calculator.ChangeLastSymbolInTheMemory(buttonUid);
            var newInputForAdditionalDisplay = PrepareInputForAdditionalDisplay();
            AdditionalDisplay.ChangeDisplay(newInputForAdditionalDisplay);
            // AdditionalDisplay.ChangeDisplay(buttonUid);
        }

        private string PrepareInputForAdditionalDisplay()
        {
            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < Calculator.CurrentEquation.Numbers.Count; i++)
            {
                sb.Append(Calculator.CurrentEquation.Numbers[i] + " ");
                sb.Append(Calculator.CurrentEquation.Symbols[i] + " ");
            }
            return sb.ToString();
        }

        public void EqualSignIsClicked()
        {

            // add last number from the display to the current equation
            Calculator.AddNumberToTheMemory(MainDisplay.Content);

            // perform calculations
            Calculator.Calculate();


            // Refresh Additional Display
            AdditionalDisplay.AddToDisplay(MainDisplay.Content);

            // display result
            MainDisplay.Content = Calculator.CurrentEquation.Result.ToString();


        }
    }
}
