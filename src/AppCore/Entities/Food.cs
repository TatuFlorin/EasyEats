﻿using AppCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Entities
{
    public class Food
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }

        //public int OrderDetailsId { get; set; }
        //public OrderDetails OrderDetails { get; set; }

    }
}