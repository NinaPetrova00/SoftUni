<<<<<<< HEAD
﻿using _03.Telephony.Interfaces;
using System;
using System.Linq;
using _03.Telephony.Exceptions;

namespace _03.Telephony.Models
{
    public class Smartphone : Phone, IBrowsable
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";
        }

        public override string Call(string phoneNumber)
        {
            base.Call(phoneNumber);
            return $"Calling... {phoneNumber}";
        }
    }
}
=======
﻿using _03.Telephony.Interfaces;
using System;
using System.Linq;
using _03.Telephony.Exceptions;

namespace _03.Telephony.Models
{
    public class Smartphone : Phone, IBrowsable
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";
        }

        public override string Call(string phoneNumber)
        {
            base.Call(phoneNumber);
            return $"Calling... {phoneNumber}";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
