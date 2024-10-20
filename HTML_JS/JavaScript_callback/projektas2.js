// Užduotis 1:

const listItems = document.querySelectorAll('li');
const listArray = Array.from(listItems);
const initialArray = Array.from(listItems).map(item => item.textContent);

console.log(listArray);
console.log(initialArray);

const addIndex = () => {   
    listArray.map((item) => {item.innerHTML = '#' + listArray.indexOf(item) + ': ' + item.innerHTML;});
}

// Užduotis 2:

const buttonReset = document.createElement('button');
buttonReset.textContent = 'Atstatyti';
document.body.appendChild(buttonReset);

const resetList = () => {
    listItems.forEach((item, index) => {
        item.textContent = initialArray[index]; 
    });
};

buttonReset.addEventListener('click', resetList);

// Užduotis 3:

const toUpper = () => {
    const listArray = Array.from(listItems);
    listArray.map((item) => {item.innerHTML = item.innerHTML.toUpperCase();});
};

// Užduotis 4:

const addLenght = () => {
    const listArray = Array.from(listItems);
    listArray.map((item) => {item.innerHTML = item.innerHTML + ' (' + item.innerHTML.length + ' raidės)';});
};

// Užduotis 5:

const toInitials = () => {
    const listArray = Array.from(listItems);
    listArray.map((item) => {
        const initials = item.innerHTML.split(' ').map((word) => word[0]).join('. ');
        item.innerHTML = initials + '.';
    });
}