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

namespace tehtävä_26
{
    public partial class MainWindow : Window
    {
        List<Esine> työskentelijät = new List<Esine>();
        public MainWindow()
        {
            InitializeComponent();
            
            dg_Esineet.ItemsSource = työskentelijät;
        }

        private void btmn_Lisääopiskelija_Click(object sender, RoutedEventArgs e)
        {
            string esine = Input_Esine.Text;
            string hinta = Input_Hinta.Text;
            string alkuperämaa = Input_Alkuperämaa.Text;
            string materiaali = Input_Materiaali.Text;
            

            työskentelijät.Add(new Esine(esine, hinta, alkuperämaa, materiaali));
            dg_Esineet.ItemsSource = työskentelijät;

           


        }

        private void btmn_poistaOpiskelija_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
