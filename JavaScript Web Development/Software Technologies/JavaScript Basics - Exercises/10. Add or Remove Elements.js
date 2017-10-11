function solve(args) {
    debugger
    let result = []
    for (let i = 0; i < args.length; i++) {
        let line = args[i].split(' ')
        let command = line[0]
        let number = Number(line[1])

        if (command === "add") {
            result.push(number)
        } else {
            if (number < result.length) {
                result.splice(number, 1)
            }
        }
    }

    console.log(result.join("\n"))
}

solve(
    ['add 3', 'add 5', 'remove 2', 'remove 0', 'add 7']
)