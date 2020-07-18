using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_sConsoleApp
{
    class OtherHiredOne
    {
        public OtherHiredOne()
        {

        }

        public OtherHiredOne(string aad,string asoyad,string aaileveziyyeti)
        {
            this.ad = aad;
            this.soyad = asoyad;
            this.AileVeziyyeti = aaileveziyyeti;
        }

        public string ad { get; set; }
        public string soyad { get; set; }

        public string AileVeziyyeti { get; set; }
    }
}
