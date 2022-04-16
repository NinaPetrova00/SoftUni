<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
