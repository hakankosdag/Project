using System;
using System.Collections.Generic;
using System.Text;

namespace Cayci
{
    public abstract class Caylar 
    {
        public string cay = "ismi yok";

        public virtual string GetCay()
        {
            return this.cay;
        }

        public abstract double GetFiyat();
    }

    public class SiyahCay : Caylar
    {
        public SiyahCay()
        {
            this.cay = "Siyah Cay";
        }
        public override double GetFiyat()
        {
            return 3.0;
        }
    }
    public class YesilCay : Caylar
    {
        public YesilCay()
        {
            this.cay= "Yesil Cay";
        }
        public override double GetFiyat()
        {
            return 5.00;
        }
    }
    public class BeyazCay : Caylar
    {
        public BeyazCay()
        {
            this.cay = "Beyaz Cay";
        }
        public override double GetFiyat()
        {
            return 8.00;
        }

    }

    public abstract class Aroma :Caylar
    {
    }
    public class Seker : Aroma
    {
        Caylar caylar;

        public Seker(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }

        public override string GetCay()
        {
            return "Sekerli " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }

        public override double GetFiyat()
        {
            return 0.00 + this.caylar.GetFiyat();
        }
    }
    public class Karanfil : Aroma
    {
        Caylar caylar;

        public Karanfil(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Karanfilli " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 1.00 + this.caylar.GetFiyat();
        }
    }
    public class Zencefil : Aroma
    {
        Caylar caylar;

        public Zencefil(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Zencefilli "+this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 1.00 + this.caylar.GetFiyat();
        }
    }
    public class Tarcin : Aroma
    {
        Caylar caylar;

        public Tarcin(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Tarcinli " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 0.75 + this.caylar.GetFiyat();
        }
    }
    public class Nane : Aroma 
    {
        Caylar caylar;

        public Nane(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Naneli " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 0.50 + this.caylar.GetFiyat();
        }
    }
    public class Karabiber : Aroma
    { 
        Caylar caylar;

        public Karabiber(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Karabiberli " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 0.50 + this.caylar.GetFiyat();
        }
    }
    public class LimonKekigi : Aroma
    { 
        Caylar caylar;

        public LimonKekigi(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Limon kekikli " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 0.75 + this.caylar.GetFiyat();
        }
    }
    public class Limon : Aroma
    {
        Caylar caylar;

        public Limon(Caylar yeniCay)
        {
            this.caylar = yeniCay;
        }
        public override string GetCay()
        {
            return "Limonlu " + this.caylar.GetCay() + " hazir afiyet olsun..\n " + " Tutar : $";
        }
        public override double GetFiyat()
        {
            return 0.50 + this.caylar.GetFiyat();
        }
        
    }
}