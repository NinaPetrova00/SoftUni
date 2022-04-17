using _03.Telephony.Interfaces;
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
