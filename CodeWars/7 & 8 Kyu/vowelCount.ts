export class Kata {
  static getCount(str: string): number {
    let count: number = 0;
    for (let i = 0; i < str.length; i++) {
      const element = str[i];
      if (
        element === `a` ||
        element === `e` ||
        element === `i` ||
        element === `o` ||
        element === `u`
      ) {
        count++;
      }
    }
    return count;
  }
}

// export class Kata {
//   static getCount(str: string) {
//     let list = str.match(/[aeiou]/gi);
//     return list ? list.length : 0;
//   }
// }