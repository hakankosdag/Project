using System;
using System.Collections.Generic;
using System.Text;

namespace Cayci
{
    public abstract class CayDukkan
    {
        public Cay caySipairsi(string cayTuru)
        {
            Cay cay = cayYap(cayTuru);
            cay.hazirla();
            cay.demle();
            cay.sevis();

            return cay;
        }
        protected abstract Cay cayYap(string cayTuru);
    }

    public class TurkCayDukkan : CayDukkan
    {
        protected override Cay cayYap(string cayTuru)
        {
            Cay cay = null;

            if (cayTuru == "Siyah cay")
                cay = new TurkUsuluSiyahCay();
            else if (cayTuru == "Yesil cay")
                cay = new TurkUsuluYesilCay();
            else if (cayTuru == "Beyaz cay")
                cay = new TurkUsuluIhlamur();

            return cay;
        }
    }
    public class CinCayDukkan : CayDukkan
    {
        protected override Cay cayYap(string cayTuru)
        {
            Cay cay = null;

            if (cayTuru == "Siyah cay")
                cay = new CinUsuluSiyahCay();
            else if (cayTuru == "Yesil cay")
                cay = new CinUsuluYesilCay();
            else if (cayTuru == "Beyaz cay")
                cay = new CinUsuluBeyazCay();

            return cay;
        }
    }
    public class HintCayDukkan : CayDukkan
    {
        protected override Cay cayYap(string cayTuru)
        {
            Cay cay = null;

            if (cayTuru == "Siyah cay")
                cay = new HintUsuluSiyahCay();
            else if (cayTuru == "Yesil cay")
                cay = new HintUsuluYesilCay();
            else if (cayTuru == "Beyaz cay")
                cay = new HintUsuluBeyazCay();

            return cay;
        }
    }
    public class JaponCayDukkan : CayDukkan
    {
        protected override Cay cayYap(string cayTuru)
        {
            Cay cay = null;

            if (cayTuru == "Siyah cay")
                cay = new JaponUsuluSiyahCay();
            else if (cayTuru == "Yesil cay")
                cay = new JaponUsuluYesilCay();
            else if (cayTuru == "Beyaz cay")
                cay = new JaponUsuluBeyazCay();

            return cay;
        }
    }

}
