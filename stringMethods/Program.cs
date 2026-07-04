Console.WriteLine();


string message = "What is the value <div>between the tags</div>?";

const string openSpan = "<div>";
const string closeSpan = "</div>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

Console.WriteLine();
