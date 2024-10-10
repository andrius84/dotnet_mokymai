function toggle(elementId) {
    const input = document.getElementById("input").value;
    const output = document.getElementById(elementId);

    if (output.innerHTML === "") {
        output.innerHTML = input;
    } else {
        output.innerHTML = "";
    }
}

document.getElementById('button1').addEventListener('click', function() {
    toggle('output1');
});

document.getElementById('button2').addEventListener('click', function() {
    toggle('output2');
});

document.getElementById('button3').addEventListener('click', function() {
    toggle('output3');
});

document.getElementById('button4').addEventListener('click', function() {
    toggle('output4');
});