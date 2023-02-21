/*
 * C# is a programming language that compiles into IL Code (Intermediate Language) similar to Java's bytecode.
 * 
 * ============================================
 * 
 * .NET is a framework for building applications on Windows.
 * 
 * .NET has two main components...
 *  - CLR (Common Language Runtime)
 *  - Class Library
 * 
 * ============================================
 * 
 * What is CLR?
 *  - CLR converts the IL code into native code the machine can run. 
 *  - This process is refered to as Just0in0time Compilation (JIT)
 *
 * ============================================
 * 
 * .NET Application Architecture
 * 
 *  - High-level view consists of classes
 *      - Classes are containers that hold data and methods
 *      
 *  - Namespaces are a container for related classes
 *  
 *  - Assemblys are containers to hold namespaces
 *      - They take the form of EXEs or DLLs
 *      - (executables) or (Dynamically Linked Libraries)
 *      
 *  - Then the application is what holds and executes these assemblies.
 *  
 *  
 */


namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello WOrld!");
        }
    }
}