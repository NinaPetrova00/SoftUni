using _03.Telephony.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.Telephony.Exceptions;

namespace _03.Telephony.Models
{
    public abstract class Phone : ICallable
    {
        public virtual string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }
            return "";
        }
    }
}
