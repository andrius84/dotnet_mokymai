let textArray = [];

function save() {

    const text = document.getElementById('text').value;
    textArray.push(text);

    clearInput();

    sessionStorage.setItem(generateRandomKey(3), (textArray));
}

function clearInput() {
    document.getElementById('text').value = '';
}

function generateRandomKey(length) {
    const characters = '0123456789';
    let randomKey = '';
    for (let i = 0; i < length; i++) {
        const randomIndex = Math.floor(Math.random() * characters.length);
        randomKey += characters[randomIndex];
    }
    return 'text' + randomKey;
}