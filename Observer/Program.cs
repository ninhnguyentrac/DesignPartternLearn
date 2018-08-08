using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Implement;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();
			CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

			weatherData.setMeasurements(80, 65, 30.4f);
			weatherData.setMeasurements(82, 70, 29.2f);
			weatherData.setMeasurements(78, 90, 29.2f);
			Console.ReadKey();
		}
	}
}
