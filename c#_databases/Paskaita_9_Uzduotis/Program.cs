using Paskaita_9_Uzduotis.Entities;
using Microsoft.EntityFrameworkCore;

namespace Paskaita_9_Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

              Užduotis 1: Sukurkite darbinę duomenų bazę ir užpildykite duomenimis.
              Sukurkite darbinę duomenų bazę, kurią sudaro 5 lentelės: Darbuotojai (Employees), Imone (Company), Projektai (Projects), Skyrius (Departments), ir Vadovas (Managers).
              - Darbuotojas (Employee) turėtų turėti savybes: DarbuotojasId, Vardas, Pavarde, SkyriusId, ProjektasId.
              - Skyrius (Department) turėtų turėti savybes: SkyriusId, Pavadinimas, VadovoId.
              - Projektas (Project) turėtų turėti savybes: ProjektasId, Pavadinimas, ImoneId.
              - Imone (Company) turėtų turėti savybes: ImoneId, Pavadinimas, Adresas.
              - Vadovas (Manager) turėtų turėti savybes: VadovasId, Vardas, Pavarde.

             Nustatykite tarpusavio ryšius tarp lentelių:
              - Vienas Skyrius turi daug Darbuotojai. (one-to-many)
              - Projektas turi daug Darbuotojų. Darbuototas gali vykdyti daug projektų (many-to-many)
              - Vienas Vadovas vadovauja vienam Skyriui. (one-to-one)
              - Imone turi daug Projektų. Projektą vykdo daug Įmonių (many-to-many)

             Užpildykite DB pirminiais duomenimis:
                    - Sukurkite bent 3 įmones
                    - Sukurkite bent 6 skyrius
                    - Sukurkite bent 10 darbuotojų
                    - Sukurkite bent 5 projektus
                    - Sukurkite bent 3 vadovus
              */

            /*Užduotis 2: Užkraukite darbuotojus kartu su jų projektais. Naudokite Eager Loading. */
            /*Užduotis 3: Užkraukite skyrius kartu su darbuotojais ir projektais. Naudokite Eager Loading. */
            /*Užduotis 4: Užkraukite įmones kartu su projektais ir jų darbuotojais. Naudokite Eager Loading.*/
            /*Užduotis 5: Užkraukite darbuotojus kartu su skyriumi ir vadovu. Naudokite Eager Loading.*/
            /*Užduotis 6: Užkraukite vadovus kartu su jų skyriais ir darbuotojais. Naudokite Eager Loading.*/
            /*Užduotis 7: Užkraukite skyrius kartu su jų vadovais ir jų darbuotojų projektais. Naudokite Eager Loading.*/
            /*Užduotis 8: Užkraukite įmones kartu su projektais, darbuotojais ir jų skyriais. Naudokite Eager Loading.*/
            /*Užduotis 9: Užkraukite visus projektus kartu su įmonėmis, darbuotojais ir jų vadovais. Naudokite Eager Loading.*/

            using var context = new AppDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            DbSeed.Seed(context);



        }
    }
}




/*
   Užduotis turi būti suformuluota labai tiksliai, aprašant žingsnis po žingsnio ką reikia padaryti. 
   Viskas turi būti aprašyta natūralia kalba. Stenkitės naudoti tikslią terminiją.
   Užduotyje turi būti:
    - Ne mažiau kaip 5 lentelės
    - Bent vienas ryšys one-to-one
    - Bent vienas ryšys one-to-many
    - Bent vienas ryšys many-to-many
    - Naudojamos migracijos
    - Lazy Loading naudoti negalima.
    - Nurodykite kaip turi būti atliekama konfigūracija - ar reikia naudoti Fluent API ar Data Annotations.

    - Aprašykite kokie turi būti Pirminiai Duomenys (Inital Data) ir kodėl.  Bent 1 lentelė turi būti užpildyta pirminiais duomenimis per HasData. 
    - Nenaudokite pirminio užpildymo ne pagal paskirtį. Prisiminkite ir pademonstruokite supratimą, kokia yra pagrindinė pirminių duomenų paskirtis. 

    - Bent 10 public Metodų, kurie atlieka įvaires CRUD ir biznio logikos operacijas. Nurodykite, kad metodai turi būti servisuose.
    - Nurodykite, kad servisai turi implementuoti interface'us.
    - Bent 2 repository servisai. Naudoti generic repository negalima. Repository nebūtinai turi įgyvendinti visą CRUD funkcionalumą.
    - Bent 1 biznio logikos servisas.
    - Aprašykite, ką turi daryti kiekvienas public Metodas. Atkreipkite dėmesį į tai, kad metodai turi būti kuo mažesni ir atlikti tik vieną veiksmą.
    - Nurodykite, kuriuose metoduose turi būti panaudotas Eager Loading, kur ne. Paaiškinkite kodėl. Turi būti bent 2 metodai su Eager Loading ir 2 be.
    - Nurodykite, kaip public Metodas turi būti pavadintas.
    - Nurodykite, kokie yra numatomi public Metodų rezultatai.
    - Aprašykite, kokius atributus public Metodai turi priimti ir kokia tvarka.
    - Aprašykite, ką public Metodai jie turi grąžinti.
    - Aprašykite, kiekvieno public Metodo automatinio testavimo scenarijus. Testai turi apimti visą loginę sprendimų aibę (Condition-Coverage)
    - Aprašykite, kaip testiniai duomenys bus įrašomi į DB. Nurodykite, kad testiniams duomenims saugoti turi būti naudojama in-memory duomenų bazė.

    - Aprašykite, kokie yra numatomi ribiniai duomenų atvejai ir kaip jie bus apdoroti.
    - Aprašykite, kokie yra numatomi neteisingų duomenų atvejai ir kaip jie bus apdoroti.
    - Aprašykite, kokie yra numatomos išimtys ir kaip jos bus apdorotos. Ar reikia naudoti try-catch blokus?

    - Aprašykite, kokios validacijos turi būti atliekamos duomenims ir kaip jos bus atliekamos. Turi būti bent 5 įvesčių validacijos iš kurių bent 1-object, bent 1-numeric ir bent 1-string.
    - Validacijos turi apimti visus galimus įvesties atvejus įskaitant ir 'null'.
    - Aprašykite, testavimo scenarijus, kaip bus pilnai ištestuota kiekviena validacija.

    - Išvedimo į konsolę realizacija nereikalinga. Akcentas turi būti dedamas į paduodamas/grąžinamas vertes ir unit testavimą.

*/


//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Andrius
Parašykite darbuotojų laiko valdymo programą. Programa turi leisti įvesti darbuotojus, įvesti ir peržiūrėti darbuotojų darbo laiką.
Aprašykite duomenų bazės modelius (Entities) ir jų tarpusavio ryšius.

1.  Sukurkite klasę Darbuotojas (Employee) su savybėmis: Id(int/asmens kodas, Pirminis raktas), Vardas(string), El.paštas(string),
    SkyriausId(gali turėti null reikšmę, kol Vadovas nepriskyrė jokiam skyriui).
    Pridėkite Navigacines savybes į Skyriaus klasę (One-to-Many) ir Projektų klasę (Many-to-Many).

2.  Sukurkite skyriaus klasę su savybėmis: Id(Pirminis raktas), Pavadinimas(string), VadovoId(int su FK).
    Pridėkite Navigacines savybes į Darbuotojų klasę (One-to-Many) ir Vadovo klasę (One-to-One).

3.  Sukurkite klasę Vadovas su savybėmis: Id(Pirminis raktas), Vardas(string).
    Pridėkite Navigacines savybes į Skyriaus klasę (One-to-One).

4.  Sukurkite klasę Projektas su savybėmis: Id(int, Pirminis raktas), DarbuotojasId(int, FK), ProjektasId(int, FK), DirbtosValandos (int), Data(DateTime).
    Pridėkite Navigacines savybes į Darbuotojų klasę (Many-to-Many) ir Projektų klasę (Many-to-Many).

5.  Apsirašykite duomenų bazės kontekstą, kuris turi DbSet'us visoms klasėms. 
    Apsirašykite OnConfiguring metodą, kuris leis prisijungti prie SQL duomenų bazės.
    Naudokite Fluent API, kad nurodytumėte ryšius tarp lentelių:
    - Darbuotojas turi vieną Skyrių (One-to-Many)
    - Darbuotojas turi daug Projektų (Many-to-Many)
    - Skyrius turi vieną Vadovą (One-to-One)
    - Projektas turi daug Darbuotojų (Many-to-Many)

6.  Aprašykite pirminį duomenų bazės užpildymą skyriaus duomenų bazės lentelėms su .HasData metodu, turi turėti Valdymo, IT, Finansų skyrius.
    Skyriai įmonėje nesikeičia, todėl juos galima įvesti pirminiais duomenimis.
    
7.  Sukurkite DarbuotojasRepository servisą, kuris leis atlikti CRUD operacijas. 
    DarbuotojasRepository klasė, turi turėti metodus: Add, GetById, Update.
    - Metodas Add turi pridėti naują darbuotoją į duomenų bazę.
    - Metodas GetById turi grąžinti darbuotoją pagal Id(asmenskodas).
    Sukurkite ProjektasRepository servisą su metodais: Add, Update, Delete.
    - Metodas Add turi pridėti naują projektą į duomenų bazę.
    - Metodas Update turi atnaujinti projektą.
    - Metodas Delete turi ištrinti projektą iš duomenų bazės.
    Visi metodai turi turėti savo interface'us.

8.  Sukurkite DarbuotojasService klasę kuri duomenis į duomenų bazę įrašo per DarbuotojasRepository servizo metodus.
    Įgyvendinkite metodus: PridėtiDarbuotoją , GautiDarbuotojąPagalId.
    - Metodas PridėtiDarbuotoją turi pridėti naują darbuotoją į duomenų bazę. Turi būti patikrinama ar darbuotojas jau egzistuoja db.
    Jei neegzituoja paprašoma įvesti darbuotojo duomenis vardas, asmenskodas, el.paštas.
    Sukurkite klasę projektasService ir metodus GautiDarbuotojoValandas, DirbtasSkyriausLaikasPerMėnesį, PažymėtiDirbtąLaiką.
    - Metodas GautiDarbuotojoValandas turi grąžinti darbuotojo dirbtas valandas mer mėnesį pagal įvestą vardą ir data pvz 2024-08.
    Bendras vieno darbuotojo dirbtas laikas negali būti didesnis nei 160 valandų per mėnesį. Atlikti validaciją.
    - Metodas DirbtasSkyriausLaikasPerMėnesį turi apskačiuoti ir grąžinti visų skyriaus darbuotojų dirbto laiko per mėnesį vidurkį.
    Bendras vieno darbuotojo dirbtas laikas negali būti didesnis nei 160 valandų per mėnesį. Atlikti validaciją.
    - Metodas PažymėtiDirbtąLaiką turi pridėti įvestą laiką, laikas gali būti tik teigiamas (atlikti validacija prieš rašant i duomenų bazę).

9.  Parašykite Unit testus visiems metodam. Testai turi būti atskirame projekte.
    
    Aprašymas: Patikrinkite, ar darbuotojas egzistuoja, ir ar, pridėjus darbuotoją, visi jo duomenys atsirado duomenų bazėje.
    Veiksmai:
    Sukurkite darbuotoją naudodami in-memory duomenų bazę.
    Panaudokite metodą PridėtiDarbuotoją ir patikrinkite, ar darbuotojas buvo pridėtas į duomenų bazę, ir ar visos reikšmės atitinka tai, kas buvo įrašyta.
    Unit testas:
    Įveskite darbuotoją su vardu Jonas ir el. paštu.
    Panaudokite metodą _darbuotojasService.PridėtiDarbuotoją(darbuotojas).
    Patikrinkite, ar darbuotojas įrašytas į duomenų bazę bei ar visi duomenys (vardas, el. paštas) yra teisingi.   

    Aprašymas: Patikrinkite, ar grąžinamos teisingos darbuotojo darbo valandos.
    Veiksmai:
    Sukurkite sąrašą darbuotojų su dirbtu laiku ir įrašykite juos į in-memory duomenų bazę.
    Panaudokite metodą GautiDarbuotojoValandas, patikrinkite, ar grąžinamas laikas yra teisingas.
    Unit testas:
    Įveskite darbuotoją su vardu Jonas ir el. paštu.
    Pridėkite darbuotoją į in-memory duomenų bazę.
    Naudokite metodą _projektasService.PažymėtiDirbtąLaiką(darbuotojas.Id, 10), kad įrašytumėte dirbtas valandas.
    Gauname darbuotojo valandas su metodu _darbuotojasService.GautiDarbuotojoValandas(darbuotojas.Vardas, DateTime.Now).
    Patikrinkite, ar grąžinamos valandos yra teisingos.

    Aprašymas: Patikrinkite, ar grąžinamas teisingas bendras skyriaus dirbtas laikas per mėnesį, ir ar laikas neviršija 160 valandų.
    Veiksmai:
    Sukurkite sąrašą darbuotojų su dirbtu laiku ir įrašykite juos į in-memory duomenų bazę.
    Panaudokite metodą DirbtasSkyriausLaikasPerMėnesį, patikrinkite, ar dirbtas laikas apskaičiuojamas teisingai.
    Unit testas:
    Įveskite tris darbuotojus (Jonas, Petras, Antanas).
    Pridėkite darbuotojus į in-memory duomenų bazę.
    Pridėkite dirbtas valandas su metodu _projektasService.PažymėtiDirbtąLaiką(darbuotojas.Id, 10) (Jonas).
    Pridėkite dirbtas valandas su metodu _projektasService.PažymėtiDirbtąLaiką(darbuotojas.Id, 20) (Petras).
    Pridėkite dirbtas valandas su metodu _projektasService.PažymėtiDirbtąLaiką(darbuotojas.Id, 30) (Antanas).
    Naudokite metodą _projektasService.DirbtasSkyriausLaikasPerMėnesį(skyrius.Id) ir patikrinkite, ar teisingai apskaičiuotas bendras laikas bei ar neviršija 160 valandų.

    Aprašymas: Patikrinkite, ar laikas įrašomas teisingai, ir ar laikas nėra neigiamas. Taip pat patikrinkite, kad vienu metu nebūtų pridedama daugiau nei 160 valandų.
    Veiksmai:
    Pridėkite darbuotoją į in-memory duomenų bazę.
    Panaudokite metodą PažymėtiDirbtąLaiką ir patikrinkite, ar valandos pridedamos teisingai.
    Patikrinkite, ar klaida grąžinama, jei pridedama daugiau nei 160 valandų.
    Unit testas 1:
    Įveskite darbuotoją su vardu Jonas ir el. paštu.
    Pridėkite darbuotoją į in-memory duomenų bazę.
    Pridėkite 10 dirbtų valandų su metodu _projektasService.PažymėtiDirbtąLaiką(darbuotojas.Id, 10).
    Patikrinkite, ar valandos įrašytos teisingai.
    Unit testas 2:
    Įveskite darbuotoją su vardu Jonas ir el. paštu.
    Pridėkite darbuotoją į in-memory duomenų bazę.
    Pabandykite pridėti 200 valandų su metodu _projektasService.PažymėtiDirbtąLaiką(darbuotojas.Id, 200).
    Testas turi grąžinti klaidą, nurodančią, kad negalima pridėti daugiau nei 160 valandų vienu.
    

*/


