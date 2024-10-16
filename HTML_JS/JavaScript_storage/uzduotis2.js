if (window.confirm("Ar sutinkate su slapukų įrašymu?")) {
    sessionStorage.setItem("concent", "accepted");
  }

window.onload = function() {
    const consentStatusElement = document.getElementById("statusas");

    if (localStorage.getItem("concent") === "accepted") {
        consentStatusElement.innerHTML = "Turite sutikima lokaliam saugojimui";
    } 
    else if (sessionStorage.getItem("concent") === "accepted") {
        consentStatusElement.innerHTML = "Turite sutikima sesijai";
    } 
    else {
        consentStatusElement.innerHTML = "Neturiu jokiu sutikimu";
    }
};