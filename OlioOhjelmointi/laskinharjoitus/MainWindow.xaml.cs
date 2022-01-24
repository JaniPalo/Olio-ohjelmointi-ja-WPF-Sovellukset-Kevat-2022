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

namespace laskinharjoitus
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Syöte1.Text) + float.Parse(txt_Syöte2.Text);
            txt_LoppuTulos.Text =  tulos.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Syöte1.Text) * float.Parse(txt_Syöte2.Text);
            txt_LoppuTulos.Text = tulos.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Syöte1.Text) / float.Parse(txt_Syöte2.Text);
            txt_LoppuTulos.Text = tulos.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float tulos = float.Parse(txt_Syöte1.Text) - float.Parse(txt_Syöte2.Text);
            txt_LoppuTulos.Text = tulos.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Syöte1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Syöte1.Text = "";
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Syöte2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Syöte2.Text = "";
            }
        }
    }
}
