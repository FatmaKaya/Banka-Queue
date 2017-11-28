using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class BKPriorityArrayTypedQueueBK : IQueue
    {
        public Musteri[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;
        public int toplamSure = 0;

        public BKPriorityArrayTypedQueueBK(int size)
        {
            this.size = size;
            Queue = new Musteri[size];
        }

        public void Insert(Musteri m)
        {

            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = m;
                count++;
            }
            else
            {
                int i;

                for (i = count - 1; i >= 0; i--)
                {
                    if (((Musteri)m).IslemSuresi > ((Musteri)Queue[i]).IslemSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = m;
                front++;
                count++;
            }
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public int IslemTamamlanmaSuresi(int ISuresi)
        {
            toplamSure += ISuresi;
            return toplamSure;
        }

        public string Listele()
        {
            string temp = "";
            for (int i = 0; i < 20; i++)
            {
                temp += "Sıra No: " + ((Musteri)Queue[i]).SiraNo.ToString() + "    İşlem Suresi: " + ((Musteri)Queue[i]).IslemSuresi.ToString() +
                    "    İşlem Tamamlanma Süresi: " + IslemTamamlanmaSuresi(((Musteri)Queue[i]).IslemSuresi) + Environment.NewLine;
            }
            return temp;
        }

        public decimal OrtIslemTamamlanmaSuresi()
        {
            decimal ortITSuresi = toplamSure / 20;
            return ortITSuresi;
        }

        public Musteri Peek()
        {
            return (Musteri)Queue[front];
        }

        public Musteri Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            Musteri temp = (Musteri)Queue[front];
            Queue[front] = null;
            front--;
            count--;

            return temp;
        }

    }
}
