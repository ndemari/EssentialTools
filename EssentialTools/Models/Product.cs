﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Desctiption { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
