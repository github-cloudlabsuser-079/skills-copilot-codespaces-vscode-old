
const data = [
    [
        { name: 'John', age: 25 },
        { name: 'Jane', age: 30 }
    ],
    [
        { name: 'Bob', age: 40 }
    ]
];

const names = data.map(array => array.map(obj => obj.name)).flat();

console.log(names); // Output: ['John', 'Jane', 'Bob']

