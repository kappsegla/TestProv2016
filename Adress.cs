using System;
using System.Collections.Generic;
using System.Linq;

namespace Prov2016
{
    public class Adress
    {
        public string Namn { get; set; }
        public string Postadress { get; set; }

        public Adress(string adress)
        {
            string[] rader = adress.Split('\n');
            //TODO: add more code
            throw new NotImplementedException();
        }
    }
}
