function reverse(args) {
    args = args.map(Number)
    let reversed = []

    for (let i = 0; i < args.length; i++) {
        reversed.push(args[args.length - i - 1])
    }

    console.log(reversed.join("\n"))
}

reverse(
    ['10', '15', '20']
)