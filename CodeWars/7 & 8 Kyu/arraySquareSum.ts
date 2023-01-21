export function squareSum(numbers: number[]): number {
  return numbers.reduce((acc, x) => acc + x ** 2, 0);
}
