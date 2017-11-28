using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class CircularArrayTypedQueue : IQueue
    {
        public Musteri[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public int toplamSure = 0;

        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new Musteri[size];
        }

        public void Insert(Musteri m)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = m;
            }
            else
                Queue[++rear] = m;

            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public Musteri Peek()
        {
            return (Musteri)Queue[front];
        }

        public Musteri Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");

            Musteri temp =(Musteri)Queue[front];
            Queue[front] = null;

            if (front == size - 1)
                front = 0;
            else
                front++;

            count--;

            return temp;
        }

        public decimal OrtIslemTamamlanmaSuresi()
        {
            decimal ortITSuresi = toplamSure / 20;
            return ortITSuresi;
        }

        public string Listele()
        {
            string temp = "";
            for (int i = 0; i < 20; i++)
            {
                temp += "Sıra No: " + ((Musteri)Queue[i]).SiraNo.ToString() + "    İşlem Suresi: " + ((Musteri)Queue[i]).IslemSuresi.ToString() +
                    "    İşlem Tamamlanma Süresi: " +IslemTamamlanmaSuresi(((Musteri)Queue[i]).IslemSuresi) + Environment.NewLine;
            }
            return temp;
        }

        public int IslemTamamlanmaSuresi(int ISuresi)
        {
            toplamSure += ISuresi;
            return toplamSure;
        }

    }
}
