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

namespace esercizioPreVerifica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> listaBrani = new List<string>();

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            string[] s = txtBrano.Text.Split(',');
            brano b = new brano(s[0], s[1], s[2]);
        }

        private void btnCreaCD_Click(object sender, RoutedEventArgs e)
        {
            string nomeCD;
            nomeCD = txtCD.Text;
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            string[] s = txtBrano.Text.Split(',');
            CD c = new CD(s[0], s[1], listaBrani);
            txtBrano.Text = "";
            txtCD.Text = "";
        }
    }
}
