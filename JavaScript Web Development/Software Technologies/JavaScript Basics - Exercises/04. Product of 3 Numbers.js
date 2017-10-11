function solve(args) {
    args = args.map(Number)
    let count = 0;

    for (let i = 0; i < args.length; i++) {
        if (args[i] < 0) {
            count++
        }
    }

    if (count % 2 == 0) {
        console.log("Positive")
    } else {
        console.log("Negative")
    }
}

solve(['0','-4','5'])