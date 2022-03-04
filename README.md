# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# MiniStore


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Bruno Bašić| bbasic@foi.hr | 0016136540 | brunobasic
Marijan Kovač | mkovac@foi.hr | 0016142261 | mkovac700
Tea Kovačević | tkovacevi@foi.hr | 0016141584 | tkovacevi

## Opis domene
Aplikacija MiniStore zamišljena je kao programsko rješenje za manje (lokalne) trgovine mješovite robe. Korisnici ove aplikacije su vlasnici trgovine i zaposlenici, kao primarnu funkcionalnost ističemo upravljanje zalihama robe, izdavanje računa kupcima i kreiranje popratne dokumentacije za poslovne procese.
## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija i prijava | Registracija korisnika u sustav s opcijama administratora i zaposlenika. Administrator ima veće ovlasti te mogućnosti upravljanja zaposlenicima, skladištem te storniranje računa | Marijan Kovač
F02 | Upravljanje artiklima| Upravljanje će obavljati CRUD operacije  | Marijan Kovač
F03 | Zaprimanje artikala | Ova će funkcionalnost omogućiti evidenciju zaprimljene robe u skladište| Tea Kovačević
F04 | Naručivanje artikala | Funkcionalnost namijenjena izradi narudžbenica | Bruno Bašić
F05 | Izrada računa kupcu | Kreiranje, izdavanje i moguće poništavanje računa za prodane artikle | Bruno Bašić
F06 | Inventura | Usporedba stanja na skaldištu i stvarnog stanja u trgovini | Tea Kovačević
F07 | Statistika prodaje | Analitički prikaz prodaje po artiklu i kategoriji | Bruno Bašić
F08 | Upravljanje satnicom | Upis radnih sati od strane zaposlenika  | Marijan Kovač
F09 | Izrada povratnice | Izrada PDF dokumenta sa artiklima koji se vraćaju dobavljaču  | Tea Kovačević

## Tehnologije i oprema
.NET (Visual Studio 2022), GitHub, MySQL, Draw.io, SourceTree, Dbeaver, Microsoft Word
