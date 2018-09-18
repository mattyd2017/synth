using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace synth.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
       
        public string Phone()
        {
            return "1237636473";
        }
        
        public string Address()
        {
            return "My house";
        }
    }
}
