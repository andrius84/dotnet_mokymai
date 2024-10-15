let students = [
    { name: 'Jonas', grade: 4 },
    { name: 'Asta', grade: 9 },
    { name: 'Petras', grade: 6 },
    { name: 'Inga', grade: 2 },
    { name: 'Tomas', grade: 8 }
];

function filterStudents() {
    students = students.filter((student) => student.grade >= 5);
    students = students.sort((a, b) => b.grade - a.grade);
    console.log(students);
}
// filterStudents();

let numbers = [3, -1, 4, 3, -2, 5, -3, 4, 6, 7];

function filterNumbers() {
    numbers = numbers.filter(x => x > 0);
    numbers = numbers.sort((a, b) => a - b);
    console.log(numbers);
    let uniqueArr = numbers.filter((n, index) => numbers.indexOf(n) === index);
    console.log(uniqueArr);
    let sumOfArr = [];
    uniqueArr.map(x => suma += x);
}
filterNumbers();