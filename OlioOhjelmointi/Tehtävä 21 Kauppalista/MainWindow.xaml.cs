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

namespace Tehtävä_21_Kauppalista
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

        private void btn_Lisää_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)cb_Kana.IsChecked)
            {
                btn_Lisää.ToString();  tb_text.Text.ToString();
            }


        }

        private void cb_Kana_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)cb_Kana.IsChecked)
            {
                
            }
        }
    }
    }
