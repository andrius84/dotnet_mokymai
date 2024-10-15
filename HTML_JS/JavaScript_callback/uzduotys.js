    let words = ['JavaScript', 'yra', 'galinga', 'kalba'];

    join1 = () => {
        let result = words.join('');   
        console.log(result); 
    }

    join4 = () => {
        let result = words.join('--');   
        console.log(result); 
    }

    join5 = () => {
        let result = words.join('!, ') + '!'; 
        console.log(result); 
    }

    join6 = () => {
        let result = words.join(','); 
        console.log(result); 
    }

let employees = [
    ['Jonas', 'Jonaitis', 30, 'Programuotojas'],
    ['Asta', 'Astaitė', 25, 'Projektų vadovė'],
    ['Petras', 'Petraitis', 35, 'Analitikas'],
    ['Inga', 'Ingaitytė', 28, 'Testuotoja']
];

//Užduotis 7
join7 = () => {
    for (let i = 0; i < employees.length; i++) {
        console.log(employees[i].join(','));
    }
}

//Pirminiai duomenys:
let vardai = ['Jonas', 'Asta', 'Petras', 'Inga'];
let skaiciai = [1, 2, 3, 4, 5];
let spalvos = ['Raudona', 'Zalia', 'Melyna', 'Geltona'];
const arr = ["I", "study", "JavaScript", "right", "now"];

let splice1 = () => {
    vardai.splice(1, 1);
    console.log(vardai);
}

let splice2 = () => {
    vardai.splice(1, 0, 'Tomas', 'Rita');
    console.log(vardai);
}

let splice3 = () => {
    skaiciai.splice(2, 3);
    console.log(skaiciai);
}

let splice4 = () => {
    skaiciai.splice(1, 1, 10, 11);
    console.log(skaiciai);
}

let splice5 = () => {
    spalvos.splice(-1, 1, 'Juoda', 'Balta');
    console.log(spalvos);
}

let splice6 = () => {
    arr.splice(0, 3);
    let newarr = arr.join('');
    console.log(newarr);
}

//Pradiniai duomenys:
let vardai1 = ['Jonas', 'Asta', 'Petras', 'Inga', 'Tomas', 'Rita', 'Mindaugas'];
let skaiciai1 = [1, 2, 3, 4, 5, 6, 7, 8];
let spalvos1 = ['Raudona', 'Zalia', 'Melyna', 'Geltona', 'Juoda'];

let slice1 = () => {
    let naujas = vardai1.slice(0, 3);
    console.log(naujas);
}

let slice2 = () => {
    let naujas = skaiciai1.slice(3, 6);
    console.log(naujas);
}

let slice3 = () => {
    let naujas = spalvos1.slice(-2);
    naujas.reverse();
    console.log(naujas);
}

slice4 = () => {
    let vardai2 = vardai1.slice();
    vardai2.push('Antanas');
    console.log(vardai1);
    console.log(vardai2);
}

slice5 = () => {
    let skaiciai2 = skaiciai1.slice(1, -1);
    console.log(skaiciai2);
}

//Pradiniai duomenys:
let pirmasMasyvas = [1, 2, 3];
let antrasMasyvas = [4, 5, 6];
let vardai3 = ['Jonas', 'Petras'];
let vardai4 = ['Asta', 'Inga'];
let spalvos3 = ['Raudona', 'Zalia', 'Melyna'];
 
let concat1 = () => {
    let result = pirmasMasyvas.concat(antrasMasyvas);
    console.log(result);
}

let concat2 = () => {
    let result = vardai3.concat(vardai4, 'Antanas', 'Rita');
    console.log(result);
}

let concat3 = () => {
    let result = spalvos3.concat('Geltona');
    console.log(result);
    console.log(spalvos3);
}

let concat4 = () => {
    let result = 'Labas'.concat(' ', 'Vakaras');
    console.log(result);
}

let vardai5 = ['Jonas', 'Asta', 'Petras', 'Inga', 'Tomas', 'Petras'];

let indexOf1 = () => {
    let result = vardai5.indexOf('Petras');
    console.log(result);
}

let skaiciai2 = [1, 2, 3, 4, 5, 3, 7, 8];

let indexOf2 = () => {
    let result = skaiciai2.indexOf(3, 4);
    console.log(result);
}

let spalvos4 = ['Raudona', 'Žalia', 'Mėlyna', 'Geltona', 'Žalia'];
let indexOf3 = () => {
    let result = spalvos4.indexOf('Geltona');
    if (result >= 0) {
        console.log('Suradau');
    } else {
        console.log('Nerasta');
    }
}

let vardai6 = ['Jonas', 'Asta', 'Petras', 'Inga', 'Tomas', 'Petras', 'Tomas', 'Petras'];
let indexOf4 = () => {
    let result1 = vardai6.indexOf('Petras');
    if (result1 >= 0) {
        let result2 = vardai6.indexOf('Petras', result1 + 1);
        console.log(result2);
    }
}

let skaiciai3 = [1, 2, 3, 4, 5, 3, 7, 8];
let indexOf5 = (skaicius) => {
    
let arr = [];
    for (let i = 0; i < skaiciai3.length; i++) {
        if (skaiciai3.indexOf(i) == skaiciai3.indexOf(skaicius)) {
            arr.push(i);
        }
    }
    console.log(arr);
}
indexOf5(3);