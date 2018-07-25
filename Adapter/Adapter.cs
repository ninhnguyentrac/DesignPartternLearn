using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : ITarget
    {
      private Adaptee _adaptee = new Adaptee();
    
      public void Request()
      {
        _adaptee.SpecificRequest();
      }
    }
}
