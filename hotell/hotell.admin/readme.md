# Obligatorisk oppgave delinnlevering nr. 2 
##Hovedmål: 
Lage et system for å administrere hotellrom.  Systemet skal ha et grafisk brukergrensesnitt for administrasjon av rom, og en web-del hvor kunder kan reservere rom og kansellere bestillinger. Oppgaven skal gi trening i å arbeide med grafisk brukergrensesnitt, datasett, XML-filer og web-grensesnitt.

##Forutsetninger:
Hotellet har tre etasjer, hver med 14 rom (dette kan du endre hvis du vil). En gjest per rom. I utgangspunktet kun en romtype, men du kan ha flere romtyper hvis du vil. Hver gjest har sin egen reservasjon (ingen grupper eller familier).

##Design:
Grafisk brukergrensesnitt som viser ledige/opptatte rom. Brukergrensesnittet skal også vise oversikt over gjester som har bestilt rom, men ikke fått tildelt rom. Denne listen hentes fra en tabell i datasettet. Det skal være mulig å legge til nye gjester i denne listen (drop inn) ved bruk av et eget skjema for å registrere ny gjest.  (Hvordan vi lager et slikt skjema ble vist i en av de første forelesningene).
•	Forslag: Bruke tab-kontroll for å flytte mellom hver etasje
•	Forslag: Generere hvert rom automatisk f.eks. som panel (se eksempel med automatisk generering av knapper)
•	Forslag: Bruke farger for å vise ledige/opptatte rom (grønn er ledig, rød er opptatt)
•	Forslag: Vise antall ledige rom i tab-overskrift
•	Forslag: Bruke drag and drop for å plassere gjest på rom. Når gjesten dras til et rom skal rommet reserveres for det antall dager gjesten har bestilt.

Bruke datasett for å holde orden på gjester og rom, og hvilke gjester som er plassert på hvilket rom. Datasettet oppdateres når en gjest dras til et rom med drag-and-drop.
Datasettet lagres på XML-fil fortløpende, hentes fra XML-fil ved oppstart.

Lag en ASP.NET applikasjon som gjør det mulig for en kunde å reservere et rom over Internett.  Opplysninger som må lagres: Kundenavn, Startdato, antall dager.  (Vi ville normalt tatt med flere opplysninger som adresse etc., men disse opplysningene trengs ikke her.


## Innlevering
Kildekode og dokumentasjon skal leveres på Fronter innen 1 april 2017. Oppgaven skal leveres i Fronter og vises frem på  lab.
Merk: Oppgaveteksten kan endres dersom jeg får spørsmål som må utdypes i oppgaveteksten
