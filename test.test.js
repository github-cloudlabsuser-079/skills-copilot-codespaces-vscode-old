const calculator = {
    // Define the current value of the calculator
    currentValue: 0,

    // Add a number to the current value
    add: function(num) {
        this.currentValue += num;
    },

    // Subtract a number from the current value
    subtract: function(num) {
        this.currentValue -= num;
    },

    // Multiply the current value by a number
    multiply: function(num) {
        this.currentValue *= num;
    },

    // Divide the current value by a number
    divide: function(num) {
        this.currentValue /= num;
    },

    // Clear the current value
    clear: function() {
        this.currentValue = 0;
    }
};

// Test the calculator object
console.assert(calculator.currentValue === 0, 'Initial value should be 0');

calculator.add(5);
console.assert(calculator.currentValue === 5, 'Addition failed');

calculator.subtract(2);
console.assert(calculator.currentValue === 3, 'Subtraction failed');

calculator.multiply(4);
console.assert(calculator.currentValue === 12, 'Multiplication failed');

calculator.divide(3);
console.assert(calculator.currentValue === 4, 'Division failed');

calculator.clear();
console.assert(calculator.currentValue === 0, 'Clear failed');