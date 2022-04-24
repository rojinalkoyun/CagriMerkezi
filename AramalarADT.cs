using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_1
{
    public interface AramalarADT
    {
        void Insert(object o);
        object Remove();
        object Peek();
        Boolean IsEmpty();
        string EkranaYaz();
        string Listele();
        object CagriDon();
    }
}
