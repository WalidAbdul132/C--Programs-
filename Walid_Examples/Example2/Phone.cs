using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Phone
    {
        public string name;
        public int price;
        public string Company;

        public Phone(string aName, int aPrice, string aCompany) 
        { 
            name = aName;
            price = aPrice;
            Company = aCompany;
        }

        public string isExpensive()
        {
            if(price >= 100)
            {
                return "Expensive";
            }
            return "Not Expensive";
        }
    }
}
