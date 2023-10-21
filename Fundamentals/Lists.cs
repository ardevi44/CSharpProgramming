using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Fundamentals
{

  class Lists
  {

    public static void PlayingWithLists()
    {
      // One way to initialize Lists
      // List<string> words = new List<string>();
      // Another way ...
      // var names = new string[] { "Arbey", "Daniel", "Marisol", "Jonas", "Martha", "Noah" };

      List<string> names = new List<string>
      {
        "Arbey"
      };
      Console.WriteLine("List of names: \n");
      foreach (string name in names)
      {
        Console.WriteLine($"- {name}");
      }

      Console.WriteLine("\nNumber of elements in the list: " + names.Count);
      string word = "";
      bool isProgramExit = false;
      do
      {
        Console.Write(
          $"\n\nIntroduce..." +
          $"\n\n[A]dd to add an element to the list." +
          $"\n[R]emove to remove an element from the list." +
          $"\n[S]top to exit the prorgram." +
          $"\n-> ");
        word = Console.ReadLine();
        string name = "";
        switch (word.ToLower())
        {
          case "a":
          case "add":
            do
            {
              Console.Write("\nSet the element to add -> ");
              name = Console.ReadLine();
              if (name.Length < 3)
              {
                Console.WriteLine("\nThe name should have at least 3 characters.");
              }
            } while (name.Length < 3);

            names.Add(name);
            Console.WriteLine($"\nNumber of elements in the list: {names.Count}");
            Console.WriteLine($"\nThe list after add \"{name}\" now is:");
            foreach (string w in names)
            {
              Console.WriteLine($"- {w}");
            }
            break;
          case "r":
          case "remove":
            if (names.Count == 0)
            {
              Console.WriteLine("\n\nList empty, Actually add new elements is highly recommended" +
              "\nbefore the next remove action.");
              break;
            }
            do
            {
              Console.Write("\nSet the element to Remove -> ");
              name = Console.ReadLine();
              if (!names.Contains(name))
              {
                Console.WriteLine($"\nThe name \"{name}\" should exists in the list");
              }
            } while (!names.Contains(name));

            names.Remove(name);
            if (names.Count == 0)
            {
              Console.WriteLine($"\n\n-> List empty!!!\nNo elements to remove.");
              break;
            }
            Console.WriteLine($"\nNumber of elements in the list: {names.Count}");
            Console.WriteLine($"\nThe list after remove \"{name}\" now is:");
            foreach (string w in names)
            {
              Console.WriteLine($"- {w}");
            }
            break;
          case "s":
          case "stop":
            Console.WriteLine($"\nThe programm is finished ...");
            isProgramExit = true;
            break;
          default:
            Console.WriteLine($"\n\"{word}\" is not an option, try again.");
            break;
        }
      } while (!isProgramExit);
    }

    public static void BeginingWithLists()
    {
      List<string> words = new List<string>();

      // Is also posible declare a List like this ...
      List<int> numbers = new List<int> { 1, 34, 21, 11, 22 };

      // The number of elements in the List.
      Console.WriteLine("Count of elements is " + words.Count);
      // Add a new element at the end of the List
      words.Add("Hello");
      Console.WriteLine("Count of elements is " + words.Count);
      // Iterate over a List
      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }

      // Accessing a value of the list and change it
      // Remember we can't access an index that doesn't exist.
      numbers[2] = 2345;

      // Also we can remove elements
      numbers.Remove(1);
      // Remove from an index
      numbers.RemoveAt(3);

      string[] words2 = new string[] { "Hello", "world", "How", "are", "you" };
      // We can also add new values from array or simple range of values.
      words.AddRange(words2);
      foreach (string value in words)
      {
        Console.WriteLine(value);
      }

    }

    public static List<string> GetOnlyUpperCaseWords(List<string> words)
    {
      List<string> onlyUpperCases = new List<string>();

      foreach (string word in words)
      {
        if (word.ToUpper() == word)
        {
          bool notSpecialCharacters = true;
          foreach (char letter in word)
          {
            if (letter.ToString().ToLower() == letter.ToString())
            {
              notSpecialCharacters = false;
              break;
            }
          }
          if (notSpecialCharacters && !onlyUpperCases.Contains(word))
          {
            onlyUpperCases.Add(word);
          }
        }
      }

      // foreach (string word in onlyUpperCases)
      // {
      //   Console.WriteLine(word);
      // }
      return onlyUpperCases;
    }
  }
}