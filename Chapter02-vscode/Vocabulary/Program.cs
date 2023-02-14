using System.Reflection;

// declare some unused variables using types
// in aditional assemblies
System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return; // quit the app

// Loop through the assemblies thtat my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
  // Load the assembly so we can read its details
  Assembly a = Assembly.Load(name);

  // declare a variable to count the number of methods
  int methodCount = 0;

  // loop through all the types in the assembly
  foreach (TypeInfo t in a.DefinedTypes)
  {
    // add up the counts of methods
    methodCount += t.GetMethods().Count();
  }

  // output the count of types and their methods
  Console.WriteLine(
    // N0 means "format a number (N) with zero (0) decimal places."
    "{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}

#region code snippets

// assigning a string returned form the string class constructor
string horizontalLine = new ('-', count: 74); // 74 hypens
Console.WriteLine(horizontalLine);

// assigning an emoji by converting form Unicode
string grinningEmoji = char.ConvertFromUtf32(0x1F600);

// to output emoji at command line on Windows, you must use Windows Terminal because Command Prompt does not support
// emoji, and set the output encoding to use UTF-8, as shown in the following code:
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(grinningEmoji);

// include a espace sequence (\t) which represent a special character (tab)
string fullNameWithTabSeparator = "Bob\tSmith";
Console.WriteLine(fullNameWithTabSeparator);

// but this can cause errors
string filePathBroken = "C:\television";
Console.WriteLine(filePathBroken);

// you must use @ symbol to use a verbatim literal string
string filePath = @"C:\television";
Console.WriteLine(filePath);

// raw string literals are convenient for entering any arbitrary text
// without needing to escape the contents
string xml = """
            <person age="50">
              <first_name>Mark</first_name>
            </person>
            """;
Console.WriteLine(xml);

// you can mix interpolated string that use curly braces {} with raw
// string literals. You specify the number of braces that indicate a replaced expression by adding that number of dollar
// signs to the start of the literal. Any fewer braces than that are treated as raw content
var person = new {FirstName = "Alice", Age = 56};
string json = $$"""
              {
                "first_name": "{{person.FirstName}}",
                "age": "{{person.Age}}",
                "calculation", "{{{1 + 2}}}"
              }
              """;
Console.WriteLine(json);

#endregion