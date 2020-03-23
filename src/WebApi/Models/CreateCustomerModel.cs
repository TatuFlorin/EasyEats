﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CreateCustomerModel
    {
        public string Id { get; private set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public int Phone { get; set; }
    }
}