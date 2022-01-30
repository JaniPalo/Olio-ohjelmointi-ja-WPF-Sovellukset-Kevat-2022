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
using System;


namespace tehtävä_26_Oma_sovellus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //tehdään uusi olio Laske luokasta
        Laske calculator = new Laske();

        public MainWindow()
        {
            InitializeComponent();
            //annetaan tieto että nappiboksi sekä tekstikenttä ovat pois päältä konsolin käynnissäessä
            buttonsbox.IsEnabled = false;
            displayTextbox.IsEnabled = false;
        }


        private void NumOpButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            displayTextbox.Text += button.Content.ToString();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //tehdään try catch. Jos koodi on väärin syötetään error viesti
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                displayTextbox.Text = "Error! Yritä uudestaan";
            }
        }

        private void FuncButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == onButton)
            {//Jos syöte on yhtä suuri kuin päälle kytkin. laitetaan nappi päälle
                displayTextbox.Text = "";
                buttonsbox.IsEnabled = true;
                displayTextbox.IsEnabled = true;
            }
            else if (sender == offButton)
            {//jos syöte on yhtä suuri kuin off kytkin. kytketään laite off tilaan
                displayTextbox.Text = "Off";
                buttonsbox.IsEnabled = false;
                displayTextbox.IsEnabled = false;
            }
            else if (sender == clearButton)
            {//Kun syöte on yhtä suuri kuin clear niin se tyhjentää tekstin
                displayTextbox.Text = "";
            }
        }

        private void Calculate()
        {
            int opPos = 0;
            double value1 = 0;
            double value2 = 0;
            double result = 0;
            string op = "";

            //IndexOf metodi Palauttaa ensimmäisen indeksin, josta tietty elementti löytyy 
            if (displayTextbox.Text.Contains("*"))
            {
                opPos = displayTextbox.Text.IndexOf("*");
            }
            else if (displayTextbox.Text.Contains("/"))
            {
                opPos = displayTextbox.Text.IndexOf("/");
            }
            else if (displayTextbox.Text.Contains("+"))
            {
                opPos = displayTextbox.Text.IndexOf("+");
            }
            else if (displayTextbox.Text.Contains("-"))
            {
                opPos = displayTextbox.Text.IndexOf("-");
            }

            value1 = Double.Parse(displayTextbox.Text.Substring(0, opPos));
            op = displayTextbox.Text.Substring(opPos, 1);
            value2 = Double.Parse(displayTextbox.Text.Substring(opPos + 1, displayTextbox.Text.Length - opPos - 1));

            if (op == "*")
            {
                result = calculator.multiply(value1, value2);
                displayTextbox.Text += "= " + result.ToString();
            }
            else if (op == "/")
            {
                if (value2 == 0)
                {
                    displayTextbox.Text = "Ei voida jakaa nollalla";
                }
                else
                {
                    result = calculator.divide(value1, value2);
                    displayTextbox.Text += "= " + result.ToString();
                }
            }
            else if (op == "+")
            {
                result = calculator.add(value1, value2);
                displayTextbox.Text += "= " + result.ToString();
            }
            else if (op == "-")
            {
                result = calculator.subtract(value1, value2);
                displayTextbox.Text += "= " + result.ToString();
            }
        }

        
    }
}
    

