﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace TopSpotsAPI.Models
{
    public class TopSpot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double[] Location { get; set; }
    }

    //public class Data
    //{
    //    public TopSpot data;
    //}

    //public class Target
    //{

    //}
}