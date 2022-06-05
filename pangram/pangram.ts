export function isPangram(input: string): boolean {
  const alphabet = "abcdefghijkmlnopqrstuvwxyz";
  return new Set(input).size >= alphabet.length;
}
