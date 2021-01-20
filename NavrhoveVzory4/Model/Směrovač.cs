using NavrhoveVzory4.Model.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavrhoveVzory4.Model
{
    public class Směrovač
    {
        public List<Přijímač> registrovanéPřijímače;

        public Směrovač()
        {
            registrovanéPřijímače = new List<Přijímač>();
        }
        
        public string přesměrujVysílání(Vysílač vysílač, int IndexPřijímače)
        {
            if(!(vysílač is null))
            {
                if(kontrolaTypuVysílání(vysílač.TypVysílání, IndexPřijímače))
                {
                    registrovanéPřijímače[IndexPřijímače] = new vytvořNovýPřijímač(vysílač.Id, vysílač.TypVysílání);
                    return "SIGNÁL PŘIJAT";
                }

                else
                {
                    return "PŘIJÍMAČ TENTO TYP VYSÍLÁNÍ NEPŘÍJÍMÁ!";
                }
               
            }

            else
            {
                return "FATAL SYSTEM ERROR";
            }
        }

        private bool kontrolaTypuVysílání(Typ_vysílání typ_Vysílání, int IndexPřijímače)
        {
            if(typ_Vysílání == registrovanéPřijímače[IndexPřijímače].ZvolenýTypVysílání)
            {
                return true;
            }

            return false;
        }

        public string registrujNovýPřijímač()
    }
}
