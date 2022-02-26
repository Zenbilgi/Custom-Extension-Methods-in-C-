using System;
using CustomExtensionMethods;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    // The extension methods have a special symbol in intellisense of the Visual Studio, so that you can easily differentiate between class methods and extension methods.

    // LINQ is built upon extension methods that operate on IEnumerable and IQeryable type.

    int i = 10;
    bool result = i.IsGreaterThan(50);
    Console.WriteLine("Boolean result: " + result);

    string text = "Hello world mrs.Tash and mr.Tash ! on";
    int wordCount = text.WordCount();
    Console.WriteLine("The number of words in the variable: " + wordCount);

    // Primitive types
    decimal money = 123m;
    result = ((int)money).IsGreaterThan(500);
    Console.WriteLine("Decimal: " + money + ", Is greater than 5000: " + result);

  }
}