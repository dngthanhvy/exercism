"use strict";
exports.__esModule = true;
exports.isPangram = void 0;
function isPangram(input) {
    var alphabet = "abcdefghijkmlnopqrstuvwxyz";
    return new Set(input).size >= alphabet.length;
}
exports.isPangram = isPangram;
