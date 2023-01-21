export function findSmallestInt(args: number[]): number {
  return args.reduce((a, b) => Math.min(a, b));
}
