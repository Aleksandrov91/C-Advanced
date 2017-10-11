function solve(args) {
    args = args.join(",")
    args = args.split(/\W+/)
    let nonEmptyWords = args.filter(w => w.length > 0)

    function isUppercase(str) {
        return str == str.toUpperCase()
    }

    let isUpperCaseWords = nonEmptyWords.filter(isUppercase)

    console.log(isUpperCaseWords.join(', '))
}

solve([
    'We start by HTML, CSS, JavaScript, JSON and REST.',
    'Later we touch some PHP, MySQL and SQL.',
    'Later we play with C#, EF, SQL Server and ASP.NET MVC.',
    'Finally, we touch some Java, Hibernate and Spring.MVC.'
])