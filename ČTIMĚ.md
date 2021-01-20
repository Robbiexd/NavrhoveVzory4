# IPTV
Vytvořte implementaci:
## Třídy
- Vysilac - generuje obsah ve formě zpráv, které obsahují id_vysilace, typ_vysilani: ZABAVA, ZPRAVY, SPORT, FILMY a libovolný text
- Prijimac - prijima zpravy dle zadaného id_vysilace a typ_vysilani
- Smerovac - prijima zpravy od vysilacu a predava je prijimacum

## Pravidla:
- Je pouze jeden směrovač.
- Směrovač na začátku nema žádný registrovaný přijímač.
- Každý vysílač má unikátní id_vysílače.
- Přijímač musí u směrovače registrovat odkud (id_vysílače) a co chce přijímat (typ_vysilani). 
- Každý přijímač může v jednom okamžiku přijímat pouze zprávy z jednoho vysílače a s jedním typem zpráv.
- Po předání zprávy vysílači, dostane zpět potvrzení, zda někdo tuto zprávu přijímá.
- Směrovač si pamatuje omezený počet zpráv, které nikdo nepřijal.
- Přijímač se může z přijímání zpráv odhlásit.
- Nemělo by dojít k změně obsahu na cestě od vysílače k přijímači.
