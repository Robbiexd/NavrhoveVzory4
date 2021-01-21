using System;
using System.Collections.Generic;
using System.Text;
using NavrhoveVzory4.Model.výčty;

namespace NavrhoveVzory4.Model
{
    public class Vysílač
    {
        public int Id { get; private set; }

        public Typ_vysílání TypVysílání { get; private set; }

        public Vysílač(int id, Typ_vysílání typ)
        {
            Id = id;
            TypVysílání = typ;
        }

        public string NaŘetězec()
        {
            return Id.ToString() + " " + TypVysílání;
        }
    }
}
