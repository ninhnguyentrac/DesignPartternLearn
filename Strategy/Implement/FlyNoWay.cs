using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;

namespace Strategy.Implement
{
	public class FlyNoWay : IFly
	{
		public void Fly()
		{
			Console.WriteLine("I can't fly");
		}
	}
}
