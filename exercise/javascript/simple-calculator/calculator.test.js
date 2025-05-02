const assert = require('assert');
const { add, subtract, multiply, divide } = require('./calculator');

describe('Calculator Tests', () => {
    test('Addition of two numbers', () => {
        assert.strictEqual(add(1, 2), 3);
        assert.strictEqual(add(-1, 1), 0);
    });

    test('Subtraction of two numbers', () => {
        assert.strictEqual(subtract(2, 1), 1);
        assert.strictEqual(subtract(1, 1), 0);
    });

    test('Multiplication of two numbers', () => {
        assert.strictEqual(multiply(2, 3), 6);
        assert.strictEqual(multiply(-1, 1), -1);
    });

    test('Division of two numbers', () => {
        assert.strictEqual(divide(6, 3), 2);
        assert.throws(() => divide(1, 0), Error);
    });
});