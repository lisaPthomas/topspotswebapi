﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TopSpotsAPI.Controllers
{
    public class NameController : ApiController //controller is inheriting from API Controller
    {
        public string GetName()
        {
            return "Lisa Parola";
        }
    }
}
