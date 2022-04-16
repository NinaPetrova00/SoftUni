<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price,double grams) 
            : base(name, price)
        {
            this.Grams = grams; 
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price,double grams) 
            : base(name, price)
        {
            this.Grams = grams; 
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
