using System;
using System.Collections.Generic;
using System.Text;

namespace Cayci
{
    public class arayuz
    {
        public CayDukkan yenicay;
        public Caylar yenicay1;
        SiparisSistemi siparis;

        public arayuz()
        { 
        }
        public void anaMenu()
        {
            while(true)
            {
                Console.WriteLine(" ANA MENU \n" +
                                 "   a - Siparis Ver\n"+
                                 "   b - Cıkıs\n ");
                char secim;
                secim = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (secim)
                { 
                    case 'a':
                        siparis = SiparisSistemi.GetSiparis();
                        siparis.SiparisAl();
                        siparisMenu();
                        break;
                    case 'b':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }

        }
        
        private void exit(int p)
        {
            throw new NotImplementedException();
        }
        public void siparisMenu()
        { 
            Console.WriteLine("\nHangi Turde Cay Siparisi Vermek Istersiniz? \n"+
                              "    a - Turk Usulu Cay Siparisi Ver\n"+
                              "    b - Çin Usulu Cay Siparisi Ver \n"+
                              "    c - Hint Usulu Cay Siparisi Ver \n"+
                              "    d - Japon Usulu Cay Siparisi Ver \n");
            char secim;
            secim = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 'a':
                    yenicay = new TurkCayDukkan();
                    TurkCaySiparisiEkrani(yenicay);
                    break;
                case 'b':
                    yenicay = new CinCayDukkan();
                    CinCaySiparisiEkrani(yenicay);
                    break;
                case 'c':
                    yenicay = new HintCayDukkan();
                    HintCaySiparisiEkrani(yenicay);
                    break;
                case 'd':
                    yenicay = new JaponCayDukkan();
                    JaponCaySiparisiEkrani(yenicay);
                    break;
                default:
                    break;
            }
        }
        public void TurkCaySiparisiEkrani(CayDukkan Yenicay)
        {
            Console.WriteLine("  TURK USULU CAYLAR\n"+
                              "    a - Turk Usulu Siyah Cay -> $3\n"+
                              "    b - Turk Usulu Yesil Cay -> $5 \n"+
                              "    c - Turk Usulu Beyaz Cay -> $8 \n");
            Console.WriteLine("----------------------------------");
            char secim;
            secim = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (secim)
            { 
                case 'a':
                    Yenicay.caySipairsi("Siyah cay");
                    yenicay1 = new SiyahCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'b':
                    Yenicay.caySipairsi("Yesil cay");
                    yenicay1 = new YesilCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'c':
                    Yenicay.caySipairsi("Beyaz cay");
                    yenicay1 = new BeyazCay();
                    AromaEkrani(yenicay1);
                    break;
                default:
                    break;
            }
        }
        public void CinCaySiparisiEkrani(CayDukkan Yenicay)
        {
            Console.WriteLine("   ÇİN USULU CAYLAR\n" +
                              "    a - Çin Usulu Siyah Cay -> $3\n" +
                              "    b - Çin Usulu Yesil Cay -> $5\n" +
                              "    c - Çin Usulu Beyaz Cay -> $8\n");
            Console.WriteLine("----------------------------------");
            char secim;
            secim = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 'a':
                    Yenicay.caySipairsi("Siyah cay");
                    yenicay1= new SiyahCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'b':
                    Yenicay.caySipairsi("Yesil cay");
                    yenicay1 = new YesilCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'c':
                    Yenicay.caySipairsi("Beyaz cay");
                    yenicay1 = new BeyazCay();
                    AromaEkrani(yenicay1);
                    break;
                default:
                    break;
            }
        }
        public void JaponCaySiparisiEkrani(CayDukkan Yenicay)
        {
            Console.WriteLine("   JAPON USULU CAYLAR\n" +
                              "     a - Japon Usulu Siyah Cay -> $3\n" +
                              "     b - Japon Usulu Yesil Cay -> $5\n" +
                              "     c - Japon Usulu Beyaz Cay -> $8\n");
            Console.WriteLine("----------------------------------");
            char secim;
            secim = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 'a':
                    Yenicay.caySipairsi("Siyah cay");
                    yenicay1 = new SiyahCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'b':
                    Yenicay.caySipairsi("Yesil cay");
                    yenicay1 = new YesilCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'c':
                    Yenicay.caySipairsi("Beyaz cay");
                    yenicay1 = new BeyazCay();
                    AromaEkrani(yenicay1);
                    break;
                default:
                    break;
            }
        }
        public void HintCaySiparisiEkrani(CayDukkan Yenicay)
        {
            Console.WriteLine("   HINT USULU CAYLAR\n" +
                              "    a - Hint Usulu Siyah Cay -> $3\n" +
                              "    b - Hint Usulu Yesil Cay -> $5\n" +
                              "    c - Hint Usulu Beyaz Cay -> $8\n");
            Console.WriteLine("----------------------------------");
            char secim;
            secim = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 'a':
                    Yenicay.caySipairsi("Siyah cay");
                    yenicay1 = new SiyahCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'b':
                    Yenicay.caySipairsi("Yesil cay");
                    yenicay1 = new YesilCay();
                    AromaEkrani(yenicay1);
                    break;
                case 'c':
                    Yenicay.caySipairsi("Beyaz cay");
                    yenicay1 = new BeyazCay();
                    AromaEkrani(yenicay1);
                    break;
                default:
                    break;
            }
        }
        public void AromaEkrani(Caylar yenicay1)
        {
            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine(" Hangi Aromayı Eklemek Istersiniz\n"+
                             "    a - Seker        -> $0\n"+
                             "    b - Karanfil     -> $1\n"+
                             "    c - Zencefil     -> $1\n"+
                             "    d - Tarcin       -> $0.75\n"+
                             "    e - Nane         -> $0.50\n"+
                             "    f - Karabiber    -> $0,50\n"+
                             "    g - Limon Kekiği -> $0.75\n"+
                             "    h - Limon        -> $0.50\n"+
                             "    ı - Hicbiri\n");
            
            char secim;
            secim = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (secim)
            { 
                case 'a':
                    yenicay1 = new Seker(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'b':
                    yenicay1 = new Karanfil(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'c':
                    yenicay1 = new Zencefil(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'd':
                    yenicay1 = new Tarcin(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'e':
                    yenicay1 = new Nane(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'f':
                    yenicay1 = new Karabiber(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'g':
                    yenicay1 = new LimonKekigi(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'h':
                    yenicay1 = new Limon(yenicay1);
                    Console.WriteLine(yenicay1.GetCay() + "" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                case 'ı':
                    Console.WriteLine(yenicay1.GetCay() + "\n  Tutar:" + yenicay1.GetFiyat());
                    siparis.ode();
                    siparis.temizle();
                    Console.WriteLine("\n-----------------------------------\n");
                    break;
                default:
                    break;
            }
            
        }
        
    }
}
