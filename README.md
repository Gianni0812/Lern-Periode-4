# Lern-Periode-4


14.2 bis 4.4

## Grob-Planung

1. Meine Noten in Informatik sind gut, ich hatte bisher keine ungenügende Note. Jedoch war ich im Modul 162 nicht so stark wie in den anderen Modulen.
2. Ich möchte ein Blackjack-Spiel mit WinForms programmieren. Man soll Spielgeld haben, mit dem man sich Jetons zum Spielen kaufen kann. Es soll ein Menü geben, in dem man das Spiel starten, Einstellungen vornehmen und den Shop öffnen kann.

## 14.2: Explorativer Wegwerf-Prototyp

- [x] Karten Erstellen
- [x] Karten ausgeben lassen und den Wert anzeigen lassen

Ich habe heute die Karten mit den dazugehörigen Werten erstellt und alle ausgegeben. Das Programm funktioniert und ich hatte keine wirklichen Fehler

## 21.2: Explorativer Wegwerf-Prototyp

- [x] Eine Skizze von meinen Forms machen (offline)
- [x] Zwei random Karte ausgeben 
- [x] Buttons für noch eine Karte und halten
- [x] Einsätze plus Werte der Karten anzeigen.

Ich habe heute einen Teil meiner Arbeitspakete erledigt. Ich habe programmiert, dass das Programm zwei zufällige Karten für den Dealer und zwei für den Spieler ausgibt. Die zweite Karte des Dealers ist versteckt, sodass man sie noch nicht sehen kann. Die Werte der Karten werden zusammengezählt und angezeigt. Die Positionen der Karten stimmen leider noch nicht ganz, daran werde ich aber noch arbeiten. Wenn man auf „Karte“ klickt, erhält man eine weitere Karte. Wenn man über 21 Punkte kommt, hat man verloren. Bisher bin ich sehr zufrieden und komme gut voran.

## 28.2: Kern-Funktionalität
- [x] Halten button hinzufügen
- [x] Einsätze hinzufügen
- [ ] Verdoppeln button hinzufügen
- [ ] Positionen anpassen
      
Ich habe nicht alle Ziele erreicht, die ich mir vorgenommen hatte, da die Arbeitspakete mehr Zeit in Anspruch genommen haben als gedacht. Trotzdem habe ich den „Halten“-Button eingebaut und der Spieler kann vor Spielbeginn einen Einsatz festlegen. Wenn man gewinnt oder verliert, wird dies gespeichert und man erhält den Gewinn oder verliert den Einsatz. Die Anordnung gefällt mir noch nicht ganz, das werde ich in der Architekturphase überarbeiten.


      
## 7.3: Kern-Funktionalität
- [ ] Verdoppeln Button Hinzufügen
- [x] Shop im Hauptmenu Hinzufügen
- [ ] Geld automaten hinzufügen

Ich habe heute einen Shop erstellt, in dem man mit dem Geld auf dem Konto Jetons kaufen und verkaufen kann. Zusätzlich gibt es eine zweite Seite, auf der man passives Einkommen kaufen kann, mit dem man jede Sekunde Geld bekommt. Das funktioniert leider noch nicht ganz, das werde ich nächste Woche in Angriff nehmen.
      
## 14.3: Architektur ausbauen
- [ ] Kaufen Button richtig programmieren
- [ ] Verdoppeln Button Hinzufügen
- [x] Designen von Form 1
- [ ] Designen von Form 2

Da es mir heute nicht sehr gut ging und ich mich nicht fit fühlte, konnte ich nicht viel arbeiten. Trotzdem habe ich das Startmenü gestaltet und versucht, das Problem mit dem Kauf des passiven Einkommens zu beheben. Das hat leider nicht gut funktioniert. Ich konnte das erste passive Einkommen kaufen, und es hat mir auch Geld eingebracht, aber der Rest hat nicht richtig funktioniert und ich wusste nicht warum. ChatGPT konnte mir auch nicht wirklich helfen, weshalb das Problem weiterhin besteht.
      
## 21.3: Architektur ausbauen
## 28.3: Auspolieren

Ich habe heute viel erreicht. Ich habe mein Projekt schön gestaltet und bin ziemlich stolz auf meine Arbeit. Ich habe das Spiel optisch überarbeitet und den Shop angefangen zu designen. Den Shop habe ich fast fertig, und er sieht sehr gut aus. Ich musste dafür jedoch meinen gesamten Code kopieren und abändern, damit es mit dem neuen Design funktioniert.

## 4.4: Auspolieren & Abschluss
- [x] Shop Fertig Designen
- [x] Spiel fertig Designen

Ich habe in der Lern-Periode 4 ein Blackjack-Spiel mit WinForms programmiert. Das Spiel funktioniert sehr gut und macht wirklich süchtig. Es gibt fünf verschiedene Forms, die das Ganze übersichtlich und spannend gestalten.

Im Hauptmenü kann man wählen, ob man spielen möchte oder Jetons kaufen will. Wenn man auf „Shop“ klickt, gelangt man in den Shop-Bereich, in dem man Jetons kaufen oder verkaufen kann. Das Ganze ist einfach aufgebaut, damit man sich schnell zurechtfindet:

![image](https://github.com/user-attachments/assets/83a406e4-556a-45fc-93cd-bae247c34ee7)

Wenn man auf „Jetons verkaufen“ klickt, gelangt man zu einem weiteren Form. Dort kann man seine erspielten Jetons gegen Geld eintauschen, das man später wieder einsetzen kann:

![image](https://github.com/user-attachments/assets/20308b46-9450-4fda-b0a1-610d99712bd8)

Beim Jetons-Kaufen ist es genau umgekehrt – dort kann man sein verfügbares Geld gegen Jetons eintauschen:

![image](https://github.com/user-attachments/assets/f743cd1e-5e34-4100-ab3a-6f0aa6122ac4)

Wenn man im Menü auf „Spielen“ klickt, wird man direkt zum Spiel-Form weitergeleitet. Dort gibt man seinen Einsatz ein, und dann bekommt man automatisch Karten – zwei für den Spieler und zwei für den Dealer. Danach hat man drei Möglichkeiten:

Halten – Dann ist der Dealer an der Reihe und es wird verglichen.

Karte – Man zieht eine weitere Karte. Das kann man beliebig oft machen, solange man sich nicht überkauft.

Verdoppeln – Der Einsatz wird verdoppelt, aber man darf nur noch eine Karte ziehen und ist dann fertig.

![image](https://github.com/user-attachments/assets/18d95568-7790-40f2-8724-8711869e2c68)

## Reflexion
Ich bin sehr zufrieden mit meinem Projekt und finde, dass es mir richtig gut gelungen ist. Anfangs lief alles ziemlich reibungslos, aber mit der Zeit traten immer mehr kleine Probleme auf, die ich dann lösen musste. Das hat mich manchmal genervt, aber am Ende habe ich viel dabei gelernt.

Ich hatte zum Beispiel die Idee, ein passives Einkommen durch Immobilien einzubauen. Das sollte so funktionieren, dass man Immobilien kaufen kann und diese dann regelmäßig Geld bringen – je teurer, desto mehr. Leider hat das nicht so funktioniert, wie ich es mir vorgestellt hatte. Ich habe es oft versucht, aber irgendwie wollte es einfach nicht klappen. Das hat so viel Zeit gefressen, dass ich die Idee gestrichen habe.

Trotzdem bin ich mega stolz auf mein Projekt. Es funktioniert stabil, sieht gut aus – und das Wichtigste: Es macht Spaß! Ich habe viel gelernt – nicht nur übers Programmieren, sondern auch über Geduld, Ausdauer und wie man Fehler findet. Es war auf jeden Fall ein cooles Projekt!
