<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;
namespace _04.BorderControl.Models
{
    public class Robots : ISociety
    {
        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        //"{model} {id}" for robots

        public string Model { get; set; }
        public string Id { get; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using _04.BorderControl.Interfaces;
namespace _04.BorderControl.Models
{
    public class Robots : ISociety
    {
        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        //"{model} {id}" for robots

        public string Model { get; set; }
        public string Id { get; }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
