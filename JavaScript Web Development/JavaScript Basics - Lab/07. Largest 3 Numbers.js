function solve(args) {
    args = args.map(Number).sort((a, b) => b - a)

    let lenght = Math.min(args.length, 3)

    for (let i = 0; i < lenght; i++) {
        console.log(args[i])
    }
}

solve(
    ['10', '30', '15', '20', '50', '5']
)