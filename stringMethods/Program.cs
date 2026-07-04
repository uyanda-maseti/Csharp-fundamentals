Console.WriteLine();


// string message = "What is the value <div>between the tags</div>?";

// const string openSpan = "<div>";
// const string closeSpan = "</div>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
// string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += 6;
int length = closingPosition - openingPosition;

quantity += input.Substring(openingPosition, length);



Console.WriteLine(quantity);
// Console.WriteLine(output);


Console.WriteLine();
