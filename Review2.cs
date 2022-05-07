// CODECADEMY C# REVIEW 2 
/* 
    Time for some practice! 
    Use the code editor to play around with what you learned in this lesson. 
    If you’re not sure what to do, try one of the extensions above! 
*/
using System;

namespace Review
{
  class Review2
  {
    static void Main(string[] args)
    {
      /* Use this space to write your own short program! 
      Here's what you learned:
      i
      DATA TYPES: int, double, char, string, bool
      VARIABLES: datatype variableName = value;
      COMMON ERRORS: wrong type, wrong value, no semicolon
      DATA TYPE CONVERSION: implicit, explicit, methods

      Good luck! */

      string name = "Charmander";
      int hp = 60;
      double weight = 18.7;
      bool evolves= true;

      Console.WriteLine(name + " has " + hp + "HP (Health Points)");
      Console.WriteLine("He weighs " + weight + "lbs" );
      Console.WriteLine("QUESTION TIME!\nTrue or False?\nDoes " + name + " evolve?\n" + evolves);

    }
  }
}