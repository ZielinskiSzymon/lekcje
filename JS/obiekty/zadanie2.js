const students = [
    {
        firstName: 'Tomasz',
        lastName: 'Doe',
        age: 25,
        grands : [5, 4, 3, 5, 5]
    },
    {
        firstName: 'John',
        lastName: 'Newman',
        age: 22,
        grands : [3, 3, 3, 4, 6]
    },
    {
        firstName: 'Alice',
        lastName: 'Brun',
        age: 28,
        grands : [4, 3, 4, 4, 5]
    }


]
function displayStudents(students) {
    students.forEach(student => {
        const {firstName, lastName, age, grands} = student;
        const average = grands.reduce((a, b) => a + b) / grands.length;
        console.log(`Student: ${firstName} ${lastName}, age: ${age}, average grade: ${average}`);
    });
}
displayStudents(students);