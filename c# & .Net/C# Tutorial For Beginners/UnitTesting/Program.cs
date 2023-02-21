/*
 * When using automated testing, the source code will consists of...
 * 
 * Production Code:
 *   - The program, functions, and everything that makes up the software being made
 * 
 * Test Code:
 *   - Allows you to run code and functions with different inputs
 *  
 *  
 * =========================== Types of Tests ====================================
 * 
 * ------------------------------------------------------------------------------------
 * Unit Test: Tests a unit of an application WITHOUT its external dependencies
 *    - Cheap to write
 *    - Execute fast
 *    - Doesn't give a lot of confidence due to its lack of external dependencies
 * 
 * ------------------------------------------------------------------------------------
 * Integration Test: Tests the application WITH its external dependencies
 *    - Takes longer to execute
 *    - More confidence in the application's functionality
 * 
 * ------------------------------------------------------------------------------------
 * End-to-end test: Drives an application through its UI
 *    - Popular tool ( Selenium )
 *    - Gives greatest amount of confidence
 *    - Very Slow
 *    - Very brittle ( Small changes to an application can break the test )
 * 
 * ===============================================================================
 * 
 * 
 * 
 * =========== Test Pyramid ==============
 * 
 * (Numbers are not to perfect scale, just a representation of the concept)
 * 60% Unit Tests 
 * 25% Integration Tests
 * 15% End-To-End Tests
 * 
 * 
 * Unit test are good for logic, conditional statements, and loops with algorithms and mathmatics
 * 
 * Integration tests are good for when working with databases and reading/writing data. 
 *  
 *  
 *  
 *  
 *  ===================== TESTING FRAMEWORKS ===========================
 *  
 *  NUnit:
 *  
 *  MSTest: Built in Microsoft tester for Visual Studio
 *  
 *  xUnit:
 *  
 *  ReSharper: .NET specific extention (Costs Money)
 *  
 *  All of these frameworks give you a utility library to write your tests and a test runner to run your tests
 *  
 *  
 */



namespace UnitTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}