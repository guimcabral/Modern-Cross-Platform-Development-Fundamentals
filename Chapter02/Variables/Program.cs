using System.Xml;

// there is a special type named object that can store any type of data, but its flexibility comes at the cost of
// messier code and possibly poor performance. Because of those two reasons, you should avoid it whenever possible.
object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");

// there is another special type named dynamic that can also store any type of data, but even more than object, its
// flexibility comes at the cost of performance. The dynamic keyword was introduced in C# 4.0. However, unlike object,
// the value stored in the variable can have its members invoked without an explicit cast.
// storing a string in a dynamic object
// string has a Length property
dynamic something = "Ahmed";

// int does not have a Length property
// something = 12;
// an array of any type has a Length property
// something = new[] { 3, 5, 7 };

// this compiles but would throw an exception at run-time if you later sotred a data type that does not have a property
// named Length
Console.WriteLine($"Length is {something.Length}");

// a literal number without a decimal point is inferred as an int variable, that is, unless you add a suffix, as
// described in the following list
// L: compiler infers long
// UL: compiler infers ulong
// M: compiler infers decimal
// D: compiler infers double
// F: compiler infers float
var price = 4.99M;

// good use of var because it avoids the repeated type as shown in the more verbose second statement
var xml1 = new XmlDocument(); // C# 3 and later
XmlDocument xml2 = new XmlDocument(); // all C# versions

// bad use of var because we cannot tell the type, so we shoul use a specific type declaration as shown in the second
// statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// when instantiating an object, you can specify the type first and then use new without repeating the type, as shown in
// the following code:
XmlDocument xml3 = new(); // target-typed new in C# 9 or later

// if you have a type with field or property that needs to be set, then the type can be inferred, as shown in the
// following code:
Person kim = new();
kim.Birthday = new(1967, 12, 26); // instead of: new DateTime(1967, 12, 26)

// this way of instantiating objects is especially useful with atays and collecions because they have multiple objects
// often of the same type, as sh'own in the following code:
List<Person> people = new()
{
    new() { FirstName = "Alice"},
    new() { FirstName = "Bob" },
    new() { FirstName = "Charlie" }
};

// most of primitive types except string are value types, which means that they must have a value. You can determine the
// default value of a type by using the defaut() operator and passing the type as a parameter. You can assign the
// default value of a type by using the default keyword
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

// add statements to declare a number, assign a value, and then reset it to its default value, as showing in the
// following code:
int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");