const person = {
    name: "Jonas",
    toysArray: ["Lego", "Puzzle", "Computer"],
    yearsOld: 15,
    birthday: true,
    totalToys: null,
    friends: [
        { name: "Marius", activity: "Mokosi" },
        { name: "Lina", activity: "Piešia" },
        { name: "Simona", activity: "Bėgioja" }
    ]
};

if (person.birthday) {

    person.toysArray.shift(); 
    person.toysArray.push("Kamuolys");
    person.yearsOld += 1;
    person.totalToys = person.toysArray.length;

    person.friends.forEach(friend => {
        console.log(`${friend.name} ${friend.activity}.`);
    });
}

console.log(person);