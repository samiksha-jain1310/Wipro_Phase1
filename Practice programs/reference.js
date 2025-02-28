let student = {
    rollNo: 43,
    name: 'Samiksha Jain',
    course: 'JavaScript Programming'
};


let num1 = 10;
let num2 = num1;
let student2 =  student;

console.log(num2);
console.log(student2);

num1 = 15;
delete student.name;

console.log(num2);
console.log(student2);

