// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


//Calculator

var val1 = document.getElementById('val1');
var val2 = document.getElementById('val2');
var operator = document.getElementById('operator');

function setValue(val) {
    operator.value.length > 0 ? val2.value += val : val1.value += val;
}

function setOperator(op) {
    operator.value = op;
}

function positiveNegative() {
    operator.value.length > 0 ? val2.value = "-" + Val2.value : Val1.value = "-" + Val1.value;

}