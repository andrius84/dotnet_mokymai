const person = {
    name: "Rosa",
    age: 120,
    alive: false,
    interest: ["swimming, cards"],
};

person.name = "Ana";
person.age = Math.floor(Math.random() * 100) + 20;

if (person.age < 100) {
    person.alive = !person.alive;
    person.interest.push("running");
}

console.log(person);