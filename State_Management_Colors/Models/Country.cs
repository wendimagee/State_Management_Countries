using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace State_Management_Colors.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string[] OfficialLanguages { get; set; }

        public string HelloWorld { get; set; }

        public string Description { get; set; }
        public string[] NationalColors { get; set; }

    }
}
