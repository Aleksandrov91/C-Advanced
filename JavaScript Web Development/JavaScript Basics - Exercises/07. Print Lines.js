function solve(args) {
    let text = []
    for (let i = 0; i < args.length; i++) {
        if (args[i] === "Stop") {
            break
        }
        text.push(args[i])
    }
    console.log(text.join("\n"))
}

solve(['Line 1', 'Line 2', 'Stop', '10'])