using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsWeatherApp.Service;
using WinFormsWeatherApp.Models;
//using WinFormsWeatherApp.Service;

namespace WinFormsWeatherApp
{
    public partial class MainPageForm : Form
    {
        WeatherAPI serv;
        private double longitude;
        private double latitude;
        private DateTime sunrise;
        private DateTime sunset;

        public MainPageForm()
        {
            InitializeComponent();
            serv = new WeatherAPI();
            longitude = 0.00;
            latitude = 0.00;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string city = tbCityName.Text;

            lblCondition.Text = "";
            lblDescription.Text = "";

            WeatherClasses.Root currentWeather = serv.GetWeatherByCity(city);

            latitude = currentWeather.coord.lat;
            longitude = currentWeather.coord.lon;

            WeatherForecast.Root hourlyWeather = serv.GetWeatherForecast(latitude,longitude);

            

            try
            {
                lblCityName.Text = currentWeather.name;
                lblTemp.Text = currentWeather.main.temperature.ToString() + "°C";

                sunrise = convertToDateTime(currentWeather.sys.sunrise);
                sunset = convertToDateTime(currentWeather.sys.sunset);

                weatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + currentWeather.weather[0].icon + ".png";

                lblCondition.Text = currentWeather.weather[0].main;
                lblDescription.Text = currentWeather.weather[0].description;

                lblMaxTemp.Text = currentWeather.main.maxTemperature.ToString() + "°C";
                lblMinTemp.Text = currentWeather.main.minTemperature.ToString() + "°C";

                lblWind.Text = currentWeather.wind.speed.ToString() + " km/h";
                lblHumidity.Text = currentWeather.main.humidity.ToString() + "%";

                lblSunrise.Text = sunrise.ToShortTimeString();
                lblSunset.Text = sunset.ToShortTimeString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            WeatherForecastUC forecastUC;

            foreach (var item in hourlyWeather.list)
            { 
                forecastUC = new WeatherForecastUC();   

                forecastUC.picWeatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + item.weather[0].icon + ".png";

                forecastUC.lblTemp.Text = item.main.temperature.ToString() + "°C";
                forecastUC.lblTime.Text = convertToDateTime(item.dt).ToShortTimeString();

                flpHourlyWeather.Controls.Add(forecastUC);

            }
        }


        public DateTime convertToDateTime(int millisecDate)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            dt = dt.AddSeconds(millisecDate).ToLocalTime();

            return dt;
        }
    }
}
