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
