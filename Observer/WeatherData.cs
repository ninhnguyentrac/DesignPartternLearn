using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class WeatherData : ISubject
	{
		private ArrayList observers;
		private float temperature;
		private float humidity;
		private float pressure;

		public WeatherData()
		{
			observers = new ArrayList();
		}

		public void registerObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void removeObserver(IObserver observer)
		{
			int observerItem = observers.IndexOf(observer);
			if (observerItem >= 0)
			{
				observers.Remove(observerItem);
			}
		}

		public void notifyObservers()
		{
			for (int i = 0; i < observers.Count; i++)
			{
				IObserver observer = (IObserver)observers[i];
				observer.update(temperature, humidity, pressure);
			}
		}

		public void measurementsChanged()
		{
			notifyObservers();
		}

		public void setMeasurements(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			measurementsChanged();
		}
	}
}
