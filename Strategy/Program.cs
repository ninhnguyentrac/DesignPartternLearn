using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Implement;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck duck = new MiniDuckSimulator();
			duck.PerformFly();
			duck.setFlyBehavior(new FlyWithWings());
			duck.PerformFly();
			Console.ReadKey();
		}
	}
}
