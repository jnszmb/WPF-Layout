using System;
using System.Collections.Generic;
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

namespace WpfApplicationZinseszins
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Zinsberechnung z1;
        public MainWindow()
        {
            InitializeComponent();
            z1 = new Zinsberechnung();
            z1.Anfangskapital = 1000;
            z1.Zinsfuss = 10;
            z1.Laufzeit = 5;
            this.DataContext = z1;
        }

        private void button_berechnen_Click(object sender, RoutedEventArgs e)
        {            
           z1.berechneEndkapital();         
        }
    }
}
