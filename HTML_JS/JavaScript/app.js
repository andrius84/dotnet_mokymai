/*-----------------------------------
Užduotis 3:
Parašykite funkciją su vienu parametru 'x',  kurioje naudojamas for ciklas, kuris sudeda visus 
skaičius nuo x iki 100 imtinai ir grąžina galutinę sumą.
Parašykite su kokiomis 'x' reikšmėmis tikrinimote ar funkcija veikia korektiškai ir kokius rezultatus
 gavote.Kodėl pasirinkote tokias reikšmes?
*/

function sumFromXto100(x) {
    let sum = 0;
    for (let i = x; i <= 100; i++) {
        sum += i;
    }
    return sum;
}

console.log(sumFromXto100(99)); // rezultatas 199
console.log(sumFromXto100(100)); // rezultatas 100
console.log(sumFromXto100(101)); // rezultatas 0 