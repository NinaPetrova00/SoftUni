<<<<<<< HEAD
﻿namespace ValidationAttributes.Models
{
    using System;
    using System.Reflection;
    using ValidationAttributes.CustomAtributes;
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj
                 .GetType()
                 .GetProperties();

            foreach (PropertyInfo property in properties)
            {

                MyValidationAttribute customAttribute = (MyValidationAttribute)property
                     .GetCustomAttribute(typeof(MyValidationAttribute), false);

                bool isValid = customAttribute.IsValid(property.GetValue(obj));

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
=======
﻿namespace ValidationAttributes.Models
{
    using System;
    using System.Reflection;
    using ValidationAttributes.CustomAtributes;
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj
                 .GetType()
                 .GetProperties();

            foreach (PropertyInfo property in properties)
            {

                MyValidationAttribute customAttribute = (MyValidationAttribute)property
                     .GetCustomAttribute(typeof(MyValidationAttribute), false);

                bool isValid = customAttribute.IsValid(property.GetValue(obj));

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
