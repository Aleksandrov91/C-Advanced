function solve(args) {
    let result = {}
    let splittedStr = args.map(a => a.split(' -> '))
    for (kvp of splittedStr) {
        let key = kvp[0]
        let value = kvp[1]

        if (key === "age" || key === "grade") {
            result[key] = Number(value)
        } else {
            result[key] = value
        }
    }

    let jsonStr = JSON.stringify(result)
    console.log(jsonStr)
}

solve(
    'name -> Angel\nsurname -> Georgiev\nage -> 20\ngrade -> 6.00\ndate -> 23/05/1995\ntown -> Sofia'.split('\n'))