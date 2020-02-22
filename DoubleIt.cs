using System;

class DoubleIt
{
  static void Main()
  {
    Console.WriteLine("Give me a number and I will double it for you!");
    string stringNumber = Console.ReadLine(); // <!-- is gathering the user's input in the correct data type, which is string
    int yourNumber = int.Parse(stringNumber); // <!-- defines the yourNumber variable as the result of transforming stringNumber from a string into an int and uses the built-in int.Parse() method.
    int yourDoubledNumber = yourNumber * 2; 
    string stringDoubledNumber = yourDoubledNumber.ToString(); // <!-- takes the result of multiplying our int by two and turns it back into a string using the toString() method.
    Console.WriteLine("I doubled your number for you: " + yourDoubledNumber);
  }
}