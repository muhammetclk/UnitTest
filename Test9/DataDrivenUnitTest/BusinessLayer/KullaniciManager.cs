using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //xml dosyasindaki verileri is katmanimizdaki kurallara gore veritabanina kaydedicez.
    //veriler dogru sekilde yazilmismi dıye test edicez.

    public class KullaniciManager
    {
        public bool KullaniciEkle(string ad,string tel,string email)
        {
            if (ad.Length < 4) return false;//ad 4 harften az ise girer
            if (!Regex.IsMatch(tel, ("[0-9]"))) return false;//sadece rakam kullanilmadiysa girer(! var.)
            if (!email.Contains("@")) return false;//@ isareti kullanilmadiysa girer.

            return true;//hicbirine girmezse veriler dogru yazilmistir.
        }
    }
}
