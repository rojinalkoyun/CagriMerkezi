using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV_1
{
    public class Arama:AramalarADT
    {
        public DateTime AramaZamani { get; set; }
        private object[] aramalar;
        private int front = -1;
        private int rear = -1;
        private int size = 100;
        private int count = 0;
        public Arama(int size)
        {
            this.size = size;
            aramalar = new object[size];
        }
        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Arama dolu.");
            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                aramalar[rear] = o;
            }
            else
                aramalar[++rear] = o;
            count++;
            
        }
        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Arama yok.");

            object temp = aramalar[front];
            aramalar[front] = null;
            if (front == size - 1)
                front = 0;
            else
                front++;
            count--;
            return temp;
        }
        public object Peek()
        {
            return aramalar[rear];
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }
        public string EkranaYaz()
        {
            string temp = "";
            temp = count + ")" + Peek().ToString() + "  Id li müşteri  " + this.AramaZamani.ToString();
            return temp;
        }
        public string Listele()
        {
            string temp = "";
            int Countt = front;
            while (Countt <= rear)
            {
                temp += aramalar[Countt] + "-->";
                Countt++;
            }
            return temp;

        }
        public object CagriDon()
        {
            return aramalar[front];

        }


    }
}
