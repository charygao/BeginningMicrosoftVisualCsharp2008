using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeatherClient.WeatherService;

namespace WeatherClient
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void buttonGetWeather_Click(object sender, EventArgs e)
      {
         GetWeatherRequest req = new GetWeatherRequest();
         if (radioButtonCelsius.Checked)
            req.TemperatureType = TemperatureType.Celsius;
         else
            req.TemperatureType = TemperatureType.Fahrenheit;
         req.City = textCity.Text;

         Service1SoapClient client = new Service1SoapClient();
         GetWeatherResponse resp = client.GetWeather(req);

         textWeatherCondition.Text = resp.Condition.ToString();
         textTemperature.Text = resp.Temperature.ToString();

      }
   }
}
