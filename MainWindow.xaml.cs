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
        private Class1 _class1;
        public Class1 Class1
        {
            get { return _class1; }
            set
            {
                _class1 = value;
                PropertyChanged?.Invoke(this, new(nameof(Class1)));
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            _class1 = new Class1();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
