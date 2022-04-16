<<<<<<< HEAD
﻿namespace ValidationAttributes
{
    using System;
    using ValidationAttributes.Models;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
             (
                 null,
                 -1
             );

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
=======
﻿namespace ValidationAttributes
{
    using System;
    using ValidationAttributes.Models;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
             (
                 null,
                 -1
             );

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
