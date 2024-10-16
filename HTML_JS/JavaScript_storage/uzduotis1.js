document.addEventListener('keyup', function(event) {
    const liveText = document.getElementById('text');
    if(event.key.length === 1 ){
        liveText.innerHTML += event.key;
    }
});

function save() {
    const text = document.getElementById('text');
    console.log(text.innerHTML);
    localStorage.setItem('textas', text.innerHTML); 
}

