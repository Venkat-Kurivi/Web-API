﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebAPI.Controllers
{
    public class UserController : ApiController
    {   
        public string GetUser()
        {
            return "Hanish";
        }
    }
}
