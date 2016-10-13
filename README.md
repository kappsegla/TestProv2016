# Krav f�r Adress parser

F�r att hantera adresser vill vi ha en klass som kan representera en svensk adress enligt
svensk standard f�r adresser. https://sv.wikipedia.org/wiki/Adress
Du ska p�b�rja en s�dan implementation med tillh�rande test av funktionaliteten. Jobba l�mpligen enligt TDD
och placera de olika testmetoderna i den ordning som du l�gger till dessa.
Kraven listas i prioritetsordning d�r krav ett har h�gst prioritet att bli implementerat.

F�ljande funktioner efterfr�gas: 

1. En konstruktor som tar en str�ng som inparameter och l�ter oss skicka in en adress via denna.
   De olika raderna separeras med radbrytning '\n'. 
   Klassen ska l�sa ut de olika raderna och spara detta s� att de olika delarna kan h�mtas via properties.

2. Om fel finns i inkommande str�ng ska en exception kastas. F�ljande exceptions b�r klassen kunna kasta fr�n konstruktorn:

   ArgumentException � Something is wrong with the argument. (F�r f� rader tex.)
   ArgumentNullException � Argument is null.
   
3. L�gg till ytterligare funktionalitet som kan dela upp de olika raderna i sina best�ndsdelar.
   Vi b�rjar med (titel, f�rnamn, efternamn.)
   F�ljande titlar ska kunna k�nnas igen: Herr, hr, Fru, fru, Fr�ken, frk.
   Har ingen titel angetts ska titeln s�ttas till en tom str�ng.
   Skulle en annan titel �n de uppr�knade anges ska en exception av typen NotSupportedException kastas.

5. F�r att �ter kunna skriva ut adressen vill vi ha en publik metod som kan returnera en adress-str�ng.
   Ange formatet p� den efterfr�gade str�ngen via frivilliga inparametrar. Anges inget ska s� komplett adress som m�jligt returneras. 
   Anges tex att endast namn ska returneras s� ska endast det returneras. 