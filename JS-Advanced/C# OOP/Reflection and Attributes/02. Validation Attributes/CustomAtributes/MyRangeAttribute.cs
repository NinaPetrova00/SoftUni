<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.CustomAtributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this._minValue = minValue;
            this._maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException("Invalid data type");
            }

            int valueAsInt = (int)obj;
            bool isInRange = valueAsInt >= _minValue && valueAsInt <= _maxValue;

            if (!isInRange)
            {
                return false;
            }

            return true;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.CustomAtributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this._minValue = minValue;
            this._maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException("Invalid data type");
            }

            int valueAsInt = (int)obj;
            bool isInRange = valueAsInt >= _minValue && valueAsInt <= _maxValue;

            if (!isInRange)
            {
                return false;
            }

            return true;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
