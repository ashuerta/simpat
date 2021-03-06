﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASHM.Common.Entities
{
    public class Normal : IFizzBuzz
    {
        public int MaxEdge { get; set; }

        public int MinEdge { get; set; }

        public Normal()
        {
            MinEdge = 1;
            MaxEdge = 100;
        }

        public List<string> Get()
        {
            var r = new List<string>();
            for (var i = MinEdge; i <= MaxEdge; i++)
            {
                var s = string.Empty;
                if ((i % 3) == 0) s += "Fizz";
                if ((i % 5) == 0) s += "Buzz";
                r.Add(!string.IsNullOrEmpty(s) ? s : i.ToString(CultureInfo.InvariantCulture));
            }
            return r;
        }
    }
}
