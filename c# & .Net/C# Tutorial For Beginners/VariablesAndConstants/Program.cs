/*
 * ========== Naming Conventions ==============
 * 
 * Camel Case: firstName
 * 
 * Pascal Case: FirstName
 * 
 * Hungarian Notation: strFirstName
 * 
 *  - Variables should use camel case
 *  - Constants should use pascal case
 *      - Personally, I prefer FIRST_NAME for constants.
 *
 */


namespace VariablesAndConstants
{
    internal class Program
    {

        private static void Main(string[] args) {


            float numberFloat = 1.2f; // Floats need f behind them
            double numberDouble = 1.2; // Doubles require nothing for they are the standard
            decimal numberDecimal = 1.2m; // Decimal requires a M at the end

            byte numberByte = 255; // Has a range of 0-255

            char character = 'A'; // Characters are surrounded by single-quotes
            string firstName = "Josh"; // Strings are surrounded by double-quotes


            Console.WriteLine(numberByte);
            Console.WriteLine(numberFloat);
            Console.WriteLine(numberDouble);
            Console.WriteLine(numberDecimal);
            Console.WriteLine(character);
            Console.WriteLine(firstName);

            // C# also allows for type inferring with the "var" keyword.

            var valueFloat = 10.5f; // Fpr floats and decimals, you still need the f and m
            var valueString = "I am not a fan of the var keyword.";

            Console.WriteLine(valueFloat);
            Console.WriteLine(valueString);


            // C#'s Format String
            Console.WriteLine("{0} {1}", Byte.MinValue, Byte.MaxValue); // put an index in curly brackets. I like this method over Javas %s %d stuff.

            const double varDouble = 9.2; // Const, or Constant, does not allow the value to be modified. However it requires explicit type declaration


            // Type Conversions

            // Implicit
            int i = 7;
            float f = i;

            // Explicit
            double d = 8.2;
            byte b = (byte) d;



        }
    }
}