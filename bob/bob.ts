function isQuestion(message: string): boolean {
  return message.endsWith("?");
}

function isYelling(message: string): boolean {
  return message.split("").every((e) => e === e.toUpperCase());
}

function doesContainLetters(message: string): boolean {
  return message
    .split("")
    .some((e) => "abcdefghijklmnopqrstuvwxyz".includes(e.toLowerCase()));
}

export function hey(message: string): string {
  message = message.trim();
  if (doesContainLetters(message)) {
    if (isYelling(message) && isQuestion(message)) {
      return "Calm down, I know what I'm doing!";
    } else if (isYelling(message) && !isQuestion(message)) {
      return "Whoa, chill out!";
    } else if (isQuestion(message)) {
      return "Sure.";
    } else if (isYelling(message)) {
      return "Whoa, chill out!";
    }
  } else if (message === "") {
    return "Fine. Be that way!";
  } else if (isQuestion(message)) {
    return "Sure.";
  }
  return "Whatever.";
}
