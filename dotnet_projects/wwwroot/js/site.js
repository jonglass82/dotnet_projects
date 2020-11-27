// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


//Calculator

var val1 = document.getElementById('val1');
var val2 = document.getElementById('val2');
var operator = document.getElementById('operator');

function setValue(val) {
    if (val == 0) {
        if (val1.value == "0" || val2.value == "0") {
            return;
        }
        else {
            operator.value.length > 0 ? val2.value += val : val1.value += val;
        }
    }
    else {
        if (operator.value.length > 0) {
            if (val == "." && val2.value.split('').includes(val)) {
                return 
            }
            else {
                val2.value += val;
            }
        }
        else {
            if (val == "." && val1.value.split('').includes(val)) {
                return
            }
            else {
                val1.value += val;
            }
        }
    }
}

function setOperator(op) {
    operator.value = op;
}

function positiveNegative() {
    operator.value.length > 0 ? val2.value = val2.value * -1 : val1.value = val1.value * -1;
}