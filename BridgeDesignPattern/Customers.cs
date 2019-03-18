using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    //refined abstraction class
    class Customers : CustomersBase
    {
        // Constructor

        public Customers(string group)
          : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines

            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
