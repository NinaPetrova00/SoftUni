<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Tuple<TFirst,TSecond, TThird>
    {
        public Tuple(TFirst firstElement,TSecond secondElement,TThird thirdElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
            ThirdElement = thirdElement;
        }
        public TFirst FirstElement { get; private set; }
        public TSecond SecondElement { get; private set; }
        public TThird ThirdElement { get; private set; }

        
        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Tuple<TFirst,TSecond, TThird>
    {
        public Tuple(TFirst firstElement,TSecond secondElement,TThird thirdElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
            ThirdElement = thirdElement;
        }
        public TFirst FirstElement { get; private set; }
        public TSecond SecondElement { get; private set; }
        public TThird ThirdElement { get; private set; }

        
        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
