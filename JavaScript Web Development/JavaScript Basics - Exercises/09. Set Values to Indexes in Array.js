function indexes(args) {
    let arrayLength = Number(args.shift())
    let result = new Array(arrayLength).fill(0)

    for (let i = 0; i < args.length; i++) {
        let arrayIndexes = args[i].split(" - ").map(Number)
        result[arrayIndexes[0]] = arrayIndexes[1]
    }
    console.log(result.join("\n"))
}

indexes(
    ['3', '0 - 5', '1 - 6', '2 - 7']
)