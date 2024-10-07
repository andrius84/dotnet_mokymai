function showMessage1() {
    console.log("Funkcija_1");
}
showMessage1();

let showMessage2 = () => { console.log("Funkcija_2"); }
showMessage2();


let amzius = 17;

function showMessage3() {
    console.log("Funkcija_3");
    if (amzius >= 18) {
        console.log("Jūs galite gerti energetinius gėrimus");
    }
    else {
        confirm("Ar tevai dave leidima?");
    }
}
showMessage3();


function showMessage4() {
    console.log("Funkcija_4");
    amzius >= 18 
        ? console.log("Jūs galite gerti energetinius gėrimus") 
        : confirm("Ar tevai dave leidima?");
}
showMessage4();