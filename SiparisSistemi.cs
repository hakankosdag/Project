using System;
using System.Collections.Generic;
using System.Text;

namespace Cayci
{
    class SiparisSistemi
    {
        private Boolean siparis;
        private Boolean odeme;
        private static SiparisSistemi ornek;
        private SiparisSistemi()
        {
            siparis = true;
            odeme = false;
        }
        //
        public static SiparisSistemi GetSiparis()
        {
            if (ornek == null)
            {
                ornek = new SiparisSistemi();
                Console.WriteLine("   ------  Sipariş oluşturuldu-------\n\n");
            }
            return ornek;
        }
        private Boolean siparisVarmi()
        {
            return siparis;
        }
        private Boolean odemeVarmı()
        {
            return odeme;
        }
        public void SiparisAl()
        {
            if (siparisVarmi())
            {
                Console.WriteLine("   ------  Siparis Alınıyor  -------");
                siparis = false;
            }
        }
        public void ode()
        {
            if (!siparisVarmi() && !odemeVarmı())
            {
                Console.WriteLine("Odeme yapılıyor..\n"+"Odemeniz icin tesekkur eder yine bekleriz.");
                odeme = true;
            }
        }
        public void temizle()
        {
            siparis = true;
            odeme = false;
        }
    }
}
