<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.CustomAtributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.CustomAtributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
