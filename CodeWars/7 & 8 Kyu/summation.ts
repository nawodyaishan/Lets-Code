export const summation = (num: number) => {
  if (num < 0) {
    num = num * -1;
  }
  let sum: number = 0;
  for (let i: number = 1; num >= i; i++) {
    sum += i;
  }
  return sum;
};
