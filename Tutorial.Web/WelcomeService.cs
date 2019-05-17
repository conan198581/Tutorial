using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Web
{
    public class WelcomeService : IWelcomeService
    {
        public string GetMessage()
        {
            return "welcome !!!!";
        }
    }
}
