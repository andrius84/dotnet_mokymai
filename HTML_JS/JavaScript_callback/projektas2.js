// 
// Jūsų tikslas yra naudoti HTML sąrašą ir sukurti JavaScript funkciją, kuri, paspaudus mygtuką, apdoros sąrašo elementus naudodama .map() ir atnaujins jų turinį.
// Turite vardų ir pavardžių sąrašą elementuose <li> HTML'e. Jūsų tikslas yra sukurti 5 mygtukus, kurių kiekvienas atliks skirtingą veiksmą su sąrašo elementais.
 
// Pradiniai duomenys (vardai ir pavadrės): Jonas Jonaitis, Asta Astiene, Petras Petraitis, Inga Inge.
// ---------------------------
// Užduotis 1:
// - kiekvieno elemento tekstas pasipildytu indeksu,
// - button elementas su tekstu „Pridėti indeksą“.
// - naudokite Array.from() ir .map() metodus surastiems html elementams surašyti į masyvą ir mutuoti.

const listItems = document.querySelectorAll('li');

const addIndex = () => {
    const listArray = Array.from(listItems);
    listArray.map((item) => {item.innerHTML = '#' + listArray.indexOf(item) + ': ' + item.innerHTML;});
}

// Laukiamas rezultatas:
// #0: Jonas Jonaitis
// #1: Asta Astiene
// #2: Petras Petraitis
// #3: Inga Inge
 
// ----------------------------
// Užduotis 2:
// - Padarykite reset mygtuką, kuris atstatytų pradinį sąrašo elementų turinį.
// - naudokite createElement ir appendChild metodus.
 
// Lauckiamas rezultatas:
// Jonas Jonaitis
// Asta Astiene
// Petras Petraitis
// Inga Inge
// ----------------------------
// Užduotis 3:
// - Naudodami .map(), vardo raides į didžiąsias.
// - button elementas su tekstu „Paversti į didžiąsias“.
 
// Lauckiamas rezultatas:
// JONAS JONAITIS
// ASTA ASTIENE
// PETRAS PETRAITIS
// INGA INGE
// ----------------------------
// Užduotis 4:
// - Naudodami .map(), prie kiekvieno sąrašo elemento tekstos pridėkite jo ilgį. Pavyzdžiui: Jonas (5 raidės).
// - button elementas su tekstu Pridėti į ilgį“.
 
// Lauckiamas rezultatas:
// Jonas Jonaitis (14 raidės)
// Asta Astiene (12 raidės)
// Petras Petraitis (15 raidės)
// Inga Inge (8 raidės)
// ----------------------------
// Užduotis 5:
// - Naudokite .map() metodą, kad kiekvieno sąrašo elemento tekstą pakeistu inicialais.
// - button elementas su tekstu „Pakeisti į inicialus“.
 
// Lauckiamas rezultatas:
// J. J.
// A. A.
// P. P.
// I. I.


