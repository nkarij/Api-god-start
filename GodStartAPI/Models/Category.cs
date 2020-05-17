﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodStartAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool selected { get; set; }
        public int UserId { get; set; }
        public StoreUser User { get; set; }
        public ICollection<Job> JobList { get; set; }

    }
}
