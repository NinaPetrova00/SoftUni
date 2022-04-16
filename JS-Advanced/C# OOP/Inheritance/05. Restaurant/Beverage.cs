<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public double Mililiters { get; set; }
        public Beverage(string name, decimal price, double mililiters)
            : base(name, price)
        {
            this.Mililiters = mililiters;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public double Mililiters { get; set; }
        public Beverage(string name, decimal price, double mililiters)
            : base(name, price)
        {
            this.Mililiters = mililiters;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
