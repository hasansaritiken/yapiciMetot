using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapiciMetot
{
    class kisi
    {
        int yas;
        string ad;
        public kisi()
        {
            yas = 15;
            ad = "LEVENT YANIK";
            Console.WriteLine("Yapıcı metot çalıştı");
        }
        public int Yas
        {
            get
            {
                return yas;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");
            kisi k = new kisi();
            Console.WriteLine( "Adı: {0}, Yaşı: {1}", k.Ad, k.Yas);
            Console.WriteLine("Program bitti.");
        }
    }
}
