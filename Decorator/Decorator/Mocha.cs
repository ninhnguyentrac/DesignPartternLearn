using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class Mocha : CondimentDecorator
	{
		protected Beverage beverage;
		public Mocha(Beverage beverage)
		{
			this.beverage = beverage;
		}

		public override string getDescription()
		{
			return beverage.getDescription() + ", Mocha";
		}

		public override double cost()
		{
			return beverage.cost() + 0.29;
		}
	}
}
