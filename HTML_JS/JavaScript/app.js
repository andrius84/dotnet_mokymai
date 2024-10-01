/*
Užduotis 14:
Sukurkite puslapį, kuriame būtų 3 mygtukai "daugiau C", "mažiau C", "daugiau F" ir "mažiau F".
Paspaudus "daugiau" mygtuką, skaičius padidėtų vienetu, o paspaudus "mažiau" mygtuką, skaičius sumažėtų vienetu.
Keičiami skaičiai verčiami iš Celsijaus į Farenheito ir atvirkščiai.
Sukurk dvi funkcijas:
 
    convertToFahrenheit – konvertuoja temperatūrą iš Celsijaus į Farenheito laipsnius.
    convertToCelsius – konvertuoja temperatūrą iš Farenheito į Celsijaus laipsnius.
 
Panaudokite šias funkcijas mygtukų veiksmams įvykdyti.
Rezultatai turi būti išvesti į konsolę.
 */

let celsius = 0;
let fahrenheit = 0;

const buttonDaugiau = document.getElementById("daugiau");
const buttonMaziau = document.getElementById("maziau");
const CorF = document.getElementById("CorF");

function convertToFahrenheit(celsius) {
    return celsius * 9 / 5 + 32;
}

function convertToCelsius(fahrenheit) {
    return (fahrenheit - 32) * 5 / 9;
}

if (buttonDaugiau) {
    buttonDaugiau.addEventListener("click", () => {
        celsius++;
        fahrenheit = convertToFahrenheit(celsius);
        console.log(`${celsius} C = ${fahrenheit} F`);
    });
}
if (buttonMaziau) {
    buttonMaziau.addEventListener("click", () => {
        celsius--;
        fahrenheit = convertToFahrenheit(celsius);
        console.log(`${celsius} C = ${fahrenheit} F`);
    });
}
if (CorF) {
    CorF.addEventListener("click", () => {
        if (CorF.innerText === "C") {
            CorF.innerText = "F";
            console.log(`${celsius} C = ${fahrenheit} F`);
        } else {
            CorF.innerText = "C";
            console.log(`${fahrenheit} F = ${celsius} C`);
        }
    });
}

