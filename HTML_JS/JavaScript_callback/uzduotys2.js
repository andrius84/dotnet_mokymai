let numbers = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6];

const budgets = [
  {
    name: "Rytis",
    budget: 50,
  },
  {
    name: "Saulė",
    budget: 230,
  },
  {
    name: "Paulius",
    budget: 1500,
  },
  {
    name: "Gytis",
    budget: 92,
  },
  {
    name: "Sandra",
    budget: 7,
  },
];

const arrDoubled = () => {
    let arrMultipled = numbers.map((number) => number * 2);
    console.log(arrMultipled);
}

const arrMultiplied = (multiplier) => {
    let arrMultiplied = numbers.map((number) => number * multiplier);
    console.log(arrMultiplied);
}

const getBudgets = () => {
    let sum = 0;
    arr.map((item) => sum += item.budget);
    return sum;
}

const getNames = () => {
    return names = arr.map(item => item.name);
}

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
const arrFilter = () => {
    let arrfiltered = arr.filter((number) => number % 2);
    console.log(arrfiltered);
}

const arrVardai = ['Jonas', 'Asta', 'Petras', 'Inga', 'Tomas'];
const arrFilterVardai = () => {
    let arrfiltered = arrVardai.filter((name) => name.length > 4);
    console.log(arrfiltered);
}
//arrFilterVardai();

const arrObject = 
[
    { name: 'Jonas', age: 25 },
    { name: 'Asta', age: 30 },
    { name: 'Petras', age: 35 },
    { name: 'Inga', age: 28 },
    { name: 'Tomas', age: 40 }
]

const arrFilterObject = () => {
    let arrfiltered = arrObject.filter((item) => item.age > 30);
    console.log(arrfiltered);
}
// arrFilterObject();

const arrObject1 =
[
    { name: 'Jonas', age: 25 },
    { name: 'Asta', age: 30 },
    { name: 'Petras', age: 35 },
    { name: 'Inga', age: 28 },
    { name: 'Tomas', age: 40 }
]

const arrFilterObject1 = () => {
    let arrfiltered = arrObject1.filter((item) => item.name.startsWith('J'));
    console.log(arrfiltered);
}
arrFilterObject1();