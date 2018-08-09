using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Decorator;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Beverage beverage = new Espresso();
			Console.WriteLine($"{beverage.getDescription()} ${beverage.cost()}");
			Beverage beverageEspresso = new Espresso();
			beverageEspresso = new Mocha(beverageEspresso);
			beverageEspresso = new Mocha(beverageEspresso);
			beverageEspresso = new Whip(beverageEspresso);
			Console.WriteLine($"{beverageEspresso.getDescription()} ${beverageEspresso.cost()}");
			Beverage beverageHouseBlend = new HouseBlend();
			beverageHouseBlend = new Mocha(beverageHouseBlend);
			beverageHouseBlend = new Mocha(beverageHouseBlend);
			beverageHouseBlend = new Whip(beverageHouseBlend);
			Console.WriteLine($"{beverageHouseBlend.getDescription()} ${beverageHouseBlend.cost()}");
			Console.ReadKey();
		}
	}
}
