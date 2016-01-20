var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

function Person(firstname, lastname, age) {
    var person = {
        firstname: firstname,
        lastname: lastname,
        age: parseInt(age)
    };
    return person;
};

function groupBy(arr, criteria) {
    if (criteria === 'lastname') {
        arr.sort(function (a, b) {
            return a.lastname.localeCompare(b.lastname);
        });
    } else if (criteria === 'firstname') {
        arr.sort(function (a, b) {
            return a.firstname.localeCompare(b.firstname);
        });
    } else {
        arr.sort(function (a, b) {
            return a.age > b.age;
        });

    }
    console.log(arr);
}

console.log('Grouped by firstname: ');
groupBy(people, 'firstname');
console.log('Grouped by lastname: ');
groupBy(people, 'lastname');
console.log('Grouped by age: ');
groupBy(people, 'age');
