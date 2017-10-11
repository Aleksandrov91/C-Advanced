function multiplyOrDivide(args) {
    args = args.map(Number)
    let firstNum = args[0]
    let secondNUm = args[1]

    if (firstNum <= secondNUm) {
        var result = firstNum * secondNUm
    } else {
        result = firstNum / secondNUm
    }

    console.log(result)
}

multiplyOrDivide(['144','12'])