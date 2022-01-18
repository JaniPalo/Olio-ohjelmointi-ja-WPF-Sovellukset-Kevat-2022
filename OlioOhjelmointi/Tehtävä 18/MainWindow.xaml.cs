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

namespace Tehtävä_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


        }

        private void btn_Kertolasku_Click(object sender, RoutedEventArgs e)
        {
           

            float tulos = float.Parse(txt_Syöte1.Text) * float.Parse(txt_syöte2.Text);
            txt_Lopputulos.Text = tulos.ToString();

        }

        private void btn_Summa_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Syöte1.Text) + float.Parse(txt_syöte2.Text);
            txt_Lopputulos.Text = tulos.ToString();
        }

        private void btn_Jakolasku_Click(object sender, RoutedEventArgs e)
        {

            float tulos = float.Parse(txt_Syöte1.Text) / float.Parse(txt_syöte2.Text);
            txt_Lopputulos.Text = tulos.ToString();
        }

        private void btn_Erotus_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Syöte1.Text) - float.Parse(txt_syöte2.Text);
            txt_Lopputulos.Text = tulos.ToString();
        }

        private void txt_Syöte1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Syöte1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Syöte1.Text = "";
            }
        }

        private void txt_syöte2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_syöte2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_syöte2.Text = "";
            }
        }
    }
}
