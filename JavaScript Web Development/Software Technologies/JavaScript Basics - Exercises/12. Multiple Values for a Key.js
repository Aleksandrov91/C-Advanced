function solve(args) {
    let result = {}
    let token = args.pop()

    for (kvp of args) {
        let key = kvp.split(' ')[0]
        let value = kvp.split(' ')[1]
        if (result[key]) {
            result[key].push(value)
        } else {
            result[key] = [value]
        }
    }

    console.log(result[token] ? result[token].join('\n') : "None")
}

solve("3 bla\n3 alb\n2".split('\n'))