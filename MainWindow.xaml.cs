using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _Memory;
        public string Memory
        {
            get { return _Memory; }
            set
            {
                _Memory = value;
                PropertyChanged?.Invoke(this, new(nameof(Memory)));
            }
        }

        private string _Display;
        public string Display
        {
            get { return _Display; }
            set
            {
                _Display = value;
                PropertyChanged?.Invoke(this, new(nameof(Display)));
            }
        }

        private string _AdditionalDisplay;
        public string AdditionalDisplay
        {
            get { return _AdditionalDisplay; }
            set
            {
                _AdditionalDisplay = value;
                PropertyChanged?.Invoke(this, new(nameof(AdditionalDisplay)));
            }
        }
        public List<string> Equation { get; set; } = new();


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnCalculate(object sender, RoutedEventArgs e)
        {
            Equation.Add(Display);
            AdditionalDisplay = "";
            string test = string.Join("", Equation);

            if (!string.IsNullOrEmpty(Display) && Equation.Count > 0)
            {
                if (Equation[1] == "/" && (Equation[2] == "0" || Equation[2] == "0."))
                {
                    //if(Equation[2] == "0" || Equation[2] == "0.") 
                        MessageBox.Show("nieładnie dzielić przez 0");
                }
                else
                {
                    Display = new DataTable().Compute(test, null).ToString().Replace(",", ".");
                    if (Display.Length > 15) Display = Display.Substring(0, 15);
                }
            }
            Equation.RemoveAll(q => true);
        }

        private void OnNumberButtonClicked(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Display += b.Uid;
           // if (Display.EndsWith("..")) Display = Display.Substring(0, Display.Length - 1);
           if( b.Uid == ".")
            if (Display[0..^1].Contains(".")) 
              Display = Display[0..^1];

        }

        private void OnSymbolButtonClicked(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (!string.IsNullOrEmpty(Display))
            {
                Equation.Add(Display);
                AdditionalDisplay = b.Uid;
                Equation.Add(b.Uid);
                Display = "";
            }
            else
            {
                if (Equation.Count != 0)
                {
                    Equation[^1] = b.Uid;
                    AdditionalDisplay = b.Uid;
                }
            }
        }

        private void OnClear(object sender, RoutedEventArgs e)
        {
            Display = "";
            AdditionalDisplay = "";
            Equation.RemoveAll(q => true);
        }

        private void OnMemory(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Display))
            {
                Display = Memory;
            }
            else
            {
                Memory = Display;
                Display = "";
            }
        }
    }
}
