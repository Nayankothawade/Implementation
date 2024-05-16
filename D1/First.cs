// Hello C#

// (1) Print
Console.WriteLine("Hello World");

// (2) Variable and .Length Function
String aFriend = "Scott";
Console.WriteLine($"Hello {aFriend}");

String firstFriend = "Scott";
String secontFriend = "Kendra";
Console.WriteLine($"My Friends are {firstFriend} and {secontFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
Console.WriteLine($"The name {secontFriend} has {secontFriend.Length} letters");

// (3) Trim Functions
String greeting = "    Hello World!    ";
Console.WriteLine($"[{greeting}]");

String trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// (4) UpperCase, LowerCase & Replace Function
String sayHello = "Hello World!";
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

String sayBello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayBello);

// (5) Replace, StartWith, EndWith Function
String songLyrics = "You say greetings, I say hello";
Console.WriteLine(songLyrics.Contains("greetings"));

var result = songLyrics.Contains("goodbye");
Console.WriteLine(result);

Console.WriteLine(songLyrics.StartsWith("You"));

result = songLyrics.EndsWith("hi");
Console.WriteLine(result);