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
    /// Interaction logic for EuroJackpot.xaml
    /// </summary>
    public partial class EuroJackpot : Page
    {
        public EuroJackpot()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main2 = new MainWindow();
            this.Content = main2;
        }
    }
}
