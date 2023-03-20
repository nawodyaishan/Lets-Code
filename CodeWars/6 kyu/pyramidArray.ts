/*
Write a function that when given a number >= 0, returns an Array of ascending length sub arrays.

pyramid(0) => [ ]
pyramid(1) => [ [1] ]
pyramid(2) => [ [1], [1, 1] ]
pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]*/

// export function pyramid(n: number): number[][] {
//     const result: number[][] = [];
//
//     for (let i = 0; i < n; i++) {
//         const row: number[] = new Array(i + 1).fill(1);
//         result.push(row);
//     }
//     return result
// }

export function pyramid(n: number): number[][] {
    return Array.from({length: n}, (_, i) => Array(i+1).fill(1));
}
