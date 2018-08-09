using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class Beverage
	{
		protected string description = "Unknown Beverage";

		public abstract string getDescription();

		public abstract double cost();
	}
}
