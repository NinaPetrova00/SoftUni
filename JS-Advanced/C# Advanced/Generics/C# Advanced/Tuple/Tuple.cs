<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Tuple<TFirst,TSecond>
    {
        public Tuple(TFirst firstElement,TSecond secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }
        public TFirst FirstElement { get; private set; }
        public TSecond SecondElement { get; private set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Tuple<TFirst,TSecond>
    {
        public Tuple(TFirst firstElement,TSecond secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }
        public TFirst FirstElement { get; private set; }
        public TSecond SecondElement { get; private set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
