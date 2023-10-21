using System;
using System.Collections.Generic;
using Fundamentals.CodePractice;
using Fundamentals.ChallengesSection;

namespace Fundamentals
{
  class Program
  {
    public static void Main(string[] args)
    {
      /*
      string optionMessage = "Hello!" +
      "\n[S]ee all TODOs" +
      "\n[A]dd a TODO" +
      "\n[R]emove a TODO" +
      "\n[E]xit" +
      "\n-> ";
       */

      // Arrays.WorkingWithMultiDimensionalArrays();
      // int[,] numbers = new int[0, 5];
      // Console.WriteLine(CodingExercises.FindMax(numbers));
      Console.Clear();

      // This method runs an entire application that use Lists.
      // Lists.PlayingWithLists();

      // Lists.BeginingWithLists();

      /*
      List<string> words = new List<string>() {
        "hola",
        "bb",
        "SDFASDF",
        "Jf45",
        "FF23",
        "HT##$"
      };
       */

      /*
      var wordsOnlyUpperCase = Lists.GetOnlyUpperCaseWords(words);
      foreach (string word in wordsOnlyUpperCase)
      {
        Console.WriteLine(word);
      }
      */

      // OutKeyword.FirstSampleWithOutKeyWord();

      // TryParseMethod.FirstSample();

      TODOList.RunToDoApp();
    }
  }
}
