using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow
    {



        public MainWindow()
        {
            InitializeComponent();

        }

        


        private void Button_one_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "1";
            }
            else
            {
                readout.Content += "1";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }
        private void Button_zero_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() != "0")
            {
                readout.Content += "0";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }

            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            string display = readout.Content.ToString();
            if (display.Length > 1  ) 
            {
                display = display.Substring(0, display.Length - 1);
            }
            else
            {
                display = "0";
            }
           

            readout.Content = display;
        }

        

       
        private void Button_two_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "2";
            }
            else
            {
                readout.Content += "2";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_three_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "3";
            }
            else
            {
                readout.Content += "3";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_four_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "4";
            }
            else
            {
                readout.Content += "4";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_five_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "5";
            }
            else
            {
                readout.Content += "5";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_six_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "6";
            }
            else
            {
                readout.Content += "6";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_seven_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "7";
            }
            else
            {
                readout.Content += "7";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_eight_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "8";
            }
            else
            {
                readout.Content += "8";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_nine_Click(object sender, RoutedEventArgs e)
        {
            if (readout.Content.ToString() == "0")
            {
                readout.Content = "9";
            }
            else
            {
                readout.Content += "9";
                if (double.Parse(readout.Content.ToString()) > 9999999999)
                {
                    readout.Content = "9999999999";
                }


            }
        }

        private void Button_negate_Click(object sender, RoutedEventArgs e)
        {
            string display = readout.Content.ToString();
            if (double.Parse(display) > 0)
                readout.Content = "-" + display;
            else if (double.Parse(display) == 0)
                readout.Content = readout.Content;
            else if (double.Parse(display) < 0)
            {
                
                readout.Content = display.Replace("-", "");
            }

        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            string display = readout.Content.ToString();
            if (double.Parse(display)>=0)
            {
                readout.Content = "0";
                if ((buffer.Content.ToString().Length) == 0)
                {
                    buffer.Content = $"{display} + ";
                }
                else buffer.Content += display + " + ";
                
            }
            

        }

     

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            string display = readout.Content.ToString();
            if (double.Parse(display) >= 0)
            {
                readout.Content = "0";
                if ((buffer.Content.ToString().Length) == 0)
                {
                    buffer.Content = $"{display} - ";
                }
                else buffer.Content += display + " - ";

            }
        }

        //private void Backspace_OnMouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    //I want to start the timer here
        //}

            

        //private void Backspace_OnMouseUp(object sender, MouseButtonEventArgs e)
        //{
        //   //and end here
        //}
    }
}
