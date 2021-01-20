using NavrhoveVzory4.Model.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavrhoveVzory4.Model
{
    public class Směrovač
    {
        Přijímač pomocnýPřijímač;

        public List<Přijímač> registrovanéPřijímače;

        public Směrovač()
        {
            pomocnýPřijímač = new Přijímač(-1, Typ_vysílání.ERROR, Typ_vysílání.ERROR);

            registrovanéPřijímače = new List<Přijímač>();
        }
        
        public string přepniVysílání(Vysílač vysílač, int indexPřijímače)
        {
            if(!(vysílač is null))
            {
                if(kontrolaTypuVysílání(vysílač.TypVysílání, indexPřijímače))
                {
                    registrovanéPřijímače[indexPřijímače] = registrovanéPřijímače[indexPřijímače].přenastavVysílač(vysílač.Id);

                    return "VYSÍLAČ  SPRÁVNĚ PŘEPNUT";
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

        public string změňTypVysílání(Typ_vysílání typ_Vysílání, int indexPřijímače)
        {
            if (registrovanéPřijímače.Count - 1 < indexPřijímače && indexPřijímače >= 0)
            {
                registrovanéPřijímače[indexPřijímače] = registrovanéPřijímače[indexPřijímače].přenastavTypPřijímanéhoSignálu(typ_Vysílání);
                return "TYP VYSÍLÁNÍ ÚSPĚŠNĚ PŘENASTAVEN!";
            }
                return "TENTO PŘIJÍMAČ NEEXISTUJE!!!";
        }
        
        

        public string registrujNovýPřijímač(int idVysílače, Typ_vysílání typ_Vysílání, Typ_vysílání zvolenýTyp_Vysílání)
        {
            if(typ_Vysílání != Typ_vysílání.ERROR)
            {
                registrovanéPřijímače.Add(pomocnýPřijímač.vytvořNovýPřijímač(idVysílače, typ_Vysílání, zvolenýTyp_Vysílání));
                return "PŘIJÍMAČ BYL ÚSPĚŠNĚ ZAREGISTROVÁN!";
            }

            return "ERROR!";
            
        }

        public string odeberPřijímač(int indexPřijímače)
        {
            if(registrovanéPřijímače.Count -1 < indexPřijímače && indexPřijímače >= 0)
            {
                registrovanéPřijímače.RemoveAt(indexPřijímače);
                return "PŘIJÍMAČ BYL ÚSPĚŠNĚ ODEBRÁN ZE SEZNAMU REGISTROVANÝCH PŘIJÍMAČŮ!";
            }

            return "TENTO PŘIJÍMAČ NEEXISTUJE!!!";
        }
    }
}
