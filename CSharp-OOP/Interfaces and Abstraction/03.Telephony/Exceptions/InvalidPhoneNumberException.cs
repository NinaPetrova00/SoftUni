using System;
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
