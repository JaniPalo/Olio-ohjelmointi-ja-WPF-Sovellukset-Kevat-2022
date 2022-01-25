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

namespace Harjoitus20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Opiskelija> opiskelijat = new List<Opiskelija>();
        public MainWindow()
        {
            InitializeComponent();
            opiskelijat.Add(new Opiskelija("sdsd", "sas", "sasa", "", ""));
            dg_Opiskelijat.ItemsSource = opiskelijat;
        }

        private void btmn_Lisääopiskelija_Click(object sender, RoutedEventArgs e)
        {
            string etunimi = Input_Etunimi.Text;
            string sukunimi = Input_Sukunimi.Text;
            string puhelinnumero = Input_Puhelinnumero.Text;
            string sähköposti = Input_Sähköposti.Text;
            string opiskelijaID = Input_OpiskelijaID.Text;

            opiskelijat.Add(new Opiskelija(etunimi, sukunimi, puhelinnumero, sähköposti, opiskelijaID));
            dg_Opiskelijat.ItemsSource = opiskelijat;

            Input_Etunimi.Text = "";
            Input_Sukunimi.Text = "";
            Input_Puhelinnumero.Text = "";
            Input_Sähköposti.Text = "";
            Input_OpiskelijaID.Text = "";
                

        }

        private void btmn_poistaOpiskelija_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
