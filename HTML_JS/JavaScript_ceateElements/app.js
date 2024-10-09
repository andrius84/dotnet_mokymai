document.addEventListener("DOMContentLoaded", function() {
    const input = document.getElementById("number");
    console.log("input.value", input.value);

    input.addEventListener("blur", function() {

        const value = input.value;
        const message = document.createElement("div");
        message.classList.add("message");

        if (!isNaN(value) && value >= 0 && value <= 99) {
            message.textContent = "Tai yra skaičius, tarp 0 ir 99";
            message.classList.add("success-message");
            input.parentNode.prepend(message);
        } else {
            message.textContent = "Tai yra ne skaičius, arba skaičius nėra tarp 0 ir 99, jūs įvedėte: " + value;
            message.classList.add("error-message");
            input.parentNode.append(message);
        }
        
        setTimeout(() => {
            message.remove();
        }, 3000);
        
    });
});

