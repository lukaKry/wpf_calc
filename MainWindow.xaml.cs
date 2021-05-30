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
    public enum State { Initial, NumberEdition, FloatingNumberEdition, SymbolEdition, Evaluation }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyApplication MyApplication { get; set; } = new();

        private State AppState = State.Initial;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void On_MemoryButton_Clicked(object sender, RoutedEventArgs e)
        {
            // Not fully implemented yet
            MyApplication.MainDisplay.AddToDisplay("blaa");
        }

        private void On_ClearButton_Clicked(object sender, RoutedEventArgs e)
        {
            // not fully implemented yet
            MyApplication.MainDisplay.ClearDisplay();
        }

        private void On_NumberButton_Clicked(object sender, RoutedEventArgs e)
        {
            // Change App State
            if (AppState == State.Initial || AppState == State.SymbolEdition) AppState = State.NumberEdition;


            // Change of the Calculator.MainDisplay.Content property
            if (AppState == State.NumberEdition)
            {
                Button button = (Button)sender;
                MyApplication.MainDisplay.AddToDisplay(button.Uid);
            }

        }

        private void On_SymbolButton_Clicked(object sender, RoutedEventArgs e)
        {
            // Change App State
            if (AppState == State.NumberEdition || AppState == State.FloatingNumberEdition)
            {
                AppState = State.SymbolEdition;
                MyApplication.Calculator.
            }


            if ( AppState == State.SymbolEdition )
        }

        private void On_EqualSignButton_Clicked(object sender, RoutedEventArgs e)
        {
            // Change App State only if NumberEdition State is on
            // In order to disable evoking calculations directly from symbol edition state
            if (AppState == State.NumberEdition) AppState = State.Evaluation;
        }
    }
}
