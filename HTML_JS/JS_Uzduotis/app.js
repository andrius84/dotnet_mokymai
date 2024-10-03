/*-----------------------------------
Užduotis:
 
Parašykite programą, kuri naudodama `for` ciklą ir `switch`, apskaičiuotų turimų monetų bendrą svorį gramais.
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

let monetos = { ct_1: 3, ct_2: 1, ct_5: 10, ct_10: 5, ct_50: 2, ct_100: 7, ct_200: 4 };
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
