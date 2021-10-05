﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_ComputerStore.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
