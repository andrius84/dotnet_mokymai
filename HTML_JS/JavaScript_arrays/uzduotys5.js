let darbuotojai = ['Jonas', 'Petras', 'Asta', 'Rita', 'Tomas', 'Mindaugas', 'Dalia', 'Saulius', 'Inga'];

function parodytiDarbuotojus() {
    console.log(darbuotojai);
}

parodytiDarbuotojus();

function pridetiDarbuotoja(darbuotojas) {
    darbuotojai.push(darbuotojas);
}

pridetiDarbuotoja('Ieva');
pridetiDarbuotoja('Rasa');
pridetiDarbuotoja('Vaida');

parodytiDarbuotojus();

let vardas = 'Jonas';

function ifNameExist(vardas) {
    let found = false;
    for (let i = 0; i < darbuotojai.length; i++) {
        if (darbuotojai[i] === vardas) {
            found = true;
            break;
        }
    }
    found ? console.log('Darbuotojas yra') : console.log('Darbuotojo nera');
}







