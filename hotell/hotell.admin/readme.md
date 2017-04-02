# Obligatorisk oppgave delinnlevering nr. 2 
##Hovedm�l: 
Lage et system for � administrere hotellrom.  Systemet skal ha et grafisk brukergrensesnitt for administrasjon av rom, og en web-del hvor kunder kan reservere rom og kansellere bestillinger. Oppgaven skal gi trening i � arbeide med grafisk brukergrensesnitt, datasett, XML-filer og web-grensesnitt.

##Forutsetninger:
Hotellet har tre etasjer, hver med 14 rom (dette kan du endre hvis du vil). En gjest per rom. I utgangspunktet kun en romtype, men du kan ha flere romtyper hvis du vil. Hver gjest har sin egen reservasjon (ingen grupper eller familier).

##Design:
Grafisk brukergrensesnitt som viser ledige/opptatte rom. Brukergrensesnittet skal ogs� vise oversikt over gjester som har bestilt rom, men ikke f�tt tildelt rom. Denne listen hentes fra en tabell i datasettet. Det skal v�re mulig � legge til nye gjester i denne listen (drop inn) ved bruk av et eget skjema for � registrere ny gjest.  (Hvordan vi lager et slikt skjema ble vist i en av de f�rste forelesningene).
�	Forslag: Bruke tab-kontroll for � flytte mellom hver etasje
�	Forslag: Generere hvert rom automatisk f.eks. som panel (se eksempel med automatisk generering av knapper)
�	Forslag: Bruke farger for � vise ledige/opptatte rom (gr�nn er ledig, r�d er opptatt)
�	Forslag: Vise antall ledige rom i tab-overskrift
�	Forslag: Bruke drag and drop for � plassere gjest p� rom. N�r gjesten dras til et rom skal rommet reserveres for det antall dager gjesten har bestilt.

Bruke datasett for � holde orden p� gjester og rom, og hvilke gjester som er plassert p� hvilket rom. Datasettet oppdateres n�r en gjest dras til et rom med drag-and-drop.
Datasettet lagres p� XML-fil fortl�pende, hentes fra XML-fil ved oppstart.

Lag en ASP.NET applikasjon som gj�r det mulig for en kunde � reservere et rom over Internett.  Opplysninger som m� lagres: Kundenavn, Startdato, antall dager.  (Vi ville normalt tatt med flere opplysninger som adresse etc., men disse opplysningene trengs ikke her.


## Innlevering
Kildekode og dokumentasjon skal leveres p� Fronter innen 1 april 2017. Oppgaven skal leveres i Fronter og vises frem p�  lab.
Merk: Oppgaveteksten kan endres dersom jeg f�r sp�rsm�l som m� utdypes i oppgaveteksten
