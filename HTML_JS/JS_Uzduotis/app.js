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

let monetos = {
    ct_1: 0,
    ct_2: 0,
    ct_5: 0,
    ct_10: 0,
    ct_20: 0,
    ct_50: 0,
    ct_100: 0,
    ct_200: 0
};

let monetuSvoris = {
    ct_1: 0,
    ct_2: 0,
    ct_5: 0,
    ct_10: 0,
    ct_20: 0,
    ct_50: 0,
    ct_100: 0,
    ct_200: 0
};

let svoriai = {
    ct_1: 2.3,
    ct_2: 3.06,
    ct_5: 3.92,
    ct_10: 4.10,
    ct_20: 5.74,
    ct_50: 7.80,
    ct_100: 7.50,
    ct_200: 8.50
};

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


function updateDisplay(coinType) {
    let quantityElement = document.querySelector(`#kiekis_ct_${coinType}`);
    let weightElement = document.querySelector(`#svoris_ct_${coinType}`);
    let bendrasSvorisElement = document.querySelector('#bendras_svoris');
    quantityElement.textContent = monetos[`ct_${coinType}`];
    weightElement.textContent = monetuSvoris[`ct_${coinType}`];
    bendrasSvorisElement.textContent = bendrassvoris;
}

function incrementCoin(coinType) {
    monetos[`ct_${coinType}`]++;
    bendrassvoris += svoriai[`ct_${coinType}`];
    monetuSvoris[`ct_${coinType}`] = monetos[`ct_${coinType}`] * svoriai[`ct_${coinType}`];
    updateDisplay(coinType);
}

function decrementCoin(coinType) {
    if (monetos[`ct_${coinType}`] > 0) {
        monetos[`ct_${coinType}`]--;
        bendrassvoris -= svoriai[`ct_${coinType}`];
        monetuSvoris[`ct_${coinType}`] = monetos[`ct_${coinType}`] * svoriai[`ct_${coinType}`];
        updateDisplay(coinType);
    } else {
        console.log('Monetų nėra');
    }
}



btn1up.addEventListener('click', () => incrementCoin(1));
btn1down.addEventListener('click', () => decrementCoin(1));

btn2up.addEventListener('click', () => incrementCoin(2));
btn2down.addEventListener('click', () => decrementCoin(2));

btn5up.addEventListener('click', () => incrementCoin(5));
btn5down.addEventListener('click', () => decrementCoin(5));

btn10up.addEventListener('click', () => incrementCoin(10));
btn10down.addEventListener('click', () => decrementCoin(10));

btn20up.addEventListener('click', () => incrementCoin(20));
btn20down.addEventListener('click', () => decrementCoin(20));

btn50up.addEventListener('click', () => incrementCoin(50));
btn50down.addEventListener('click', () => decrementCoin(50));

btn100up.addEventListener('click', () => incrementCoin(100));
btn100down.addEventListener('click', () => decrementCoin(100));

btn200up.addEventListener('click', () => incrementCoin(200));
btn200down.addEventListener('click', () => decrementCoin(200));
