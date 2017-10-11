function solve(number) {
    number = Number(number)
    let result = ''

    for (let i = 1; i <= number; i++) {
        let numToStr = i.toString()
        if (isSym(numToStr)) {
            result += numToStr + " "
        }
    }
    console.log(result)

    function isSym(str) {

        for (let i = 0; i < str.length / 2; i++) {
            if (str[i] != str[str.length - 1 - i]) {
                return false
            }
        }
        return true
    }
}

solve('750')