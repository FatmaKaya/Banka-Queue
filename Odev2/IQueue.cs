using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public interface IQueue
    {
        void Insert(Musteri m);
        Musteri Remove();
        Musteri Peek();
        Boolean IsEmpty();
        string Listele();
        int IslemTamamlanmaSuresi(int ISuresi);
        decimal OrtIslemTamamlanmaSuresi();
    }
}
