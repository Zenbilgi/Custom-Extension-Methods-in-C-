/*
using System;

namespace CustomExtensionMethods {

  class Program {
    static void Main(string[] args) {
      int i = 10;
      bool result = i.IsGreaterThan(5);
      Console.WriteLine("Boolean result: " + result);

      string text = "Hello world!";
      Console.WriteLine("The number of words in the variable: " + text.WordCount());
    }
  }

  public static class IntExtensions {
    public static bool IsGreaterThan(this int i, int value) {
      return i > value;
    }

    public static int WordCount(this string str) {
      return str.Split(new char[] {
          ' ',
          '.',
          '?'
        },
        StringSplitOptions.RemoveEmptyEntries).Length;
    }
  }

}
*/