using System;

namespace Adapter
{
  class Program
  {
    static void Main(string[] args)
    {
      ITarget target = new Adapter();
      target.Request();
      Console.ReadKey();
    }
  }
}
