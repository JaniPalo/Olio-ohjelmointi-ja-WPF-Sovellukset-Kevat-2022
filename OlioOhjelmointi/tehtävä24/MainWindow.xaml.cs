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

namespace tehtävä24
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

        private void btn_Lotto_Click(object sender, RoutedEventArgs e)
        {
            Lotto lotto = new Lotto();
            this.Content = lotto;
        }

        private void btn_VikingLotto_Click(object sender, RoutedEventArgs e)
        {
            VikingLotto vikinglotto = new VikingLotto();
            this.Content = vikinglotto;
        }

        private void btn_EuroJackpot_Click(object sender, RoutedEventArgs e)
        {
            EuroJackpot euro = new EuroJackpot();
            this.Content = euro;
        }
    }
}
