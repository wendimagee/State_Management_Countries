using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace State_Management_Colors.Models
{
    public class Country
    {
        public string Name { get; set; }
        public List<string> OfficialLanguage { get; set; } = new List<string>();

        public string HelloWorld { get; set; }

        public string Description { get; set; }
        public List<string> NationalColors { get; set; } = new List<string>();
        //You need the empty constructor since .Net like to use them 
        //IE with entity or with pass models up from forms
        public Country()
        {

        }

        //You may still have a regular constructor as long as you still leave in an empty constructor 
        public Country(string Name, List<string> OfficialLanguages, string Greeting, List<string> Colors, string Description)
        {
            this.Name = Name;
            this.OfficialLanguage = OfficialLanguages;
            this.HelloWorld = Greeting;
            this.NationalColors = Colors;
            this.Description = Description;
        }
    }

}
