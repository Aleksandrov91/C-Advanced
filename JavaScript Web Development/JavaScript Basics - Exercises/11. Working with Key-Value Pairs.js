function solve(args) {
    let printKey = args.pop()
    let result = {}

    for (let i = 0; i < args.length; i++) {
        let splitted = args[i].split(' ')
        let key = splitted[0]
        let value = splitted[1]

        result[key] = value
    }

            console.log(result[printKey] || "None")
}

solve(
    ['key value', 'key eulav', 'test tset', 'key']
)