using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl.Interfaces
{
    public interface IBuyer
    {
        public string Name { get; }
        public int Food { get; }
        public void BuyFood();
    }
}
