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

namespace tehtävä_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila = 20;
        bool keittiövalot = false;
        bool olohuoneenvalot = false;
        bool oviLukossa = true;
        public MainWindow()
        {
            InitializeComponent();
            //asetetaan kaikki xamli tekstit antamiin float ja bool arvoihin stringi muodossa
            tb_Lämpotila.Text = "Sisä lämpötila on " + lämpötila;
            tb_keittiötila.Text = keittiövalot.ToString();
            tb_olohuoneentila.Text = olohuoneenvalot.ToString();
            btn_Ovi.Content = oviLukossa.ToString();
        }
        
        //
        private void btn_Keittiö_Click(object sender, RoutedEventArgs e)
        {
            keittiövalot = !keittiövalot;
            tb_keittiötila.Text = keittiövalot.ToString();
        }

        private void btn_Olohuone_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenvalot = !olohuoneenvalot;
            tb_olohuoneentila.Text = olohuoneenvalot.ToString();
        }

        private void btn_Ovi_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa;
            btn_Ovi.Content = oviLukossa.ToString();
        }

        private void txt_Termostaatti_TextChanged(object sender, TextChangedEventArgs e)
        {
            //tehdään if statement jossa termostaatti.text kohtaan pystyy laittamaan vaan numeroita 0-9
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Termostaatti.Text, "[^0-9]"))
            {
                //kun tehdään väärä arvo luodaan teksti kenttä jossa annetaan huomautus
                MessageBox.Show("Please enter only numbers.");
                txt_Termostaatti.Text = "";
            }
            else
            {
                if (txt_Termostaatti.Text == "")
                    return;
                
                lämpötila = int.Parse(txt_Termostaatti.Text);
                tb_Lämpotila.Text = "Talon sisälämpötila on " + lämpötila;
            }
        }
    }
}
