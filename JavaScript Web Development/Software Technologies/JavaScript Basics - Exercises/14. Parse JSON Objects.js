function solve(args) {
    let students = []
    args.forEach(jsonString => {
        let student = JSON.parse(jsonString)
        students.push(student)
    })
    Number(students.age)
    students.forEach(obj => {
        console.log(`Name: ${obj.name}`)
        console.log(`Age: ${obj.age}`)
        console.log(`Date: ${obj.date}`)
    })
}

solve('{"name":"Gosho","age":10,"date":"19/06/2005"}\n{"name":"Tosho","age":11,"date":"04/04/2005"}'.split('\n'))