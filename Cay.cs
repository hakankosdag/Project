using System;
using System.Collections.Generic;
using System.Text;

namespace Cayci
{
    public abstract class Cay
    {
        public virtual void hazirla()
        {
            Console.WriteLine("Cay hazirlaniyor...");
        }
        public virtual void demle()
        {
            Console.WriteLine("Demleniyor...");
        }
        public virtual void sevis()
        {
            Console.WriteLine("Servis edilmek için hazirlaniyor...");
        }
    }

    public class TurkUsuluSiyahCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Turk usulu siyah cay hazirlaniyor...");
        }
    }
    public class TurkUsuluYesilCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Turk usulu yesil cay hazirlaniyor...");
        }
    }
    public class TurkUsuluIhlamur: Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Turk usulu beyaz cay hazirlaniyor...");
        }
    }
    public class CinUsuluSiyahCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Çin usulu siyah cay hazirlaniyor...");
        }
    }
    public class CinUsuluYesilCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Çin usulu yesil cay hazirlaniyor...");
        }
    }
    public class CinUsuluBeyazCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Çin usulu beyaz cay hazirlaniyor...");
        }
    }
    public class HintUsuluSiyahCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Hint usulu siyah cay hazirlaniyor...");
        }
    }
    public class HintUsuluYesilCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Hint usulu yesil cay hazirlaniyor...");
        }
    }
    public class HintUsuluBeyazCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Hint usulu beyaz cay hazirlaniyor...");
        }
    }
    public class JaponUsuluSiyahCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Japon usulu siyah cay hazirlaniyor...");
        }
    }
    public class JaponUsuluYesilCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Japon usulu yesil cay hazirlaniyor...");
        }
    }
    public class JaponUsuluBeyazCay : Cay
    {
        public override void hazirla()
        {
            Console.WriteLine("Japon usulu beyaz cay hazirlaniyor...");
        }
    }
  
}
