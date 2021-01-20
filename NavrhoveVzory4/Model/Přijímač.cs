using NavrhoveVzory4.Model.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavrhoveVzory4.Model
{
    public class Přijímač
    {
        public Vysílač Zpráva { get; private set; }

        public Typ_vysílání ZvolenýTypVysílání { get; private set; }

        public Přijímač(int idVysílače, Typ_vysílání typ_Vysílání, Typ_vysílání zvolenýTyp_Vysílání)
        {
            Zpráva = new Vysílač(idVysílače, typ_Vysílání);
            ZvolenýTypVysílání = zvolenýTyp_Vysílání;
        }

        public Přijímač vytvořNovýPřijímač(int idVysílače, Typ_vysílání typ_Vysílání, Typ_vysílání zvolenýTyp_Vysílání)
        {
            if(idVysílače > 0)
            {
                if (typ_Vysílání != Typ_vysílání.ERROR)
                {
                    return new Přijímač(idVysílače, typ_Vysílání, zvolenýTyp_Vysílání);
                }

                return new Přijímač(0, Typ_vysílání.ERROR, Typ_vysílání.ERROR);

            }

            return new Přijímač(0, Typ_vysílání.ERROR, Typ_vysílání.ERROR);

        }

        public Přijímač přenastavVysílač()
        {

        }
        
        public Přijímač přenastavPřijímanýSignál()
        {

        }

    }
}
