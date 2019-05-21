using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Web
{
    public class WelcomeService : IWelcomeService
    {
        public string SayHello(string name)
        {
            return $"my name is {name},hello everyone nice to meet you~~";
        }
        public string GetMessage()
        {
            return "welcome !!!!";
        }
    }
}
