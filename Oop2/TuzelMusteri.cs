using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //miras == inheritance (Tüzel müşteri bir müşteridir)
    class TuzelMusteri: Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
