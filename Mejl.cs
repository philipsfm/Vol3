﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vol2.Models;

namespace Vol2.Models
{
    public class Mejl
    {
        public int MejlID { get; set; }
        public string MejlAdresa { get; set; }
        public TipMejla TipMejla { get; set; }
        public int TipMejlaID { get; set; }
    }
}