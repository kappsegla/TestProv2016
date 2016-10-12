# Krav för Adress parser

För att hantera adresser vill vi ha en klass som kan representera en svensk adress enligt
svensk standard för adresser. https://sv.wikipedia.org/wiki/Adress
Du ska påbörja en sådan implementation med tillhörande test av funktionaliteten. Jobba lämpligen enligt TDD
och placera de olika testmetoderna i den ordning som du lägger till dessa.
Kraven listas i prioritetsordning där krav ett har högst prioritet att bli implementerat.

Följande funktioner efterfrågas: 

1. En konstruktor som tar en sträng som inparameter och låter oss skicka in en adress via denna.
   De olika raderna separeras med radbrytning '\n'. 
   Klassen ska läsa ut de olika raderna och spara detta så att de olika delarna kan hämtas via properties.

2. Om fel finns i inkommande sträng ska en exception kastas. Följande exceptions bör klassen kunna kasta från konstruktorn:

   ArgumentException – Something is wrong with the argument.
   ArgumentNullException – Argument is null.
   
3. Lägg till ytterligare funktionalitet som kan dela upp de olika raderna i sina beståndsdelar.
   Vi börjar med (titel, förnamn, efternamn.)
   Följande titlar ska kunna kännas igen: Herr, hr, Fru, fru, Fröken, frk.
   Har ingen titel angetts ska titeln sättas till en tom sträng.
   Skulle en annan titel än de uppräknade anges ska en exception av typen NotSupportedException kastas.

4. Verifiera att postnummer består av 5 siffror alternativt med inledande landskod för Sverige. SE-xxx xx.
   Returnera endast de 5 siffrorna när postnummer propertyn efterfrågas. Om postnumret inte följer formatet eller har för många siffror
   ska en ArgumentException kastas.

