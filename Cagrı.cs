using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_1
{
    
    public class Cagrı
    {
        public int CagriId { get; set; }
        
        public string musteriTip { get; set; }

        public int MusteriID { get; set; }
        public MusteriTemsilcisi MT =new MusteriTemsilcisi();
        public TimeSpan CagriZamani;
        public TimeSpan CagriZamaniHesapla()
        {
            CagriZamani = MT.CagriBitmeZamani - MT.CagriBaslamaZamani;
            return CagriZamani;
        }
        





    }
}
