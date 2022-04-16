<<<<<<< HEAD
﻿using _03.Telephony.Interfaces;
using System;
using System.Linq;
using _03.Telephony.Exceptions;

namespace _03.Telephony.Models
{
    public class StationaryPhone : Phone
    {
        public override string Call(string phoneNumber)
        {
            base.Call(phoneNumber);
            return $"Dialing... {phoneNumber}";
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
    public class StationaryPhone : Phone
    {
        public override string Call(string phoneNumber)
        {
            base.Call(phoneNumber);
            return $"Dialing... {phoneNumber}";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
