using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_1
{
    public class TicariMT:MusteriTemsilcisi
    {
        private object[] items;
        int itemCount = 2;
        public TicariMT()
        {
            this.items = new object[this.itemCount];
        }
    }
}
