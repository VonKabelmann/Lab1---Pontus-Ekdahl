# Lab1---Pontus-Ekdahl

This was a short project done as part of the "Programmering med C#" course at IT-Högskolan.

The instructions given to us for the assignment were the following (in Swedish):

# Lab1 – Hitta tal i sträng med tecken
Skapa en konsollapplikation som tar en textsträng (string) som argument till Main eller uppmanar användaren mata in en sträng i konsollen.
Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.
ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller ett korrekt tal.

Skriv ut och markera varje korrekt delsträng
För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
rad med hela strängen, men där delsträngen är markerad i en annan färg.
Exempel output för input ”29535123p48723487597645723645”:

<b>2953512</b>3p48723487597645723645<br>
29<b>535</b>123p48723487597645723645<br>
295<b>35123</b>p48723487597645723645<br>
29535123p<b>487234</b>87597645723645<br>
29535123p4<b>872348</b>7597645723645<br>
29535123p48<b>723487</b>597645723645<br>
29535123p487<b>2348759764572</b>3645<br>
29535123p4872<b>3487597645723</b>645<br>
29535123p48723<b>48759764</b>5723645<br>
29535123p4872348<b>75976457</b>23645<br>
29535123p48723487<b>597645</b>723645<br>
29535123p4872348759<b>76457</b>23645<br>
29535123p48723487597<b>6457236</b>45<br>
29535123p487234875976<b>4572364</b>5<br>
29535123p4872348759764<b>5723645</b>

Ni kan välja vilka färger ni skriver ut med så länge man ser skillnad på dem. Ni
byter färg genom att ändra värde på Console.ForegroundColor.

Addera ihop alla tal och skriv ut totalen
Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
Exempel output för input ”29535123p48723487597645723645”:
Total = 5836428677242

## Redovisning
Uppgiften ska lösas individuellt.
Lämna in uppgiften på ithsdistans med en kommentar med github-länken.

## Betygskriterier
### För godkänt:
Räcker att lösa en av uppgifterna, d.v.s. antingen skriva ut alla delsträngar som i exemplet ovan, eller räkna ut och skriva ut totalen.
Om man matar in strängen i exemplet ska man få samma output som ovan.
Det ska även fungera generellt, oavsett vilken sträng man matar in.
### För väl godkänt krävs även:
Båda uppgifterna ska vara lösta, d.v.s. programmet ska först skriva ut alla delsträngar som i exemplet ovan och därefter räkna ut och skriva ut total.
Koden ska vara väl strukturerad och lätt att förstå.
