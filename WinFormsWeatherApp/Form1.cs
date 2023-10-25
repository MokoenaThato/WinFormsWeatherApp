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
using System.Runtime.InteropServices;

namespace WinFormsWeatherApp
{
    public partial class MainPageForm : Form
    {
        private WeatherAPI serv;
        private double longitude;
        private double latitude;
        private DateTime sunrise;
        private DateTime sunset;
        private string city;

        public MainPageForm()
        {
            InitializeComponent();
            serv = new WeatherAPI();
            longitude = 0.00;
            latitude = 0.00;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            city = tbCityName.Text;

            if (city != null)
            {
                lblCondition.Text = "";
                lblDescription.Text = "";

                WeatherClasses.Root currentWeather = serv.GetWeatherByCity(city); // call to the GetWeatherByCity method in the WeatherAPI class

                latitude = currentWeather.coord.lat;
                longitude = currentWeather.coord.lon;

                WeatherForecast.Root ThreeHourWeather = serv.GetWeatherForecast(latitude, longitude); // call to the GetWeatherForecast method in the WeatherAPI class

                GetCurrWeather(currentWeather);
                GetThreeHourWeather(ThreeHourWeather);
            }
            else 
            {
                MessageBox.Show("Please Enter City Name");
            } 
        }

        public void GetCurrWeather(WeatherClasses.Root currWeather)// Method to call the API to get the current weather forcast accodrding to city name
        {
            try
            {
                lblCityName.Text = currWeather.name;
                lblTemp.Text = currWeather.main.temperature.ToString() + "°C";

                sunrise = convertToDateTime(currWeather.sys.sunrise);
                sunset = convertToDateTime(currWeather.sys.sunset);

                weatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + currWeather.weather[0].icon + ".png";

                lblCondition.Text = currWeather.weather[0].main;
                lblDescription.Text = currWeather.weather[0].description;

                lblMaxTemp.Text = currWeather.main.maxTemperature.ToString() + "°C";
                lblMinTemp.Text = currWeather.main.minTemperature.ToString() + "°C";

                lblWind.Text = currWeather.wind.speed.ToString() + " km/h";
                lblHumidity.Text = currWeather.main.humidity.ToString() + "%";

                lblSunrise.Text = sunrise.ToShortTimeString();
                lblSunset.Text = sunset.ToShortTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetThreeHourWeather(WeatherForecast.Root ThreeHourWeather) // Method to call the API and get the 3-Hour weather forcast according to city coordinates
        {
            try
            {
                WeatherForecastUC forecastUC;

                foreach (var item in ThreeHourWeather.list)
                {
                    forecastUC = new WeatherForecastUC();

                    forecastUC.picWeatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + item.weather[0].icon + ".png";

                    forecastUC.lblTemp.Text = item.main.temperature.ToString() + "°C";
                    forecastUC.lblTime.Text = convertToDateTime(item.dt).ToShortTimeString();
                    forecastUC.label3.Text = item.weather[0].description;

                    flpHourlyWeather.Controls.Add(forecastUC);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DateTime convertToDateTime(int millisecDate) // Method to convert the json date to local date time
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            dt = dt.AddSeconds(millisecDate).ToLocalTime();

            return dt;
        }
    }
}
