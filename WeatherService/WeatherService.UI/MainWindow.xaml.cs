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
using WeatherService.UI.Models;
using System.Net;
using Newtonsoft.Json;

namespace WeatherService.UI
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

        private void FindWeather(object sender, RoutedEventArgs e)
        {
            string om=string.Empty;
            RootObject rootObj = null;
            try {
                using (var client = new WebClient())
                {
                    om = client.DownloadString("http://api.worldweatheronline.com/premium/v1/weather.ashx?key=5a9373434dec44b4819181647191605&q=" + $"{txtBoxCityName.Text}" + "&format=json&num_of_days=7");
                    rootObj = JsonConvert.DeserializeObject<RootObject>(om);
                    txtBoxMaxT_Copy5.Text = rootObj.Data.Current[0].CurrentTemp;
                    txtBoxMinT_Copy5.Text = rootObj.Data.Current[0].ObesrvationTime;

                    txtBlockDate.Text = rootObj.Data.Weather[0].Date;
                    txtBoxMaxT.Text = rootObj.Data.Weather[0].MaxTemp;
                    txtBoxMinT.Text = rootObj.Data.Weather[0].MinTemp;

                    txtBlockDate_Copy.Text = rootObj.Data.Weather[1].Date;
                    txtBoxMaxT_Copy.Text = rootObj.Data.Weather[1].MaxTemp;
                    txtBoxMinT_Copy.Text = rootObj.Data.Weather[1].MinTemp;

                    txtBlockDate_Copy1.Text = rootObj.Data.Weather[2].Date;
                    txtBoxMaxT_Copy1.Text = rootObj.Data.Weather[2].MaxTemp;
                    txtBoxMinT_Copy1.Text = rootObj.Data.Weather[2].MinTemp;

                    txtBlockDate_Copy2.Text = rootObj.Data.Weather[3].Date;
                    txtBoxMaxT_Copy2.Text = rootObj.Data.Weather[3].MaxTemp;
                    txtBoxMinT_Copy2.Text = rootObj.Data.Weather[3].MinTemp;

                    txtBlockDate_Copy3.Text = rootObj.Data.Weather[4].Date;
                    txtBoxMaxT_Copy3.Text = rootObj.Data.Weather[4].MaxTemp;
                    txtBoxMinT_Copy3.Text = rootObj.Data.Weather[4].MinTemp;

                    txtBlockDate_Copy4.Text = rootObj.Data.Weather[5].Date;
                    txtBoxMaxT_Copy4.Text = rootObj.Data.Weather[5].MaxTemp;
                    txtBoxMinT_Copy4.Text = rootObj.Data.Weather[5].MinTemp;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}... blah blah blah... koroche vvedi normalno navanie goroda");
            }
           
        }
    }
}
