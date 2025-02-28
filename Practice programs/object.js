let student = {
    rollNo: 43,
    name: 'Samiksha Jain',
    course: 'JavaScript Programming'
};

 
// dot notation using .(dot) operator
console.log(student);
console.log(student.rollNo);
console.log(student.name);
console.log(student.course);


// bracket notation like ['nick-name']
console.log(student['rollNo']);
console.log(student['name']);
console.log(student['course']);


// typeof returns object
console.log(typeof student);
console.log(typeof student.rollNo);
console.log(typeof student.name);
console.log(typeof student.course);


// Deleting values 
delete student.course;
console.log(student);
student.year = 'second';
console.log(student);

// 

