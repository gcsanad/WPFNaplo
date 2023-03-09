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
using Microsoft.Win32;
using System.IO;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cboTantargy.SelectedIndex = 0;
            dpDatum.Text = DateTime.Now.ToString();
        }

        private void sliJegy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int ertek = Convert.ToInt32(Math.Floor(sliJegy.Value));
            lblJegy.Content = Convert.ToString(ertek);
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string csSor = txtNev.Text + ";" + cboTantargy.Text + ";" + dpDatum.Text + ";" + sliJegy.Value;
            StreamWriter sw = new StreamWriter("Naplo.csv", true);
            sw.WriteLine(csSor);
            sw.Close();
            MessageBox.Show("Sikeres mentés!");

        }
        /*
         betoltes:
        jegyek.clear
        streamreader sr = new streamr(gajlNeve)
        while(!sr.EndOfStream){
        string[]mezok=
         */
    }
}
