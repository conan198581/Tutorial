using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Web.Controllers
{
    [Route("v2/[controller]")]
    public class AboutController
    {
        [Route("myname")]
        public string Me()
        {
            return "dave";
        }

        [Route("[action]")]
        public string SayHi()
        {
            return "hello,hi,nice to meet you";
        }
    }
}
