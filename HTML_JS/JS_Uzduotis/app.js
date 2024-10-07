/*
- Parašykite funkciją, kuri naudodama `for` ciklą ir `switch`, apskaičiuotų turimų monetų bendrą svorį gramais.
- Naudodami EventListener, sukurkite 16 mygtukų, kuriuos paspaudus būti pridedama arba sumažinama monetų kiekis rankoje.
- Po kiekvieno paspaudimo svoris turi būti automatiškai perskaičiuojamas ir išvedamas į konslolę.
- Monetų kiekiai turi būti saugomi masyve su 8 elementais.
 
Svoris suapvalinamas iki dviejų skaičių po kablelio.
Tarkime, turite tokius monetų kiekius:
- 3 monetos po 1 ct,
- 1 moneta po 2 ct,
- 10 monetų po 5 ct,
- 5 monetos po 10 ct,
- 2 monetos po 50 ct,
- 7 monetos po 1 €,
- 4 monetos po 2 €.
 
monetos sveria:
1 ct = 2.3 g
2 ct = 3.06 g
5 ct = 3.92 g
10 ct = 4.10 g
20 ct = 5.74 g
50 ct = 7.80 g
100 ct (1 €) = 7.50 g
200 ct (2 €) = 8.50 g
*/

let monetos = { ct_1: 3, ct_2: 1, ct_5: 10, ct_10: 5, ct_20: 0, ct_50: 2, ct_100: 7, ct_200: 4 };
let bendrassvoris = 0;

for (let moneta in monetos) {
    switch (moneta) {
        case 'ct_1':
            bendrassvoris += monetos[moneta] * 2.3;
            break;
        case 'ct_2':
            bendrassvoris += monetos[moneta] * 3.06;
            break;
        case 'ct_5':
            bendrassvoris += monetos[moneta] * 3.92;
            break;
        case 'ct_10':
            bendrassvoris += monetos[moneta] * 4.10;
            break;
        case 'ct_20':
            bendrassvoris += monetos[moneta] * 5.74;
            break;
        case 'ct_50':
            bendrassvoris += monetos[moneta] * 7.80;
            break;
        case 'ct_100':
            bendrassvoris += monetos[moneta] * 7.50;
            break;
        case 'ct_200':
            bendrassvoris += monetos[moneta] * 8.50;
            break;
    }
}

console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);

btn1up.addEventListener('click', () => {
    monetos.ct_1++;
    bendrassvoris += 2.3;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn1down.addEventListener('click', () => {
    if (monetos.ct_1 > 0) {
        monetos.ct_1--;
        bendrassvoris -= 2.3;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn2up.addEventListener('click', () => {
    monetos.ct_2++;
    bendrassvoris += 3.06;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn2down.addEventListener('click', () => {
    if (monetos.ct_2 > 0) {
        monetos.ct_2--;
        bendrassvoris -= 3.06;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn5up.addEventListener('click', () => {
    monetos.ct_5++;
    bendrassvoris += 3.92;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn5down.addEventListener('click', () => {
    if (monetos.ct_5 > 0) {
        monetos.ct_5--;
        bendrassvoris -= 3.92;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn10up.addEventListener('click', () => {
    monetos.ct_10++;
    bendrassvoris += 4.10;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn10down.addEventListener('click', () => {
    if (monetos.ct_10 > 0) {
        monetos.ct_10--;
        bendrassvoris -= 4.10;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn20up.addEventListener('click', () => {
    monetos.ct_20++;
    bendrassvoris += 5.74;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn20down.addEventListener('click', () => {
    if (monetos.ct_20 > 0) {
        monetos.ct_20--;
        bendrassvoris -= 5.74;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn50up.addEventListener('click', () => {
    monetos.ct_50++;
    bendrassvoris += 7.80;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn50down.addEventListener('click', () => {
    if (monetos.ct_50 > 0) {
        monetos.ct_50--;
        bendrassvoris -= 7.80;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn100up.addEventListener('click', () => {
    monetos.ct_100++;
    bendrassvoris += 7.50;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn100down.addEventListener('click', () => {
    if (monetos.ct_100 > 0) {
        monetos.ct_100--;
        bendrassvoris -= 7.50;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});
btn200up.addEventListener('click', () => {
    monetos.ct_200++;
    bendrassvoris += 8.50;
    console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
});
btn200down.addEventListener('click', () => {
    if (monetos.ct_200 > 0) {
        monetos.ct_200--;
        bendrassvoris -= 8.50;
        console.log(`Bendras monetų svoris yra ${bendrassvoris} g.`);
    }
    else {
        console.log('Monetų nėra');
    }
});

