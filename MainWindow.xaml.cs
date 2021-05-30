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
    public partial class MainWindow : Window
    {
        public MyApplication MyApplication { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void On_MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            MyApplication.MainDisplay.AddToDisplay("blaa");
        }

        private void On_ClearButton_Click(object sender, RoutedEventArgs e)
        {
            MyApplication.MainDisplay.ClearDisplay();
        }
    }
}
