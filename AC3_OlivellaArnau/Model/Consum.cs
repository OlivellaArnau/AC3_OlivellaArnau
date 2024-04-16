﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC3_OlivellaArnau.Model
{
    public class Consum
    {
        public int Any { get; set; }
        public int CodiComarca { get; set; }
        public string? Comarca { get; set; }
        public int Poblacio { get; set; }
        public int DomesticXarxa { get; set; }
        public int Activitats { get; set; }
        public int Total { get; set; }
        public float ConsumDomesticPC { get; set; }
    }
}
