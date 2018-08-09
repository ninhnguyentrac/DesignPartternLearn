using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
	public class Whip : CondimentDecorator
	{
		private Beverage beverage;

		public Whip(Beverage beverage)
		{
			this.beverage = beverage;
		}
		public override string getDescription()
		{
			return beverage.getDescription() + ", Whip";
		}

		public override double cost()
		{
			return 1 + beverage.cost();
		}
	}
}
