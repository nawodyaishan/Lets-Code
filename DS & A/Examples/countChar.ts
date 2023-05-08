// Writing a function that takes in string and return the counts of each character in the string
// Example
// charCount("aaaa") {a:4}


// function charCount(str: string): Map<string, number> {
//     // Initialize an empty Map to store the character counts
//     const charCounts = new Map<string, number>();
//
//     // Loop through each character in the input string
//     for (const char of str) {
//         // If the character is not in the charCounts Map, add it with a count of 1
//         // Otherwise, increment the count for that character
//         charCounts.set(char, (charCounts.get(char) || 0) + 1);
//     }
//
//     // Return the final charCounts Map
//     return charCounts;
// }


function charCount(str: string): Record<string, number> {
    // Initialize an empty object to store the character counts
    const charCounts: Record<string, number> = {};

    // Loop through each character in the input string
    for (const char of str) {
        // If the character is not in the charCounts object, add it with a count of 1
        // Otherwise, increment the count for that character
        charCounts[char] = charCounts[char] ? charCounts[char] + 1 : 1;
    }

    // Return the final charCounts object
    return charCounts;
}


