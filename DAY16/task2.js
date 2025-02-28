// stringReplace.js
function stringReplace(originalString, searchString, replacement) {
    return originalString.split(searchString).join(replacement);
}

module.exports = stringReplace;