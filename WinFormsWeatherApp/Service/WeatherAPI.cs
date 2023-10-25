using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsWeatherApp.Models;

namespace WinFormsWeatherApp.Service
{
    public class WeatherAPI
    {
        string APIKey;
        WeatherForecast.Root response;
        WeatherClasses.Root results;

        public WeatherAPI()
        {
            APIKey = "3c9bf5d798ffc7b169375975aef87f34";
            response = null;
            results = null;
        }

        public WeatherClasses.Root GetWeatherByCity(string city) // Method to retrieve and deserialize the json response from the openweathermap API
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", city, APIKey);
                    var json = web.DownloadString(url);

                    results = JsonConvert.DeserializeObject<WeatherClasses.Root>(json);
                }

            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
         return results;
        }

        public WeatherForecast.Root GetWeatherForecast(double latitude, double longitude) // Method to retrieve and deserialize the json response from the openweathermap API
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid={2}", latitude, longitude, APIKey);
                    var json = web.DownloadString(url);

                    response = JsonConvert.DeserializeObject<WeatherForecast.Root>(json);
                }
               
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return response;
        }
    }
}
