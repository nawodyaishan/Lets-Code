export function positiveSum(arr: number[]): number {
  let sum: number = 0;
  arr.forEach((x) => {
    sum = x > 0 ? sum + x : sum;
  });
  return sum;
}
