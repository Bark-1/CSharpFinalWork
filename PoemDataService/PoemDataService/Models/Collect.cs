﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemDataService.Models
{
   public class Collect
    {
        public int id { get; set; }
        public string account { get; set; }
        public int PoemId { get; set; }

        public Poem poem { get; set; }
    }
}
