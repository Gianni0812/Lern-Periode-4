# Lern-Periode 4  
**14.02.2025 bis 04.04.2025**

## Grob-Planung

1. Meine Noten in Informatik sind gut, ich hatte bisher keine ungenügende Note. Im Modul 162 war ich jedoch nicht so stark wie in den anderen Modulen.  
2. Ich möchte ein **Blackjack-Spiel mit WinForms** programmieren. Der Spieler soll über Spielgeld verfügen, mit dem er Jetons zum Spielen kaufen kann. Zudem soll es ein Menü geben, in dem man das Spiel starten, Einstellungen vornehmen und den Shop öffnen kann.

## 14.02.2025 – Explorative Wegwerf-Prototypen
- [x] Karten erstellen  
- [x] Karten ausgeben lassen und deren Wert anzeigen  

Heute habe ich die Karten mit den dazugehörigen Werten erstellt und alle Karten ausgeben lassen. Das Programm funktioniert, und es sind keine grösseren Fehler aufgetreten.

## 21.02.2025 – Explorative Wegwerf-Prototypen
- [x] Skizze der Forms erstellen (offline)  
- [x] Zwei zufällige Karten ausgeben  
- [x] Buttons für „Karte“ und „Halten“ einbauen  
- [x] Einsätze und Kartenwerte anzeigen  

Ich habe heute einen grossen Teil meiner Arbeitspakete umgesetzt. Das Programm gibt nun zwei zufällige Karten für den Spieler und zwei für den Dealer aus. Die zweite Karte des Dealers ist verdeckt. Die Kartenwerte werden zusammengerechnet und angezeigt. Die Positionen der Karten stimmen noch nicht ganz, daran werde ich aber weiterarbeiten. Klickt man auf „Karte“, erhält man eine weitere Karte. Überschreitet man 21 Punkte, hat man verloren. Insgesamt bin ich sehr zufrieden mit dem Fortschritt.

## 28.02.2025 – Kern-Funktionalität
- [x] „Halten“-Button hinzufügen  
- [x] Einsätze hinzufügen  
- [ ] „Verdoppeln“-Button hinzufügen  
- [ ] Positionen anpassen  

Ich habe nicht alle Ziele erreicht, da die Arbeitspakete mehr Zeit in Anspruch genommen haben als erwartet. Der „Halten“-Button funktioniert nun, und der Spieler kann vor Spielbeginn einen Einsatz festlegen. Gewinne und Verluste werden korrekt berechnet und gespeichert. Das Layout gefällt mir noch nicht vollständig, das werde ich in der Architekturphase verbessern.

## 07.03.2025 – Kern-Funktionalität
- [ ] „Verdoppeln“-Button hinzufügen  
- [x] Shop im Hauptmenü hinzufügen  
- [ ] Geldautomat hinzufügen  

Heute habe ich einen Shop erstellt, in dem man mit seinem Guthaben Jetons kaufen und verkaufen kann. Zusätzlich gibt es eine zweite Seite für passives Einkommen, mit dem man pro Sekunde Geld erhält. Diese Funktion ist noch nicht vollständig umgesetzt und wird in der nächsten Woche weiterbearbeitet.

## 14.03.2025 – Architektur ausbauen
- [ ] Kauf-Button korrekt programmieren  
- [ ] „Verdoppeln“-Button hinzufügen  
- [x] Design von Form 1  
- [ ] Design von Form 2  

Da es mir heute gesundheitlich nicht gut ging, konnte ich nur wenig arbeiten. Ich habe das Startmenü gestaltet und versucht, das Problem mit dem passiven Einkommen zu beheben. Das erste passive Einkommen liess sich zwar kaufen und brachte Geld ein, weitere Stufen funktionierten jedoch nicht korrekt. Auch mit zusätzlicher Unterstützung konnte ich die Ursache nicht finden.

## 21.03.2025 – Architektur ausbauen  
## 28.03.2025 – Auspolieren

Heute habe ich grosse Fortschritte gemacht. Ich habe das Projekt optisch überarbeitet und den Shop weiter gestaltet. Der Shop ist fast fertig und gefällt mir sehr gut. Dafür musste ich jedoch grosse Teile des Codes anpassen und neu strukturieren, damit alles mit dem neuen Design funktioniert.

## 04.04.2025 – Auspolieren & Abschluss
- [x] Shop fertig designen  
- [x] Spiel fertig designen  

In der Lern-Periode 4 habe ich ein **Blackjack-Spiel mit WinForms** programmiert. Das Spiel funktioniert stabil und macht sehr viel Spass. Insgesamt gibt es fünf verschiedene Forms, die für Übersicht und Struktur sorgen.

Im Hauptmenü kann man auswählen, ob man spielen oder den Shop öffnen möchte. Im Shop-Bereich kann man Jetons kaufen oder verkaufen:

![image](https://github.com/user-attachments/assets/83a406e4-556a-45fc-93cd-bae247c34ee7)

Beim Verkauf von Jetons gelangt man in ein separates Form, in dem die Jetons gegen Geld eingetauscht werden können:

![image](https://github.com/user-attachments/assets/20308b46-9450-4fda-b0a1-610d99712bd8)

Beim Kauf von Jetons wird verfügbares Geld in Jetons umgewandelt:

![image](https://github.com/user-attachments/assets/f743cd1e-5e34-4100-ab3a-6f0aa6122ac4)

Klickt man im Hauptmenü auf „Spielen“, wird man zum Spielform weitergeleitet. Dort gibt man seinen Einsatz ein und erhält automatisch zwei Karten für den Spieler und zwei für den Dealer. Anschliessend stehen drei Aktionen zur Verfügung:

- **Halten** – Der Dealer ist an der Reihe und die Karten werden verglichen.  
- **Karte** – Man zieht eine weitere Karte, solange man nicht über 21 Punkte kommt.  
- **Verdoppeln** – Der Einsatz wird verdoppelt, man erhält genau eine weitere Karte und der Zug endet.  

![image](https://github.com/user-attachments/assets/18d95568-7790-40f2-8724-8711869e2c68)

## Reflexion
Ich bin sehr zufrieden mit meinem Projekt und finde, dass es mir insgesamt sehr gut gelungen ist. Anfangs lief alles reibungslos, doch mit der Zeit traten immer mehr kleinere Probleme auf, die ich lösen musste. Das war teilweise frustrierend, hat mir aber viel Lerngewinn gebracht.

Eine meiner Ideen war es, ein passives Einkommen durch Immobilien einzubauen. Diese sollten regelmässig Geld generieren, abhängig vom Kaufpreis. Leider hat diese Funktion trotz vieler Versuche nicht zuverlässig funktioniert, weshalb ich sie schliesslich gestrichen habe.

Trotzdem bin ich sehr stolz auf das Ergebnis. Das Spiel läuft stabil, sieht gut aus und macht Spass. Ich habe nicht nur viel über WinForms und Spielmechaniken gelernt, sondern auch über Geduld, Ausdauer und systematische Fehlersuche. Insgesamt war es ein sehr gelungenes Projekt.
