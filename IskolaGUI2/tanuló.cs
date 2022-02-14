using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaGUI2
{
    class tanuló
    {
        public int Év { get; set; }
        public string Osztály { get; set; }
        public string Név { get; set; }
        public tanuló(string sor)
        {
            string[] x = sor.Split(';');
            Év = int.Parse(x[0]);
            Osztály = x[1];
            Név = x[2];
        }
    }
}
