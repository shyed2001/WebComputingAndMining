using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authetication1.Models
{
    public class RegisterModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public string ConPassword { get; set; }
    }
}
