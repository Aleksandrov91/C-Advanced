function Calculator(leftOperand, rightOperand, operator) {
    this.leftOperand = leftOperand;
    this.rightOperand = rightOperand;
    this.operator = operator;

    this.calculateResult = function () {
        let result = 0;

        switch (this.operator) {
            case "+":
                result = Number(this.leftOperand + this.rightOperand) || 'Error';
                break;
            case "-":
                result = Number(this.leftOperand - this.rightOperand) || 'Error';
                break;
            case "*":
                result = Number(this.leftOperand * this.rightOperand) || 'Error';
                break;
            case "/":
                result = Number(this.leftOperand / this.rightOperand) || 'Error';
                break;
            case "AND":
                result = Number(this.leftOperand & this.rightOperand) || 'Error';
                break;
            case "OR":
                result = Number(this.leftOperand || this.rightOperand) || 'Error';
                break;
            case "XOR":
                result = Number(this.leftOperand ^ this.rightOperand) || 'Error';
                break;
        }

        return result;
    }
};

module.exports = Calculator;
