﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderstatuDetail
    {
        public int id { get; set; }
        public string status { get; set; }

        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}
