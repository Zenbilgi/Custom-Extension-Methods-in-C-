using System;

namespace CustomExtensionMethods {

  public static class IntExtensions {

    public static bool IsGreaterThan(this int i, int value) {
      return i > value;
    }

    public static int WordCount(this string str) {
      return str.Split(new char[] {
          ' ',
          '.',
          '?',
          '!'
        },
        StringSplitOptions.RemoveEmptyEntries).Length;
    }
    
  }

}