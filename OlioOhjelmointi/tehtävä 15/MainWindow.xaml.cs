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

namespace tehtävä_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Autot = 0;
        int kuormaautot = 0;

        public MainWindow()
        {
            InitializeComponent();
            TB_Auto.Text = Autot.ToString();
            TB_Kuorma_auto.Text = kuormaautot.ToString();
        }

        private void btn_Kuorma_auto_Click(object sender, RoutedEventArgs e)
        {
            kuormaautot++;
            TB_Kuorma_auto.Text = kuormaautot.ToString();
        }

        private void btn_Auto_Click(object sender, RoutedEventArgs e)
        {
            Autot++;
            TB_Auto.Text = Autot.ToString();
        }
    }
}
