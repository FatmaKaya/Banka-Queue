using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Banka
    {
        public CircularArrayTypedQueue Musteriler = new CircularArrayTypedQueue(20);
        public KBPriorityArrayTypedQueueKB KBMusteriler = new KBPriorityArrayTypedQueueKB(20);
        public BKPriorityArrayTypedQueueBK BKMusteriler = new BKPriorityArrayTypedQueueBK(20);
        Random rastgele = new Random();

        public Banka()
        {
            for (int i = 0; i < 20; i++)
            {
                Musteri m = new Musteri();
                m.SiraNo =i+1;
                m.IslemSuresi = rastgele.Next(60, 600);
                Musteriler.Insert(m);
                KBMusteriler.Insert(m);
                BKMusteriler.Insert(m);
            }
           
        }

        public string SıralamaKB()
        {
            string temp = "";
            Musteriler.toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                KBMusteriler.toplamSure = 0;
                int mToplamSure = Musteriler.IslemTamamlanmaSuresi(((Musteri)Musteriler.Queue[i]).IslemSuresi);
                for (int j = 0; j < 20; j++)
                {
                    int KBmToplamSure = KBMusteriler.IslemTamamlanmaSuresi(((Musteri)KBMusteriler.Queue[j]).IslemSuresi);
                    if (((Musteri)KBMusteriler.Queue[i]).SiraNo == i + 1)
                    {
                        if (KBmToplamSure < mToplamSure)
                        {
                            temp += "Sıra No: " + ((Musteri)KBMusteriler.Queue[i]).SiraNo.ToString() + "    İşlem Suresi: " + ((Musteri)KBMusteriler.Queue[i]).IslemSuresi.ToString() +
                                "   Kazanç: " + (mToplamSure - KBmToplamSure).ToString() + "   Yüzde: " + ((KBmToplamSure * 100) / mToplamSure) + "\n";
                        }
                        break;
                    }
                }
            }
            return temp;
        }

        public string SıralamaBK()
        {
            string temp = "";
            Musteriler.toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                BKMusteriler.toplamSure = 0;
                int mToplamSure = Musteriler.IslemTamamlanmaSuresi(((Musteri)Musteriler.Queue[i]).IslemSuresi);
                for (int j = 0; j < 20; j++)
                {
                    int BKmToplamSure = BKMusteriler.IslemTamamlanmaSuresi(((Musteri)BKMusteriler.Queue[j]).IslemSuresi);
                    if (((Musteri)KBMusteriler.Queue[i]).SiraNo == i + 1)
                    {
                        if (BKmToplamSure < mToplamSure)
                        {
                            temp += "Sıra No: " + ((Musteri)BKMusteriler.Queue[i]).SiraNo.ToString() + "    İşlem Suresi: " + ((Musteri)BKMusteriler.Queue[i]).IslemSuresi.ToString() +
                                "   Kazanç: " + (mToplamSure - BKmToplamSure).ToString() + "   Yüzde: " + ((BKmToplamSure * 100) / mToplamSure) + "\n";
                        }
                        break;
                    }
                }
            }
            return temp;
        }

    }
}
