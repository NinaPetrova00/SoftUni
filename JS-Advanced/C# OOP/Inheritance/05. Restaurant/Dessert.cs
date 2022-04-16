<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams,double calories)
            : base(name, price, grams)
        {
            this.Calories = calories;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams,double calories)
            : base(name, price, grams)
        {
            this.Calories = calories;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
