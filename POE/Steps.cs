using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POE
{
    class Stepss
    {
        private string? description;

        public Stepss(string Description) 
        {
            description = Description;
        }
        public Stepss() { }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

       
    }
}
