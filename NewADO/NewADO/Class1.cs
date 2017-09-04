﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewADO
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string addURL { get; set; }
    }
}
