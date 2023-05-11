using System;
using System.Collections.Generic;

namespace Demo
{
    public class Gruplayici
    {
        private int v;

        public Gruplayici(int v)
        {
            this.v = v;
        }

        public List<List<Olcum>> Grupla(List<Olcum> olcumler)//olcum listelerinin tutuldugu baska bir liste return edicek.
        {
            var gruplar = new List<List<Olcum>>();
            gruplar.Add(olcumler);
            return gruplar;
        }
    }
}