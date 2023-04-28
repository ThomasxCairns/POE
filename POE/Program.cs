using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace POE
{
    class ingredients
    {
        private string? name;
        private Double? quantity;
        private string? unit;
        public ingredients(string Name, Double Quantity, string Unit)
        {
            name= Name;
            quantity = Quantity;
            unit = Unit;

        }
        public ingredients()
        {

        }

        public string Name
        {
            get { return name; }
            set {  name = value; }
        }

        public Double Quantity
        {
            get { return (double)quantity; }
            set { quantity = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value;}
        }

       
    }
}
