int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// format a number with a currency value
WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
WriteLine(formatted);

// passing three values can use named arguments.
WriteLine(
 format: "{0} {1} lived in {2}.", 
 arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

// passing four or more values cannot use named arguments.
WriteLine(
 "{0} {1} lived in {2} and worked in the {3} team at {4}.", 
 "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// the following statement must be all on one line when using C# 10 or earlier.
// if using C# 11, we can include a line break, as shown here:
WriteLine($"{numberOfApples} apples cost {pricePerApple 
  * numberOfApples:C}");

// the full syntax of a format item is:
// { index [, alignment ] [ : formatString ] }
string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

// getting text input form the user
Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();

Write("Type your age and press ENTER: ");
string age = ReadLine()!; // null-forgiving operator

WriteLine($"Hello {firstName}, you look good for {age}.");

// getting key input from the user
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);