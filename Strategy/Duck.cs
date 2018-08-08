using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;

namespace Strategy
{
	public abstract class Duck
	{
		protected IFly flyBehavior;
		public void Swim()
		{
			System.Console.WriteLine("All ducks float, even decoys!");
		}
		public abstract void Display();

		public void PerformFly()
		{
			flyBehavior.Fly();
		}

		public void setFlyBehavior(IFly iFly)
		{
			flyBehavior = iFly;
		}
	}
}
