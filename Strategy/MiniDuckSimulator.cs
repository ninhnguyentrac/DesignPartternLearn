using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Implement;

namespace Strategy
{
	public class MiniDuckSimulator : Duck
	{
		public MiniDuckSimulator()
		{
			flyBehavior = new FlyNoWay();
		}
		public override void Display()
		{
			Console.WriteLine("Display Mini Ducks");
		}
	}
}
