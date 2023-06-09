
# MiniStore


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Bruno Bašić| bbasic@foi.hr | 0016136540 | brunobasic
Marijan Kovač | mkovac@foi.hr | 0016142261 | mkovac700
Tea Kovačević | tkovacevi@foi.hr | 0016141584 | tkovacevi

## Opis domene
Aplikacija MiniStore zamišljena je kao programsko rješenje za manje (lokalne) trgovine mješovite robe. Korisnici ove aplikacije su dakle vlasnici trgovina i zaposlenici, a kao primarnu funkcionalnost ističemo upravljanje zalihama robe, izdavanje računa kupcima i kreiranje popratne dokumentacije za poslovne procese. Od sekundarnih funkcionalnosti ističemo statistiku prodaje koja u svakom trenu daje ažurnu informaciju o najprodavanijim proizvodima u tekućem periodu, opciju finalnog obračuna - inventuru te izradu povratnice i narudžbenice koje olakšavaju svakodnevne aktivnosti unutar trgovine. S obzirom da je aplikacija namijenjena različitim kupcima, njeni će korisnici (vlasnici svake pojedine trgovine) imati mogućnost prilagodbe sučelja i ostalih komponenti (dizajn računa, logotipa i slično) svojim potrebama.

## Specifikacija projekta


Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija i prijava | Aplikacija razlikuje tri vrste korisnika - <em>superuser</em>, administrator i zaposlenik. <em>Superuser</em> ima najveće ovlasti među kojima je najvažnije dodijeljivanje određenih administratorskih ovlasti vlasniku pojedine trgovine. Administrator od <em>superusera</em> dobiva poseban generirani kod za registraciju, a neke od ovlasti koje ima su mogućnost upravljanja zaposlenicima, skladištem te storniranje računa. Zaposlenik (običan korisnik) može obavljati samo osnovne funkcionalnosti poput izdavanja računa, upravljanja satnicom, zaprimanje artikala i slično. Kod prijave se provjerava ispravnost unesenih podataka te vrsta prijavljenog korisnika. | Marijan Kovač
F02 | Upravljanje artiklima| Upravljanje će obavljati CRUD operacije, dakle kroz ovu će se funkcionalnost moći dodavati novi artikli ili postojećim artiklima povećavati odnosno smanjivati količinu (dodavanje i skidanje sa skladišta). Funkcionalnost cijelo vrijeme prikazuje stanje na skladištu i ne dozvoljava unos artikla koji već postoji (provjerava ID artikla). Funkcionalnost koristi generator QR ili BAR koda koji sadrži osnovne podatke o artiklu (npr. ID i cijena) za dodavanje novih artikala.  | Marijan Kovač
F03 | Zaprimanje artikala | Ova će funkcionalnost omogućiti evidenciju zaprimljene robe u skladište, dakle kroz nju će se moći povećavati količina novih ili postojećih proizvoda na skladištu za vrijednost nabavljenu od dobavljača, koja će se također obavljati pomoću QR ili BAR koda. | Tea Kovačević
F04 | Naručivanje artikala | Funkcionalnost namijenjena izradi narudžbenica koje će sadržavati ID, naziv te količinu željenih artikala. | Bruno Bašić
F05 | Izrada računa kupcu | Kreiranje, izdavanje i moguće poništavanje računa za prodane artikle korištenjem QR ili BAR koda. | Bruno Bašić
F06 | Inventura | Funkcionalnost koja, prilikom fizičkog pregleda artikala u trgovini, omogućuje usporedbu stanja na skladištu i stvarnog stanja u trgovini te računa nastali višak ili manjak, a koja će se realizirati upotrebom QR ili BAR koda. | Tea Kovačević
F07 | Statistika prodaje | Analitički prikaz prodaje po artiklu i kategoriji s obzirom na odabrano filtiranje po određenim kriterijima. | Bruno Bašić
F08 | Upravljanje satnicom | Funkcionalnost omogućava unos radnih sati od strane zaposlenika, a realizirana je tako da cijelo vrijeme prikazuje tablični popis evidencije koju automatski ažurira prilikom dodavanja novih podataka putem jednostavne forme. | Marijan Kovač
F09 | Izrada povratnice | Izrada PDF dokumenta sa artiklima koji se iz raznih razloga (npr. istek roka trajanja, oštećena ambalaža, oštećen proizvod...) vraćaju dobavljaču jer ih nije moguće prodati. | Tea Kovačević

## Tehnologije i oprema
.NET (Visual Studio 2022), GitHub, MySQL, Draw.io, Visual Paradigm, SourceTree, Dbeaver, Microsoft Word, GithubDesktop
