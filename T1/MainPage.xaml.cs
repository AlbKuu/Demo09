/*
Tehtävä 1 - Autolaskuri

Opiskelija on saanut itselleen unelma kesätyön vilkasliikenteisen kadun varrelta. 
Hänen tulee laskea ohi menevät henkilö- ja kuorma-autot. 
Laadi opiskelijalle sovellus, jolla hän voi laskea helposti ohi menneet autot. 
Painikkeita painettaessa ko. kulkuneuvon osoittama lukumäärä kasvaa yhdellä. 
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void truckButton_Click(object sender, RoutedEventArgs e)
        {
            // get TextBlock value
            string text = truckTextBlock.Text;
            // set TextBlock value
            int trucknum = int.Parse(text);
            trucknum++;
            truckTextBlock.Text = trucknum.ToString();
        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            // get TextBlock value
            string text = carTextBlock.Text;
            // set TextBlock value
            int carnum = int.Parse(text);
            carnum++;
            carTextBlock.Text = carnum.ToString();
        }
    }
}
