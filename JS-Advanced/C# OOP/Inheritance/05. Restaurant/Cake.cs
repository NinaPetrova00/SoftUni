<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;
        private const decimal DefaultPrice = 5m;

        public Cake(string name)
            : base(name, DefaultPrice, DefaultGrams, DefaultCalories)
        {
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;
        private const decimal DefaultPrice = 5m;

        public Cake(string name)
            : base(name, DefaultPrice, DefaultGrams, DefaultCalories)
        {
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
