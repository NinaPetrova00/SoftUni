<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string Invalid_Number_Exception_Message = "Invalid number!";
        public InvalidPhoneNumberException()
            :base(Invalid_Number_Exception_Message)
        {

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string Invalid_Number_Exception_Message = "Invalid number!";
        public InvalidPhoneNumberException()
            :base(Invalid_Number_Exception_Message)
        {

        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
