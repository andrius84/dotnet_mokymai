let darbuotojai = ['Jonas', 'Petras', 'Asta', 'Rita', 'Tomas', 'Mindaugas', 'Dalia', 'Saulius', 'Inga'];
console.log("Pridėti darbuotojai");
darbuotojai[9] = 'Ieva';
darbuotojai[10] = 'Rasa';
darbuotojai[11] = 'Vaidas';
darbuotojai[12] = 'Darius';
console.log(darbuotojai);

console.log("Atskirtos moterys");
let vyrai = ['Jonas', 'Petras', 'Tomas', 'Mindaugas', 'Saulius', 'Vaidas', 'Darius'];
darbuotojai = darbuotojai.filter(vardas => !vyrai.includes(vardas));
console.log(darbuotojai);

console.log("Pridėtos pavardes");
let darbuotojai2 = ['Jonas', 'Petras', 'Asta', 'Rita', 'Tomas', 'Mindaugas', 'Dalia', 'Saulius', 'Inga'];
darbuotojai2[0] = 'Jonas Jonaitis';
darbuotojai2[1] = 'Petras Petraitis';
darbuotojai2[2] = 'Asta Astaitė';
darbuotojai2[3] = 'Rita Raitė';
darbuotojai2[4] = 'Tomas Tomaitis';
darbuotojai2[5] = 'Mindaugas Mindaugaitis';
darbuotojai2[6] = 'Dalia Daliaitė';
darbuotojai2[7] = 'Saulius Sauliusaitis';
darbuotojai2[8] = 'Inga Ingaitytė';
console.log(darbuotojai2);

console.log("Darbuotojai pagal abėcėlę ir padalinti į dvi grupes");
let darbuotojai3 = ['Jonas', 'Petras', 'Asta', 'Rita', 'Tomas', 'Mindaugas', 'Dalia', 'Saulius'];
darbuotojai3.sort();
let array1 = darbuotojai3.slice(0, 4);
let array2 = darbuotojai3.slice(4);
console.log("First array:", array1);
console.log("Second array:", array2);

array1 = array1[0] = '' ;
console.log(array1);