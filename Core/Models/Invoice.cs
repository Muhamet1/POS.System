﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public double? Tax { get; set; }
        public double? Total { get; set; }
        public List<Item> Items { get; set; }   
    }
}