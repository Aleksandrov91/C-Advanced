function solve(args) {
    let result = {}

    for (let i = 0; i < args.length; i++) {
        let obj = JSON.parse(args[i])
        let currentTown = obj.town
        let currentIncome = Number(obj.income)

        if (result[currentTown] || result[currentTown === 0]) {
            result[currentTown] += currentIncome
        } else {
            result[currentTown] = currentIncome
        }
    }

    let towns = Object.keys(result).sort()

    for (let i = 0; i < towns.length; i++) {

        console.log(`${towns[i]} -> ${result[towns[i]]}`)
    }
}

solve([
    '{"town":"Sofia", "income":"200"}',
    '{"town":"Varna", "income":"120"}',
    '{"town":"Pleven", "income":"60"}',
    '{"town":"Varna", "income":"70"}'
    ]);