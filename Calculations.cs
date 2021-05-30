namespace WpfApp_Calc
{
    public class Calculations
    {
        private Equation LastEquation { get; set; }


        public Calculations(Equation lastEquation)
        {
            LastEquation = lastEquation;
        }

        public double MakeCalculations()
        {
            int n = 1;
            double result = LastEquation.Numbers[0];

            foreach ( var symbol in LastEquation.Symbols)
            {
                switch ( symbol )
                {
                    case "+": result += LastEquation.Numbers[n]; 
                        break;
                    case "-": result -= LastEquation.Numbers[n];
                        break;
                    case "*": result *= LastEquation.Numbers[n];
                        break;
                    default:
                        break;
                }
                n++;
            }
            return result;
        }
    }
}