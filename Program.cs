using System;
using System.Collections.Generic;

namespace ListIntro {
  class Program {
    static void Main (string[] args) {
      List<string> nssCohorts = new List<string> {
        "Cohort 36",
        "Cohort 37",
        "Cohort 38"

      };

      nssCohorts.Add ("Cohort 39");

      List<int> birthYears = new List<int> {
        1996,
        1992,
        1997,
        2001,
      };

      birthYears.Add (1999);

      foreach (string cohort in nssCohorts) {
        Console.WriteLine (cohort);
      }

      foreach (int year in birthYears) {
        Console.WriteLine (year);

        if (year == 1996) {
          Console.WriteLine ("Holden was born");
          Console.WriteLine ("The other thing");
        }
      }
      // dictionaries
      Dictionary<string, string> student = new Dictionary<string, string> ();

      student.Add ("Name", "Adam");
      student.Add ("Cohort", "Day 37");

      Dictionary<string, string> anotherStudent = new Dictionary<string, string> () { { "Name", "Brenda" }, { "Cohort", "Day 37" }
      };

      foreach (KeyValuePair<string, string> pair in student) {
        Console.WriteLine ($"The student's {pair.Key} is {pair.Value}");
      }

    }

  }
}