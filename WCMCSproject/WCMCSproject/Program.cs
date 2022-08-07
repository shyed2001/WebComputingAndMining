// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Multi
 * Line
 Comments */
// C# is case sensitive 
// https://docs.microsoft.com/en-us/dotnet/csharp/
// This is single line comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLanguageReferenceDoc
{

}

// Note: actual namespace depends on the project name. This/ It is user given namespace.
namespace WCMCSproject

{
    // internal class Program
    /*internal class Program
     * 
     * What is an internal sealed class in C#?
     * 
     * 
     * It is a class that:

internal: Can only be accessed from within the assembly it is defined (or friend assemblies).
sealed: Cannot be inherited.
Marking classes as internal is a way of preventing outside users of an assembly from using them. It's really a form of design encapsulation and IMHO it is good practice to mark types that are not part of the intended public API\object models as internal. In the long term this prevents users of your library from coupling themselves to types which you did not intend them to. This sort of unintended coupling harms your ability to change and evolve the way your libraries are implemented as you cannot change them without breaking your clients. Using internal helps to keep the public and usable surface area of a library down to what is intended.

Marking classes as sealed prevents these classes from being inherited. This is a pretty drastic design intent which is sometimes useful if a class is already so specialized that it is sensible that no other functionality should be added to it via inheritance either directly or via overriding its behaviour.

internal and sealed modify types in quite different ways, but they can be used together.

NB You have some further scoping control of internal as you can define a set of other assemblies as 'friends'. These friend assemblies may access your internal types. This can be useful for defining sets of co-operating assemblies such as production and test assemblies. It is often desirable that a test assembly can see all the types in the assembly it is testing.




     * 
     * 
     * 2

INTERNAL

Internal types or members are accessible only within files in the same assembly.

Example

// Assembly1.cs  
// Compile with: /target:library  
internal class BaseClass   
{  
   public static int intM = 0;  
} 
// Assembly1_a.cs  
// Compile with: /reference:Assembly1.dll  
class TestAccess   
{  
   static void Main()   
   {  
      var myBase = new BaseClass();   // compile error 
   }  
} 
SEALED

First of all, let's start with a definition; sealed is a modifier which if applied to a class make it non-inheritable and if applied to virtual methods or properties makes them non-ovveridable.

public sealed class A { ... }
public class B 
{
    ...
    public sealed string Property { get; set; }
    public sealed void Method() { ... }
}
An example of its usage is specialized class/method or property in which potential alterations can make them stop working as expected (for example, the Pens class of the System.Drawing namespace).

...
namespace System.Drawing
{
    //
    // Summary:
    //     Pens for all the standard colors. This class cannot be inherited.
    public sealed class Pens
    {
        public static Pen Transparent { get; }
        public static Pen Orchid { get; }
        public static Pen OrangeRed { get; }
        ...
    }
}
Because a sealed class cannot be inherited, it cannot be used as base class and by consequence, an abstract class cannot use the sealed modifier. It's also important to mention that structs are implicitly sealed.

Example

public class BaseClass {
    public virtual string ShowMessage()
    {
        return "Hello world";
    }
    public virtual int MathematicalOperation(int x, int y)
    {
        return x + y;
    }
}
public class DerivedClass : BaseClass {
    public override int MathematicalOperation(int x, int y) 
    {
        // since BaseClass has a method marked as virtual, DerivedClass can override it's behavior
        return x - y;
    }
    public override sealed string ShowMessage()
    {
        // since BaseClass has a method marked as virtual, DerivedClass can override it's behavior but because it's sealed prevent classes that derive from it to override the method
        return "Hello world sealed";
    }
}
public class DerivedDerivedClass : DerivedClass
{
    public override int MathematicalOperation(int x, int y)
    {
        // since BaseClass has a method marked as virtual, DerivedClass can override it's behavior
        return x * y;
    }
    public override  string ShowMessage() { ... } // compile error
}
public sealed class SealedClass: BaseClass {
    public override int MathematicalOperation(int x, int y)
    {
        // since BaseClass has a method marked as virtual, DerivedClass can override it's behavior
        return x * y;
    }
    public override string ShowMessage()
    {
        // since BaseClass has a method marked as virtual, DerivedClass can override it's behavior but because it's sealed prevent classes that derive from it to override the method
        return "Hello world";
    }
}
public class DerivedSealedClass : SealedClass
{
    // compile error
}
Microsoft documentation

Sealed: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
Internal: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal
     * 
     * https://stackoverflow.com/questions/165719/practical-uses-for-the-internal-keyword-in-c-sharp
     * 
     * 
     * An Internal class is a class which cannot be used outside its Assembly. The internal keyword is used to mark a particular class Internal i.e. it restrict its access outside the Assembly.

•      An Assembly could be a Project, a DLL or an EXE.

•      Inside the Assembly, the internal class is like public class.

•      An internal class can be inherited within the Assembly.

Example:

internal class A

{

    public void Fun()

    {

    }

}

//Valid

public class B : A

{

    public static void Fun()

    {

    }

}

public class C

{

    public static void Fun()

    {

        //Valid

        A a = new A();

        a.Fun();

    }

}
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

    // user given class declearation. This contains data and collection of methods


    class Program
    {
        int myVariable;

        static int mystaticVariable;

        // User defined function without return type and parameter
        public void Display()
        {
            Console.WriteLine("Non Parameterized Function - Using Without Parameters and Without Return Type"); // No return statement
        }

        public void Display(string value) // User defined function without return type
        {
            Console.WriteLine("Hello " + value); // No return statement
        }

        // User defined function
        public string Show(string message)
        {
            Console.WriteLine("Inside the Show Function Call");
            return message;
        }

        public void calculate()
        {
            int a = 50, b = 80, sum;
            sum = a + b;
            Console.WriteLine(" Using Without Parameters (Arguments) and with Return Value -Calculating the given to values: " + sum);
        }

        public string GetUserDetails(string name, int age)
        {
            string multilineProblem = @" Task3: Use the console to take input to a C# program and display contents to the console.
Problem2:
Read a three digit integer input from the console, and print the reverse of that number in the
console.
• You can call a reverse() method from Main() and pass the integer values.
• Reverse() method will return the reverse value to Main().
• Main() will catch and print the value.";

            Console.WriteLine(multilineProblem);

            Console.WriteLine( "," + ',' ); /// " , " or ' , ' will work
            Console.Write(string.Format("Name: {0}, Age: {1}", name, age));
            Console.Write(string.Format("Name: {0}, Age: {1}", name, age + "\n" ));
            Console.WriteLine(string.Format("Name: {0}, Age: {1}", name, age));
            Console.WriteLine(string.Format("Name:" + name, "Age:" + age));
            string info = string.Format("Name: {0}, Age: {1}", name, age);
            return info;
        }

        public static void GetUserDetailsstatic()
        {
            string Name = "Suresh Dasari static";
            int Age = 31 ;
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }

        static void Main(string[] args)
            // Progran class have only one main method. This is the entry point of C#.
        {
            Console.WriteLine("Hello World!");

            Program ObjectGetUserDetails = new Program();
            string result = ObjectGetUserDetails.GetUserDetails("Suresh Dasari", 31);
            Console.WriteLine(result);



            GetUserDetailsstatic();







            Program p = new Program();

            p.myVariable = 20;

            Console.WriteLine(p.myVariable);

            // mystaticVariable = p.myVariable;
            // mystaticVariable = 30;
            Console.Write("Hello World! ");
            Console.WriteLine(" Hi!");
            Console.Write("Hello Friend!");
            Console.WriteLine("What is your name?!"); // method in console class
            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");


            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);


            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());



            Program program22 = new Program(); // to create a new Object
            program22.Display(); // Call the Function



            Program program2 = new Program(); // Creating Objec
            program2.Display("Welcome to C# Functions -  Using With Parameters (Arguments) and Without Return Type"); // Calling Function


            Program program = new Program();
            string message = program.Show("C# Functions");
            Console.WriteLine("Hello - Using With Parameters (Arguments) and with Return Type " + message);

            Program addition = new Program();
            addition.calculate();

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");

            ///<summary> 
            /// Code comment -  
            ///             Code comment
            ///           *
            ///            * This code displays a prompt in the console window and waits until the user enters a string followed by the Enter key. It stores this string in a variable named name. It also retrieves the value of the DateTime.Now property, which contains the current local time, and assigns it to a variable named currentDate. And it displays these values in the console window. Finally, it displays a prompt in the console window and calls the Console.ReadKey(Boolean) method to wait for user input.
            ///Environment.NewLine is a platform-independent and language-independent way to represent a line break. Alternatives are \n in C# and vbCrLf in Visual Basic.
            ///The dollar sign ($) in front of a string lets you put expressions such as variable names in curly braces in the string. The expression value is inserted into the string in place of the expression. This syntax is referred to as interpolated strings.
            ///Press Ctrl+F5 to run the program without debugging.
            ///Respond to the prompt by entering a name and pressing the Enter key.
            ///{currentDate:d} is for current date nad {currentDate:t} is for currentn time;
            ///</summary>

            Console.ReadKey(true);  // wait for a key press
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/
        /// </summary>

        public class CsharpComments
        {
            /*// https://docs.microsoft.com/en-us/dotnet/csharp/
             * 
             * 
             * // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Multi
 * Line
 Comments */
            // C# is case sensitive 
            // This is single line comment
            /* Documenting C# functions with XML comments
             * 
             * 
             * 
             * 
             * Documenting C# functions with XML comments
The following example defines the CalculateBMI() function that calculates the body mass index based on the weight in kilograms and height in meters:

double CalculateBMI(double weight, double height)
{
    return weight / (height * height);
}
Code language: C# (cs)
When calling the CalculateBMI() function, the Visual Studio (or any code editor) shows the function header:

However, if you want it to show more information about the function, you can add comments to the function. like this:

/// <summary>
/// Calculate the body mass index (BMI) based on weight in kg and height in meter
/// </summary>
/// <param name="weight">
/// The weight in kilogram
/// </param>
/// <param name="height">
/// The height in meter
/// </param>
/// <returns>
/// The body mass index
/// </returns>
double CalculateBMI(double weight, double height)
{
    return weight / (height * height);
}
Code language: C# (cs)
To create a comment section for a function, you enter three forward slashes (///) right before the function header.

The comment of the CalculateBMI function has three main tags: summary, param, and returns.

The summary tag contains the function description
The param tag describes the parameters
The returns tag contains the information of the return value
             * 
             * 
             */
        }


        public class CsharpVariables
        {
            /*

 // Create a variable called myNum of type int and assign it the value 15:

 int myNum = 15;
 Console.WriteLine(myNum);

 // You can also declare a variable without assigning the value, and assign the value later: example

 int myNum1;
 myNum1 = 15;
 Console.WriteLine(myNum1);

 //Note that if you assign a new value to an existing variable, it will overwrite the previous value:
 //Example
 //Change the value of myNum to 20:

 int myNum2 = 15;
 myNum2 = 20; // myNum is now 20
 Console.WriteLine(myNum2);
    Constants
     However, you can add the const keyword if you don't want others (or yourself) to overwrite existing values (this will declare the variable as "constant", which means unchangeable and read-only):

     Example 
     const int myNum = 15;
     myNum = 20; // error
             The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code. An example that is often referred to as a constant, is PI (3.14159...).

Note: You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.

   Other Types
A demonstration of how to declare variables of other types:

Example
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";


Display Variables
The WriteLine() method is often used to display variable values to the console window.

To combine both text and a variable, use the + character:

Example
 string name44 = "John";
 Console.WriteLine("Hello " + name44);



 For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):

Example
int x = 5;
int y = 6;
Console.WriteLine(x + y); // Print the value of x + y




             You can also use the + character to add a variable to another variable:

 Example
string firstName = "John ";
 string lastName = "Doe";
 string fullName = firstName + lastName;
 Console.WriteLine(fullName);

             Declare Many Variables
To declare more than one variable of the same type, use a comma-separated list:

Example
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

 You can also assign the same value to multiple variables in one line:

Example
int x, y, z;
x = y = z = 50;
Console.WriteLine(x + y + z);



  */



        }

        public class CsharpDataTypes
        {
            /*
  * 
  * 
  * 
  *             C# Data Types
As explained in the variables chapter, a variable in C# must be a specified data type:

Example
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String
 A data type specifies the size and type of variable values. 
 It is important to use the correct data type for the corresponding variable;
 to avoid errors, to save time and memory, but it will also make your code
 more maintainable and readable. The most common data types are:

Data Type	Size	Description
int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	1 bit	Stores true or false values
char	2 bytes	Stores a single character/letter, surrounded by single quotes
string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes


 Numbers
Number types are divided into two groups:

Integer types stores whole numbers, positive or negative (such as 123 or -456), without decimals. Valid types are int and long. Which type you should use, depends on the numeric value.

Floating point types represents numbers with a fractional part, containing one or more decimals. Valid types are float and double.

Even though there are many numeric types in C#, the most used for numbers are int (for whole numbers) and double (for floating point numbers). However, we will describe them all as you continue to read.


  Integer Types
Int
The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.

Example
int myNum = 100000;
Console.WriteLine(myNum);

Long
The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807. 
 This is used when int is not large enough to store the value. Note that you should end the value with an "L":

Example
long myNum = 15000000000L;
Console.WriteLine(myNum);

Floating Point Types
You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.

The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles:

Float Example
float myNum = 5.75F;
Console.WriteLine(myNum);

Double Example
double myNum = 19.99D;
Console.WriteLine(myNum);


Use float or double?

The precision of a floating point value indicates how many digits the value can have after the decimal point. The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits. Therefore it is safer to use double for most calculations.

Scientific Numbers
A floating point number can also be a scientific number with an "e" to indicate the power of 10:

Example
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);




             Booleans
A boolean data type is declared with the bool keyword and can only take the values true or false:

Example
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False
Boolean values are mostly used for conditional testing, which you will learn more about in a later chapter.

Characters
The char data type is used to store a single character. The character must be surrounded by single quotes, like 'A' or 'c':

Example
char myGrade = 'B';
Console.WriteLine(myGrade);



 Strings
The string data type is used to store a sequence of characters (text). String values must be surrounded by double quotes:

Example
string greeting = "Hello World";
Console.WriteLine(greeting);
  */

        }

        public class CsharpImplicitDataType_var
        {
            /*
 * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var
var (C# reference)

Beginning with C# 3, variables that are declared at method scope can have an implicit "type" var.
An implicitly typed local variable is strongly typed just as if you had declared the type yourself, but the compiler determines the type. The following two declarations of i are functionally equivalent:

C#

Copy
var i = 10; // Implicitly typed.
int i = 10; // Explicitly typed.


*/


            /*
            https://stackoverflow.com/questions/4307467/what-does-var-mean-in-c

            It means that the type of the local being declared will be inferred by the compiler based upon its first assignment:

    // This statement:
    var foo = "bar";
    // Is equivalent to this statement:
    string foo = "bar";
    Notably, var does not define a variable to be of a dynamic type. So this is NOT legal:

    var foo = "bar";
    foo = 1; // Compiler error, the foo variable holds strings, not ints
    var has only two uses:

    It requires less typing to declare variables, especially when declaring a variable as a nested generic type.
    It must be used when storing a reference to an object of an anonymous type, because the type name cannot be known in advance: var foo = new { Bar = "bar" };
    You cannot use var as the type of anything but locals. So you cannot use the keyword var to declare field/property/parameter/return types.

    It declares a type based on what is assigned to it in the initialisation.

    A simple example is that the code:

    var i = 53;
    Will examine the type of 53, and essentially rewrite this as:

    int i = 53;
    Note that while we can have:

    long i = 53;
    This won't happen with var. Though it can with:

    var i = 53l; // i is now a long

            As the name suggested, var is variable without any data type.
    If you don't know which type of data will be returned by any method, such cases are good for using var.
    var is Implicit type which means system will define the data type itself. The compiler will infer its type based on the value to the right of the "=" operator.
    int/string etc. are the explicit types as it is defined by you explicitly.
    Var can only be defined in a method as a local variable
    Multiple vars cannot be declared and initialized in a single statement. For example, var i=1, j=2; is invalid.
    int i = 100;// explicitly typed 
    var j = 100; // implicitly typed


    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables#remarks
    var and anonymous types
    In many cases the use of var is optional and is just a syntactic convenience. However, when a variable is initialized with an anonymous type you must declare the variable as var if you need to access the properties of the object at a later point. This is a common scenario in LINQ query expressions. For more information, see Anonymous Types.

    From the perspective of your source code, an anonymous type has no name. Therefore, if a query variable has been initialized with var, then the only way to access the properties in the returned sequence of objects is to use var as the type of the iteration variable in the foreach statement.

    C#

    Copy
    class ImplicitlyTypedLocals2
    {
    static void Main()
    {
        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        // If a query produces a sequence of anonymous types,
        // then use var in the foreach statement to access the properties.
        var upperLowerWords =
             from w in words
             select new { Upper = w.ToUpper(), Lower = w.ToLower() };

        // Execute the query
        foreach (var ul in upperLowerWords)
        {
            Console.WriteLine("Uppercase: {0}, Lowercase: {1}", ul.Upper, ul.Lower);
        }
    }
    }
    Outputs:
    Uppercase: APPLE, Lowercase: apple
    Uppercase: BLUEBERRY, Lowercase: blueberry
    Uppercase: CHERRY, Lowercase: cherry

            Remarks
            The following restrictions apply to implicitly - typed variable declarations:

    var can only be used when a local variable is declared and initialized in the same statement; the variable cannot be initialized to null, or to a method group or an anonymous function.

    var cannot be used on fields at class scope.

    Variables declared by using var cannot be used in the initialization expression.In other words, this expression is legal: int i = (i = 20); but this expression produces a compile-time error: var i = (i = 20);

    Multiple implicitly-typed variables cannot be initialized in the same statement.

    If a type named var is in scope, then the var keyword will resolve to that type name and will not be treated as part of an implicitly typed local variable declaration.

    Implicit typing with the var keyword can only be applied to variables at local method scope. Implicit typing is not available for class fields as the C# compiler would encounter a logical paradox as it processed the code: the compiler needs to know the type of the field, but it cannot determine the type until the assignment expression is analyzed, and the expression cannot be evaluated without knowing the type. Consider the following code:

    C#

    Copy
    private var bookTitles;
    bookTitles is a class field given the type var.As the field has no expression to evaluate, it is impossible for the compiler to infer what type bookTitles is supposed to be.In addition, adding an expression to the field (like you would for a local variable) is also insufficient:

    C#

    Copy
    private var bookTitles = new List<string>();
    When the compiler encounters fields during code compilation, it records each field's type before processing any expressions associated with it. The compiler encounters the same paradox trying to parse bookTitles: it needs to know the type of the field, but the compiler would normally determine var's type by analyzing the expression, which isn't possible without knowing the type beforehand.

    You may find that var can also be useful with query expressions in which the exact constructed type of the query variable is difficult to determine.This can occur with grouping and ordering operations.

    The var keyword can also be useful when the specific type of the variable is tedious to type on the keyboard, or is obvious, or does not add to the readability of the code. One example where var is helpful in this manner is with nested generic types such as those used with group operations.In the following query, the type of the query variable is IEnumerable<IGrouping<string, Student>>.As long as you and others who must maintain your code understand this, there is no problem with using implicit typing for convenience and brevity.

    C#

    Copy
    // Same as previous example except we use the entire last name as a key.
    // Query variable is an IEnumerable<IGrouping<string, Student>>
    var studentQuery3 =
    from student in students
    group student by student.Last;
    The use of var helps simplify your code, but its use should be restricted to cases where it is required, or when it makes your code easier to read.For more information about when to use var properly, see the Implicitly typed local variables section on the C# Coding Guidelines article.


    */


            /*https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions#implicitly-typed-local-variables
    Implicitly typed local variables
    Use implicit typing for local variables when the type of the variable is obvious from the right side of the assignment, or when the precise type is not important.

    C#

    Copy
    var var1 = "This is clearly a string.";
    var var2 = 27;
    Don't use var when the type is not apparent from the right side of the assignment. Don't assume the type is clear from a method name. A variable type is considered clear if it's a new operator or an explicit cast.

    C#

    Copy
    int var3 = Convert.ToInt32(Console.ReadLine()); 
    int var4 = ExampleClass.ResultSoFar();
    Don't rely on the variable name to specify the type of the variable. It might not be correct. In the following example, the variable name inputInt is misleading. It's a string.

    C#

    Copy
    var inputInt = Console.ReadLine();
    Console.WriteLine(inputInt);
    Avoid the use of var in place of dynamic. Use dynamic when you want run-time type inference. For more information, see Using type dynamic (C# Programming Guide).

    Use implicit typing to determine the type of the loop variable in for loops.

    The following example uses implicit typing in a for statement.

    C#

    Copy
    var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
    var manyPhrases = new StringBuilder();
    for (var i = 0; i < 10000; i++)
    {
    manyPhrases.Append(phrase);
    }
    //Console.WriteLine("tra" + manyPhrases);
    Don't use implicit typing to determine the type of the loop variable in foreach loops. In most cases, the type of elements in the collection isn't immediately obvious. The collection's name shouldn't be solely relied upon for infering the type of its elements.

    The following example uses explicit typing in a foreach statement.

    C#

    Copy
    foreach (char ch in laugh)
    {
    if (ch == 'h')
        Console.Write("H");
    else
        Console.Write(ch);
    }
    Console.WriteLine();
    Note

    Be careful not to accidentally change a type of an element of the iterable collection. For example, it is easy to switch from System.Linq.IQueryable to System.Collections.IEnumerable in a foreach statement, which changes the execution of a query.

    Unsigned data types
    In general, use int rather than unsigned types. The use of int is common throughout C#, and it is easier to interact with other libraries when you use int.

    Arrays
    Use the concise syntax when you initialize arrays on the declaration line. In the following example, note that you can't use var instead of string[].

    C#

    Copy
    string[] vowels1 = { "a", "e", "i", "o", "u" };
    If you use explicit instantiation, you can use var.

    C#

    Copy
    var vowels2 = new string[] { "a", "e", "i", "o", "u" };
    If you specify an array size, you have to initialize the elements one at a time.

    C#

    Copy
    var vowels3 = new string[5];
    vowels3[0] = "a";
    vowels3[1] = "e";
    // And so on.

    */
        }

        public class CsharpKeywords10types
        {
            /**** https://www.geeksforgeeks.org/c-sharp-keywords/
             * C# | Keywords

  Difficulty Level : Basic
  Last Updated : 21 Jan, 2019
  Keywords or Reserved words are the words in a language that are used for some internal process or represent some predefined actions. These words are therefore not allowed to use as variable names or objects. Doing this will result in a compile-time error.

  Example:


  // C# Program to illustrate the keywords
  using System;

  class GFG {

      // Here static, public, void 
      // are keywords    
      static public void Main () {

          // here int is keyword
          // a is identifier
          int a = 10;

          Console.WriteLine("The value of a is: {0}",a);

          // this is not a valid identifier

          // removing comment will give compile time error
          // double int = 10;

      }
  }
  Output:

  The value of a is: 10
  There are total 78 keywords in C# as follows:

  abstract
  as
  base
  bool
  break
  byte
  case
  catch
  char
  checked
  class
  const
  continue
  decimal
  default
  delegate
  do
  double
  else
  enum
  event
  explicit
  extern
  false
  finally
  fixed
  float
  for
  foreach
  goto
  if
  implicit
  in
  int
  interface
  internal
  is
  lock
  long
  namespace
  new
  null
  object
  operator
  out
  override
  params
  private
  protected
  public
  readonly
  ref
  return
  sbyte
  sealed
  short
  sizeof
  stackalloc
  static
  string
  struct
  switch
  this
  throw
  true
  try
  typeof
  unit
  ulong
  unchecked
  unsafe
  ushort
  using
  using static
  virtual
  void
  volatile
  while



  Keywords in C# is mainly divided into 10 categories as follows:

  Value Type Keywords: There are 15 keywords in value types which are used to define various data types.
  bool	byte	char	decimal
  double	enum	float	int
  long	sbyte	short	struct
  unit	ulong	ushort	
  Example:


  // C# Program to illustrate the
  // value type keywords
  using System;

  class GFG {

      // Here static, public, void 
      // are keywords    
      static public void Main () {

          // here byte is keyword
          // a is identifier
          byte a = 47;
          Console.WriteLine("The value of a is: {0}",a);


          // here bool is keyword
          // b is identifier
          // true is a keyword
          bool b = true;

          Console.WriteLine("The value of b is: {0}",b);



      }
  }
  Output:

  The value of a is: 47
  The value of b is: True
  Reference Type Keywords: There are 6 keywords in reference types which are used to store references of the data or objects. The keywords in this category are: class, delegate, interface, object, string, void.


  Modifiers Keywords: There are 17 keywords in modifiers which are used to modify the declarations of type member.
  public	private	internal	protected	abstract
  const	event	extern	new	override
  partial	readonly	sealed	static	unsafe
  virtual	volatile			
  Example:


  // C# Program to illustrate the
  // modifiers keywords
  using System;

  class Geeks {

      class Mod
      {

          // using public modifier
          // keyword
          public int n1;

      }

      // Main Method
      static void Main(string[] args) {

          Mod obj1 = new Mod();

          // access to public members
          obj1.n1 = 77;

          Console.WriteLine("Value of n1: {0}", obj1.n1);

      }

  }
  Output:

  Value of n1: 77
  Statements Keywords: There are total 18 keywords which are used in program instructions.
  if	else	switch	do	for
  foreach	in	while	break	continue
  goto	return	throw	try	catch
  finally	checked	unchecked		
  Example:


  // C# program to illustrate the statement keywords
  using System; 

  class demoContinue 
  { 
      public static void Main() 
      {     

          // using for as statement keyword
          // GeeksforGeeks is printed only 2 times 
          // because of continue statement 
          for(int i = 1; i < 3; i++) 
          { 

              // here if and continue are keywords
              if(i == 2) 
              continue; 

              Console.WriteLine("GeeksforGeeks"); 
          } 
      } 
  } 
  Output:

  GeeksforGeeks
  Method Parameters Keywords: There are total 4 keywords which are used to change the behavior of the parameters that passed to a method. The keyword includes in this category are: params, in, ref, out.


  Namespace Keywords: There are total 3 keywords in this category which are used in namespaces. The keywords are: namespace, using, extern.


  Operator Keywords: There are total 8 keywords which are used for different purposes like creating objects, getting a size of object etc. The keywords are: as, is, new, sizeof, typeof, true, false, stackalloc.


  Conversion Keywords: There are 3 keywords which are used in type conversions. The keywords are: explicit, implicit, operator.


  Access Keywords: There are 2 keywords which are used in accessing and referencing the class or instance of the class. The keywords are base, this.


  Literal Keywords: There are 2 keywords which are used as literal or constant. The keywords are null, default.
  Important Points:

  Keywords are not used as an identifier or name of a class, variable, etc.
  If you want to use a keyword as an identifier then you must use @ as a prefix. For example, @abstract is valid identifier but not abstract because it is a keyword.
  Example:

  int a = 10;              // Here int is a valid keyword

  double int = 10.67;     // invalid because int is a keyword

  double @int = 10.67;   // valid identifier, prefixed with @

  int @null = 0;       // valid

  // C# Program to illustrate the use of 
  // prefixing @ in keywords
  using System;

  class GFG {

      // Here static, public, void 
      // are keywords    
      static public void Main () {

          // here int is keyword
          // a is identifier
          int a = 10;

          Console.WriteLine("The value of a is: {0}",a);

          // prefix @ in keyword int which 
          // makes it a valid identifier
          int @int = 11;

          Console.WriteLine("The value of a is: {0}",@int);

      }
  }
  Output:

  The value of a is: 10
  The value of a is: 11
  Contextual Keywords
  These are used to give a specific meaning in the program. Whenever a new keyword comes in C#, it is added to the contextual keywords, not in the keyword category. This helps to avoid the crashing of programs which are written in earlier versions.

  Important Points:

  These are not reserved words.
  It can be used as identifiers outside the context that’s why it named contextual keywords.
  These can have different meanings in two or more contexts.
  There are total 30 contextual keywords in C#.
  add
  alias
  ascending
  async
  await
  by
  descending
  dynamic
  equals
  from
  get
  global
  group
  into
  join
  let
  nameof
  on
  orderby
  partial(type)
  partial(method)
  remove
  select
  set
  value
  var
  when
  where
  where
  yield





  Example:


  // C# program to illustrate contextual keywords
  using System; 

  public class Student { 

      // Declare name field 
      private string name = "GeeksforGeeks"; 

      // Declare name property 
      public string Name 
      { 

      // get is contextual keyword
      get
          { 
              return name; 
          } 

          // set is a contextual
          // keyword
          set
          { 
              name = value; 
          } 
      } 
  } 

  class TestStudent { 

      // Main Method 
      public static void Main(string[] args) 
      { 
          Student s = new Student(); 

          // calls set accessor of the property Name, 
          // and pass "GFG" as value of the 
          // standard field 'value'. 
          s.Name = "GFG"; 

          // displays GFG, Calls the get accessor 
          // of the property Name. 
          Console.WriteLine("Name: " + s.Name); 

          // using get and set as identifier
          int get = 50;
          int set = 70;

          Console.WriteLine("Value of get is: {0}",get);
          Console.WriteLine("Value of set is: {0}",set);
      } 
  } 
  Output:

  Name: GFG
  Value of get is: 50
  Value of set is: 70
  Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */
        }

        public class CsharpKeywords
        {

            /*
             *            // https://www.educba.com/c-sharp-keywords/

            // https://www.tutorialsteacher.com/csharp/csharp-keywords
            Introduction
C# is rich in features and keywords which helps to make the language strong and versatile. Keywords are predefined sets of reserved words that have a special meaning that is known to the compiler. These keywords have special significance so that we cannot use them as identifiers for class name, variable name, and interface name. In this blog, you will learn about C# keywords.

C# Keywords List
List of Reserved Keywords is given below table which is available in C# Programming language,

using	as	finally	sbyte
int	is	fixed	sealed
char	abstract	foreach	sizeof
float	base	goto	typeof
double	case	return	stackalloc
short	try	implicity	struct
long	catch	in	switch
string	checked	internal	throw
true	class	interface	throw
false	const	lock	ulong
static	decimal	namespace	unchecked
this	enum	new	unsafe
byte	default	null	ushort
bool	private	object	virtual
break	protected	operator	void
continue 	public	out	volatile
if	delegate	override	extern
else	do	params	using static
while	event	readonly	 
for	explict	ref	 

C# Keywords Categorized with their types or groups

Namespace Keywords	using, operator, extern alias
Type Keywords	string, int, long, bool, byte, char, class, decimal, double, enum, float, sbyte, short, struct, uint, ulong, ushort
Operator Keywords	is, await, as, new, sizeof, typeof, checked, unchecked, stackalloc
Statement Keywords	if, else, switch, case, do, for, foreach, in, while, break, continue, default, goto, return, yield, throw, try, catch, finally, checked, unchecked, fixed, lock
Literal Keywords	null, false, true, value, void
Modifier Keywords	public, private, protected, internal, abstract, async, const, event, extern, new, override, partial, readonly, sealed, static, unsafe, virtual, volatile
Method Parameter Keyword	params, ref, out
Access Keywords	base, this
Contextual Keywords	add, var, dynamic, global, set, value
Query Keywords	from, where, select, group, into, orderby, join, let, in, on, equals, by, ascending, descending

Summary
We cannot use C# standard keywords as identifiers for class names, variable names, and interface names.

If you have any query/suggestion on C# keywords, please leave your thoughts in the comment section below.

Thanks for reading and I hope you like it.


            */



        }

        public class CsharpIdentifiers
        {


            /*  
             *  // https://www.programiz.com/csharp-programming/keywords-identifiers
             * C# Identifiers

Identifiers are the name given to entities such as variables, methods, classes, etc. They are tokens in a program which uniquely identify an element. For example,

int value;
Here, value is the name of variable. Hence it is an identifier. Reserved keywords can not be used as identifiers unless @ is added as prefix. For example,

int break;
This statement will generate an error in compile time.

To learn more about variables, visit C# Variables.

Rules for Naming an Identifier
An identifier can not be a C# keyword.
An identifier must begin with a letter, an underscore or @ symbol. The remaining part of identifier can contain letters, digits and underscore symbol.
Whitespaces are not allowed. Neither it can have symbols other than letter, digits and underscore.
Identifiers are case-sensitive. So, getName, GetName and getname represents 3 different identifiers.
Here are some of the valid and invalid identifiers:

Identifiers	Remarks
number	Valid
calculateMarks	Valid
hello$	Invalid (Contains $)
name1	Valid
@if	Valid (Keyword with prefix @)
if	Invalid (C# Keyword)
My name	Invalid (Contains whitespace)
_hello_hi	Valid
Example: Find list of keywords and identifiers in a program
Just to clear the concept, let's find the list of keywords and identifiers in the program we wrote in C# Hello World.

using System;
namespace HelloWorld
{
class Hello
{         
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
}
}


Keywords	Identifiers
using	System
namespace	HelloWorld (namespace)
class	Hello (class)
static	Main (method)
void	args
string	Console
WriteLine
The "Hello World!" inside WriteLine method is a string literal.
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             *             C# Identifiers
All C# variables must be identified with unique names.

These unique names are called identifiers.

Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).

Note: It is recommended to use descriptive names in order to create understandable and maintainable code:

Example
// Good
int minutesPerHour = 60;

// OK, but not so easy to understand what m actually is
int m = 60;


The general rules for naming variables are:

Names can contain letters, digits and the underscore character (_)
Names must begin with a letter
Names should start with a lowercase letter and it cannot contain whitespace
Names are case sensitive ("myVar" and "myvar" are different variables)
Reserved words (like C# keywords, such as int or double) cannot be used as names
             */


        }

        public class CsharpContextualKeywords
        {
            /*
             * Contextual keywords
A contextual keyword is used to provide a specific meaning in the code, but it is not a reserved word in C#. Some contextual keywords, such as partial and where, have special meanings in two or more contexts.

add
and
alias
ascending
args
async
await
by
descending
dynamic
equals
from

get
global
group
init
into
join
let
managed (function pointer calling convention)
nameof
nint
not

notnull
nuint
on
or
orderby
partial (type)
partial (method)
record
remove
select

set
unmanaged (function pointer calling convention)
unmanaged (generic type constraint)
value
var
when (filter condition)
where (generic type constraint)
where (query clause)
with
yield
             * 
             * 
             * 
             * 
             */

            /*
             * Different Types of Keywords
In c#, Keywords are differentiated into two types those are



Reserve Keywords
Contextual Keywords
Reserved keywords
The following table lists the available reserved keywords in the c# programming language.



abstract	bool	continue	decimal	default
event	explicit	extern	char	checked
class	const	break	as	base
delegate	is	lock	long	num
byte	case	catch	false	finally
fixed	float	for	as	foreach
goto	if	implicit	in	int
interface	internal	do	double	else
namespace	new	null	object	operator
out	override	params	private	protected
public	readonly	sealed	short	sizeof
ref	return	sbyte	stackalloc	static
string	struct	void	volatile	while
true	try	switch	this	throw
unchecked	unsafe	ushort	using	using static
virtual	typeof	uint	ulong	out (generic modifier)
Contextual keywords
In c#, Contextual keywords can be used as an identifier in a limited program context, which can be outside of the context.



Generally, whenever the new keywords are added to the C# language, those are treated as Contextual keywords to avoid breaking c# programs that we wrote in older versions.



The following table lists the available Contextual Keywords in the c# programming language.



add	alias	async	await	dynamic
from	get	orderby	ascending	descending
group	into	join	let	nameof
global	partial	set	remove	select
value	var	when	Where	yield
These are the keywords available in the c# programming language, and we can use them in our applications based on our requirements. 
             * 
             * 
             * 
             * 
             * 
             */

        }

        public class CsharpTypeCasting
        {
            /*
             * 
             * C# Type Casting
Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
Implicit Casting
Implicit casting is done automatically when passing a smaller size type to a larger size type:

Example
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9
             * 
             * 
             * Explicit Casting
Explicit casting must be done manually by placing the type in parentheses in front of the value:

Example
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
             * 
             * 
             * 
             * Type Conversion Methods
It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

Example
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
             * 
             * 
             * 
             * Why Conversion?
Many times, there's no need for type conversion.
            But sometimes you have to. Take a look at the next chapter, when working with user input, to see an example of this.
             * 
             * 
             */
        }

        public class CsharpNamespaces
        {
            /// https://www.bing.com/search?q=how+to+create+and+use+new+multiple+namespaces+in+C%23&form=ANNTH1&refig=677dbf0e1039404fa1e07ee95575ba0a
            /*           EXPLORE FURTHER
           C# Namespaces with Examples - Tutlane
           tutlane.com

           C# Namespaces [With Examples] - Programiz
           programiz.com

           C# | Namespaces - GeeksforGeeks
           geeksforgeeks.org

           C# namespace alias - what's the point? - Stack Overflow
           stackoverflow.com

           Guide to Namespaces in C# with Examples - EDUCBA
           educba.com



            */

        }

        public class CsharpUserInput
        {
            /*
             * 
             * Get User Input
You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.

In the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName:

Example
// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);


             * 
             * 
             * User Input and Numbers
The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int. The following program will cause an error:

Example
Console.WriteLine("Enter your age:");
int age = Console.ReadLine();
Console.WriteLine("Your age is: " + age);
The error message will be something like this:

Cannot implicitly convert type 'string' to 'int'

Like the error message says, you cannot implicitly convert type 'string' to 'int'.

Luckily, for you, you just learned from the previous chapter (Type Casting), that you can convert any type explicitly, by using one of the Convert.To methods:

Example
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

Note: If you enter wrong input (e.g. text in a numerical input), you will get an exception/error message (like System.FormatException: 'Input string was not in a correct format.').
             * 
             * 
             */
        }

        public class CsharpOperators
        {
            /*
             * 
             * C# Operators
Operators are used to perform operations on variables and values.

In the example below, we use the + operator to add together two values:

Example
int x = 100 + 50;

Although the + operator is often used to add together two values, like in the example above, it can also be used to add together a variable and a value, or a variable and another variable:

Example
int sum1 = 100 + 50;        // 150 (100 + 50)
int sum2 = sum1 + 250;      // 400 (150 + 250)
int sum3 = sum2 + sum2;     // 800 (400 + 400)

Arithmetic Operators
Arithmetic operators are used to perform common mathematical operations:

Operator	Name	Description	Example	Try it
+	Addition	Adds together two values	x + y	
-	Subtraction	Subtracts one value from another	x - y	
*	Multiplication	Multiplies two values	x * y	
/	Division	Divides one value by another	x / y	
%	Modulus	Returns the division remainder	x % y	
++	Increment	Increases the value of a variable by 1	x++	
--	Decrement	Decreases the value of a variable by 1	x--	
C# Assignment Operators
Assignment operators are used to assign values to variables.

In the example below, we use the assignment operator (=) to assign the value 10 to a variable called x:

Example
int x = 10;

The addition assignment operator (+=) adds a value to a variable:

Example
int x = 10;
x += 5;

A list of all assignment operators:

Operator	Example	Same As	Try it
=	x = 5	x = 5	
+=	x += 3	x = x + 3	
-=	x -= 3	x = x - 3	
*=	x *= 3	x = x * 3	
/=	x /= 3	x = x / 3	
%=	x %= 3	x = x % 3	
&=	x &= 3	x = x & 3	
|=	x |= 3	x = x | 3	
^=	x ^= 3	x = x ^ 3	
>>=	x >>= 3	x = x >> 3	
<<=	x <<= 3	x = x << 3	


C# Comparison Operators
Comparison operators are used to compare two values:

Operator	Name	Example	Try it
==	Equal to	x == y	
!=	Not equal	x != y	
>	Greater than	x > y	
<	Less than	x < y	
>=	Greater than or equal to	x >= y	
<=	Less than or equal to	x <= y	
C# Logical Operators
Logical operators are used to determine the logic between variables or values:

Operator	Name	Description	Example	Try it
&& 	Logical and	Returns true if both statements are true	x < 5 &&  x < 10	
|| 	Logical or	Returns true if one of the statements is true	x < 5 || x < 4	
!	Logical not	Reverse the result, returns false if the result is true	!(x < 5 && x < 10)	

             * 
             * 
             * 
             * 
             * 
             */
        }

        public class CsharMath
        {
            /*
             * 
             * C# Math
The C# Math class has many methods that allows you to perform mathematical tasks on numbers.

Math.Max(x,y)
The Math.Max(x,y) method can be used to find the highest value of x and y:

Example
Math.Max(5, 10);

Math.Min(x,y)
The Math.Min(x,y) method can be used to find the lowest value of of x and y:

Example
Math.Min(5, 10);

Math.Sqrt(x)
The Math.Sqrt(x) method returns the square root of x:

Example
Math.Sqrt(64);



Math.Abs(x)
The Math.Abs(x) method returns the absolute (positive) value of x:

Example
Math.Abs(-4.7);

Math.Round()
Math.Round() rounds a number to the nearest whole number:

Example
Math.Round(9.99);


             * 
             * 
             * 
             * 
             * C# System.Math Class - With Easy Programming Examples
In this tutorial, you will learn:
1. What is Math class in C# ?
2. C# Math Functions and Fields
While learning C#, it is necessary to know some useful classes to improve functionality without writing own code for several task. Instead of writing your own code for various kind of mathematical operations in c sharp, you just need to know some predefined static methods and constant fields in System.Math class. By studying this lesson, you will be able to write sophisticated code in c# for various types of math operations by using the robust predefined methods and fields.

WHAT IS MATH CLASS IN C#?
The Math class comes under System namespace, and it is used for trigonometric, logarithmic, and other common mathematical functions. This class makes mathematical operations easy for programmer and they don’t need to write their own code for various kind of mathematical calculations. In the Math class, there are several useful and handy functions are built-in, which can be used easily.

Here, I am only collecting the most useful methods in Math class. For the complete list of functions in Math class, you can visit the docs.microsoft.com.

 C# Math class useful functions:

 Functions:

Abs
Acos
Asin
Atan
Cbrt
Ceiling
Floor
Max
Min
Pow
Round
Sqrt
Truncate

 Fields

E
Pie
Tau




            Math is a pre-defined class in C#.Net, which has many methods to perform mathematical operations without using operators for that.

This post contains some of the common and most popular Math class’s methods which may help you to perform related operations in C# program.

These are following important methods are used in c#:

Math.Pow()
Math.Sqrt()
Math.Max()
Math.Min()
Math.Ceiling()
Math.Floor()
1) Math.Pow()
This method is used to calculate power of given number.

2) Math.Sqrt()
This method is used to calculate square root of given number.

3) Math.Max()
This method is used to find largest number from two given number.

4) Math.Min()
This method is used to find smallest number from two given number.

5) Math.Ceiling()
This method is used to ceil given floating point number.

6) Math.Floor()
This method is used to floor given floating point number.

Consider the program:

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num    = 0;
            double power = 0;
            double result = 0;


            Console.Write("Enter Number : ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Power : ");
            power = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(num, power);
            Console.WriteLine("Result : " + result);

            result = Math.Sqrt(16);
            Console.WriteLine("Result : " + result);

            result = Math.Max(10.2, 10.5);
            Console.WriteLine("Result : " + result);

            result = Math.Min(10.2, 10.5);
            Console.WriteLine("Result : " + result);

            result = Math.Ceiling(10.2);
            Console.WriteLine("Result : " + result);

            result = Math.Floor(10.2);
            Console.WriteLine("Result : " + result);

        }
    }
}
Output

Enter Number : 2
Enter Power : 3
Result : 8
Result : 4
Result : 10.5
Result : 10.2
Result : 11
Result : 10
             * 
             * 
             */
        }

        public class CsharpStringVariable
        {
            /*
             * 
             * C# Strings
Strings are used for storing text.

A string variable contains a collection of characters surrounded by double quotes:

Example
Create a variable of type string and assign it a value:

string greeting = "Hello";

String Length
A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. For example, the length of a string can be found with the Length property:

Example
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

Other Methods
There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:

Example
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

String Concatenation
The + operator can be used between strings to combine them. This is called concatenation:

Example
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);

Note that we have added a space after "John" to create a space between firstName and lastName on print.

You can also use the string.Concat() method to concatenate two strings:

Example
string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);

ADVERTISEMENT

String Interpolation
Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:

Example
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

Also note that you have to use the dollar sign ($) when using the string interpolation method.

String interpolation was introduced in C# version 6.

Access Strings
You can access the characters in a string by referring to its index number inside square brackets [].

This example prints the first character in myString:

Example
string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"

Note: String indexes start with 0: [0] is the first character. [1] is the second character, etc.

This example prints the second character (1) in myString:

Example
string myString = "Hello";
Console.WriteLine(myString[1]);  // Outputs "e"

You can also find the index position of a specific character in a string, by using the IndexOf() method:

Example
string myString = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/index, and returns a new string. This method is often used together with IndexOf() to get the specific character position:

Example
// Full name
string name = "John Doe";

// Location of the letter D
int charPos = name.IndexOf("D");

// Get last name
string lastName = name.Substring(charPos);

// Print the result
Console.WriteLine(lastName);

Special Characters
Because strings must be written within quotes, C# will misunderstand this string, and generate an error:

string txt = "We are the so-called "Vikings" from the north.";
The solution to avoid this problem, is to use the backslash escape character.

The backslash (\) escape character turns special characters into string characters:

Escape character	Result	Description
\'	'	Single quote
\"	"	Double quote
\\	\	Backslash
The sequence \"  inserts a double quote in a string:

Example
string txt = "We are the so-called \"Vikings\" from the north.";

The sequence \'  inserts a single quote in a string:

Example
string txt = "It\'s alright.";

The sequence \\  inserts a single backslash in a string:

Example
string txt = "The character \\ is called backslash.";

Other useful escape characters in C# are:

Code	Result	Try it
\n	New Line	
\t	Tab	
\b	Backspace	
Adding Numbers and Strings
WARNING!

C# uses the + operator for both addition and concatenation.

Remember: Numbers are added. Strings are concatenated.

If you add two numbers, the result will be a number:

Example
int x = 10;
int y = 20;
int z = x + y;  // z will be 30 (an integer/number)

If you add two strings, the result will be a string concatenation:

Example
string x = "10";
string y = "20";
string z = x + y;  // z will be 1020 (a string)
             * 
             */
        }

        public class CsharpBolleans
        {
            /*
             * 
             * C# Booleans
Very often, in programming, you will need a data type that can only have one of two values, like:

YES / NO
ON / OFF
TRUE / FALSE
For this, C# has a bool data type, which can take the values true or false.

Boolean Values
A boolean type is declared with the bool keyword and can only take the values true or false:

Example
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

However, it is more common to return boolean values from boolean expressions, for conditional testing (see below).

Boolean Expression
A Boolean expression is a C# expression that returns a Boolean value: True or False.

You can use a comparison operator, such as the greater than (>) operator to find out if an expression (or a variable) is true:

Example
int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns True, because 10 is higher than 9

Or even easier:

Example
Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9

In the examples below, we use the equal to (==) operator to evaluate an expression:

Example
int x = 10;
Console.WriteLine(x == 10); // returns True, because the value of x is equal to 10

Example
Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

The boolean value of an expression is the basis for all C# comparisons and conditions.
             * 
             * 
             * 
             */
        }

        public class CsharpConditionalIfElse
        {
            /*
             * 
             * 
             * C# Conditions and If Statements
C# supports the usual logical conditions from mathematics:

Less than: a < b
Less than or equal to: a <= b
Greater than: a > b
Greater than or equal to: a >= b
Equal to a == b
Not Equal to: a != b
You can use these conditions to perform different actions for different decisions.

C# has the following conditional statements:

Use if to specify a block of code to be executed, if a specified condition is true
Use else to specify a block of code to be executed, if the same condition is false
Use else if to specify a new condition to test, if the first condition is false
Use switch to specify many alternative blocks of code to be executed
The if Statement
Use the if statement to specify a block of C# code to be executed if a condition is True.

Syntax
if (condition) 
{
  // block of code to be executed if the condition is True
}
Note that if is in lowercase letters. Uppercase letters (If or IF) will generate an error.

In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text:

Example
if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}

We can also test variables:

Example
int x = 20;
int y = 18;
if (x > y) 
{
  Console.WriteLine("x is greater than y");
}

Example explained
In the example above we use two variables, x and y, to test whether x is greater than y (using the > operator). As x is 20, and y is 18, and we know that 20 is greater than 18, we print to the screen that "x is greater than y".

ADVERTISEMENT

The else Statement
Use the else statement to specify a block of code to be executed if the condition is False.

Syntax
if (condition)
{
  // block of code to be executed if the condition is True
} 
else 
{
  // block of code to be executed if the condition is False
}
Example
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."


Example explained
In the example above, time (20) is greater than 18, so the condition is False. Because of this, we move on to the else condition and print to the screen "Good evening". If the time was less than 18, the program would print "Good day".

The else if Statement
Use the else if statement to specify a new condition if the first condition is False.

Syntax
if (condition1)
{
  // block of code to be executed if condition1 is True
} 
else if (condition2) 
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
else
{
  // block of code to be executed if the condition1 is false and condition2 is False
}
Example
int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."


Example explained
In the example above, time (22) is greater than 10, so the first condition is False. The next condition, in the else if statement, is also False, so we move on to the else condition since condition1 and condition2 is both False - and print to the screen "Good evening".

However, if the time was 14, our program would print "Good day."

Short Hand If...Else (Ternary Operator)
There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements:

Syntax
variable = (condition) ? expressionTrue :  expressionFalse;
Instead of writing:

Example
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

You can simply write:

Example
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
             * 
             * 
             */
        }

        public class CsharpSwitchStatements
        {
            /***
             * 
             * 
             * C# Switch Statements
Use the switch statement to select one of many code blocks to be executed.

Syntax
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
This is how it works:

The switch expression is evaluated once
The value of the expression is compared with the values of each case
If there is a match, the associated block of code is executed
The break and default keywords will be described later in this chapter
The example below uses the weekday number to calculate the weekday name:

Example
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)

The break Keyword
When C# reaches a break keyword, it breaks out of the switch block.

This will stop the execution of more code and case testing inside the block.

When a match is found, and the job is done, it's time for a break. There is no need for more testing.

A break can save a lot of execution time because it "ignores" the execution of all the rest of the code in the switch block.

ADVERTISEMENT

The default Keyword
The default keyword is optional and specifies some code to run if there is no case match:

Example
int day = 4;
switch (day) 
{
  case 6:
    Console.WriteLine("Today is Saturday.");
    break;
  case 7:
    Console.WriteLine("Today is Sunday.");
    break;
  default:
    Console.WriteLine("Looking forward to the Weekend.");
    break;
}
// Outputs "Looking forward to the Weekend."
             * 
             * 
             * 
             * 
             * 
             */
        }

        public class CsharpLoops
        {
            /*
             * 
             * Loops
Loops can execute a block of code as long as a specified condition is reached.

Loops are handy because they save time, reduce errors, and they make code more readable.

C# While Loop
The while loop loops through a block of code as long as a specified condition is True:

Syntax
while (condition) 
{
  // code block to be executed
}
In the example below, the code in the loop will run, over and over again, as long as a variable (i) is less than 5:

Example
int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}

Note: Do not forget to increase the variable used in the condition, otherwise the loop will never end!

The Do/While Loop
The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

Syntax
do 
{
  // code block to be executed
}
while (condition);
The example below uses a do/while loop. The loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested:

Example
int i = 0;
do 
{
  Console.WriteLine(i);
  i++;
}
while (i < 5);

Do not forget to increase the variable used in the condition, otherwise the loop will never end!




             * 
             * 
             * 
             * 
             * C# For Loop
When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:

Syntax
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}
Statement 1 is executed (one time) before the execution of the code block.

Statement 2 defines the condition for executing the code block.

Statement 3 is executed (every time) after the code block has been executed.

The example below will print the numbers 0 to 4:

Example
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}

Example explained
Statement 1 sets a variable before the loop starts (int i = 0).

Statement 2 defines the condition for the loop to run (i must be less than 5). If the condition is true, the loop will start over again, if it is false, the loop will end.

Statement 3 increases a value (i++) each time the code block in the loop has been executed.

Another Example
This example will only print even values between 0 and 10:

Example
for (int i = 0; i <= 10; i = i + 2) 
{
  Console.WriteLine(i);
}

ADVERTISEMENT

The foreach Loop
There is also a foreach loop, which is used exclusively to loop through elements in an array:

Syntax
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
The following example outputs all elements in the cars array, using a foreach loop:

Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
             * 
             * 
             * C# Break and Continue
C# Break
You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.

The break statement can also be used to jump out of a loop.

This example jumps out of the loop when i is equal to 4:

Example
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break;
  }
  Console.WriteLine(i);
}


C# Continue
The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

This example skips the value of 4:

Example
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}


Break and Continue in While Loop
You can also use break and continue in while loops:

Break Example
int i = 0;
while (i < 10) 
{
  Console.WriteLine(i);
  i++;
  if (i == 4) 
  {
    break;
  }
}


Continue Example
int i = 0;
while (i < 10) 
{
  if (i == 4) 
  {
    i++;
    continue;
  }
  Console.WriteLine(i);
  i++;
}
             * 
             * 
             * 
             */
        }

        public class CsharpArrays
        {
            /*
             * 
             * C# Arrays
Create an Array
Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

To declare an array, define the variable type with square brackets:

string[] cars;
We have now declared a variable that holds an array of strings.

To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
To create an array of integers, you could write:

int[] myNum = {10, 20, 30, 40};
Access the Elements of an Array
You access an array element by referring to the index number.

This statement accesses the value of the first element in cars:

Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs Volvo

Note: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

Change an Array Element
To change the value of a specific element, refer to the index number:

Example
cars[0] = "Opel";
Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Opel";
Console.WriteLine(cars[0]);
// Now outputs Opel instead of Volvo

ADVERTISEMENT

Array Length
To find out how many elements an array has, use the Length property:

Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4

Loop Through an Array
You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

The following example outputs all elements in the cars array:

Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}


The foreach Loop
There is also a foreach loop, which is used exclusively to loop through elements in an array:

Syntax
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
The following example outputs all elements in the cars array, using a foreach loop:

Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}


The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.

If you compare the for loop and foreach loop, you will see that the foreach method is easier to write, it does not require a counter (using the Length property), and it is more readable.

Sort Arrays
There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:

Example
// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}

// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
} 

System.Linq Namespace
Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

Example
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}





You will learn more about other namespaces in a later chapter.

Other Ways to Create an Array
If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps you have seen arrays with a specified size as well. In C#, there are different ways to create an array:

// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
It is up to you which option you choose. In our tutorial, we will often use the last option, as it is faster and easier to read.

However, you should note that if you declare an array and initialize it later, you have to use the new keyword:

// Declare an array
string[] cars;

// Add values, using new
cars = new string[] {"Volvo", "BMW", "Ford"};

// Add values without using new (this will cause an error)
cars = {"Volvo", "BMW", "Ford"};
             * 
             * 
             * 
             * 
             * 
             * 
             */
        }

        public class CCsharpStructuresStructs
        {
            /* C# Structures (Structs)
             * 
             * C# Structures (Structs)

 
In c#, structures are same as classes, but the only difference is classes are the reference types, and structures are the value types. As a value type, the structures directly contain their value, so their object or instance is stored on the stack, and structures are faster than classes.

 

In c#, the structures can contain fields, properties, member functions, operators, constructors, events, indexers, constants, and even other structure types.

Create Structures in C#
In c#, structures can be created by using struct keyword. Following is the declaration of structure in the c# programming language.

 

public struct users
{
// Properties, Methods, Events, etc.
}
If you observe the above syntax, we defined a structure “users” using struct keyword with public access modifier. Here, the public access specifier will allow the users to create objects for this structure, and inside of the body structure, we can create required fields, properties, methods, and events to use in our applications.

 

Following is the example of defining a structure in the c# programming language.

 

public struct User
{
    public string name;
    public string location;
    public int age;
}
If you observe the above example, we defined a structure called “User” with required fields, and we can add required methods and properties based on our requirements.

C# Structure Initialization
In c#, structures can be instantiated with or without new keyword. Following is the example of assigning values to the variables of structure.

 

User u = new User();
u.name = "Suresh Dasari";
u.location = "Hyderabad";
u.age = 32;
To make use of fields, methods, and events of structure, then it’s mandatory to instantiate a structure with new keyword in c# programming language.

C# Structure with Constructor
In c#, the structures won’t allow us to declare a default constructor or a constructor without parameters. It won’t allow us to initialize fields with values unless they are declared as const or static.

 

Following is the example of defining a structure with parameterized constructor and initializing the constructor fields in the c# programming language.

 

public struct User
{
    public string name, location;
    // Parameterized Constructor
    public User(string a, string b)
    {
        name = a;
        location = b;
    }
}
If you observe the above example, we defined a structure called “User” with required fields and parameterized constructor.

C# Structure with Default Constructor
As discussed, the structures will allow only parameterized constructors, and fields cannot be initialized unless they are declared as const or static.

 

Following is the example of defining a structure with a default constructor and initializing fields with values.

 

struct User
{
    // Compile error
    public string name = "Suresh Dasari";
    public string location;
    public int age;
    // Compile error
    public User()
    {
       location = "Hyderabad";
       age = 32;
    }
}
When we execute the above code, we will get compiler errors because we declared a structure with the default constructor (parameterless) and initialized fields without defining it as const or static.

 

In c#, if we create a structure with the parameterized constructor, then we must need to explicitly initialize all the fields within the constructor before the control is returned to the caller; otherwise, we will get a compile-time error.

 

Following is the example of defining a structure with the parameterized constructor and required fields in the c# programming language.

 

public struct User
{
    public string name, location;
    // Compile Error
    public User(string a)
    {
       name = a;
    }
}
When you execute the above code, we will get a compile-time error because we defined name and location variables, but we assign a value to the only name variable.

 

As discussed, if we create a structure with the parameterized constructor, then we must need to explicitly initialize all the fields before leaving the constructor.

 

Now we will see how to create a structure with fields and parameterized constructors in c# programming language with example.

C# Structure Example
Following is the example of creating a structure with different fields and parameterized constructors in c# programming language with various data members and member functions.

 

using System;

namespace Tutlane
{
    struct User
    {
        public const string name = "Suresh Dasari";
        public string location;
        public int age;
        public User(string a, int b)
        {
           location = a;
           age = b;
        }
    }
    class Program
    {
       static void Main(string[] args)
       {
         // Declare object with new keyword
         User u = new User("Hyderabad", 31);
         // Declare object without new keyword
         User u1;
         Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u.location, u.age);
         // Initialize Fields
         u1.location = "Guntur";
         u1.age = 32;
         Console.WriteLine("Name: {0}, Location: {1}, Age: {2}", User.name, u1.location, u1.age);
         Console.WriteLine("\nPress Enter Key to Exit..");
         Console.ReadLine();
       }
    }
}
If you observe the above example, we defined a structure (User) by including required fields, parameterized constructor, and created an instance of structure (User) with and without new keyword to initialize or get field values based on our requirements.

 

When you execute the above c# program, you will get the result as shown below.

 

C# Structures Example Result

 

In c#, by using structures we can implement an interface, but structures cannot inherit from another structure or class.

C# Structure Characteristics
The following are the important characteristics of structures in the c# programming language.

 

In c#, structures are value types, and those are defined by using struct keyword.
During the structure declaration, the fields cannot be initialized unless defined as const or static.
Structures in c# can include fields, properties, member functions, operators, constructors, events, indexers, constants, and even other structure types.
Structures cannot include the default constructor (constructor without parameters) or destructor, but it will allow us to declare constructors with parameters.
A structure cannot inherit from another structure or class.
In c#, the structure can implement interfaces.
A structure can be instantiated with or without using a new keyword.
*/

            /*C# Difference between Structure and Class
             * 
             * 
             * C# Difference between Structure and Class
            The following are the difference between structures and classes in the c# programming language.



            In c#, classes are the reference types, and structures are the value types.
            Classes can contain default constructors or destructors, but structures will contain only constructors that have parameters.
            We can implement inheritance using Classes, but structures won’t support inheritance.
            Unlike classes, structs can be instantiated with or without using a new operator.
                         * 
                         * 
                         */
        }

        public class CsharpExceptionTryCatchFinallyThrow
            {
                /*
                 * C# Exceptions
    When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.

    When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).

    C# try and catch
    The try statement allows you to define a block of code to be tested for errors while it is being executed.

    The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.

    The try and catch keywords come in pairs:

    Syntax
    try 
    {
      //  Block of code to try
    }
    catch (Exception e)
    {
      //  Block of code to handle errors
    }
    Consider the following example, where we create an array of three integers:

    This will generate an error, because myNumbers[10] does not exist.

    int[] myNumbers = {1, 2, 3};
    Console.WriteLine(myNumbers[10]); // error!
    The error message will be something like this:

    System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
    If an error occurs, we can use try...catch to catch the error and execute some code to handle it.

    In the following example, we use the variable inside the catch block (e) together with the built-in Message property, which outputs a message that describes the exception:

    Example
    try
    {
      int[] myNumbers = {1, 2, 3};
      Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    The output will be:

    Index was outside the bounds of the array.
    You can also output your own error message:

    Example
    try
    {
      int[] myNumbers = {1, 2, 3};
      Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
      Console.WriteLine("Something went wrong.");
    }
    The output will be:

    Something went wrong.


    Finally
    The finally statement lets you execute code, after try...catch, regardless of the result:

    Example
    try
    {
      int[] myNumbers = {1, 2, 3};
      Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
      Console.WriteLine("Something went wrong.");
    }
    finally
    {
      Console.WriteLine("The 'try catch' is finished.");
    }
    The output will be:

    Something went wrong.
    The 'try catch' is finished.



    The throw keyword
    The throw statement allows you to create a custom error.

    The throw statement is used together with an exception class. There are many exception classes available in C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:

    Example
    static void checkAge(int age)
    {
      if (age < 18)
      {
        throw new ArithmeticException("Access denied - You must be at least 18 years old.");
      }
      else
      {
        Console.WriteLine("Access granted - You are old enough!");
      }
    }

    static void Main(string[] args)
    {
      checkAge(15);
    }
    The error message displayed in the program will be:

    System.ArithmeticException: 'Access denied - You must be at least 18 years old.'

    If age was 20, you would not get an exception:

    Example
    checkAge(20);
    The output will be:

    Access granted - You are old enough!

                 * Read more about - The throw keyword
    Practice - The throw statement 

            */
            }




            public class CPPCsharpFunctions
            {
                /*
                 * 
                 * C# Functions
    Summary: in this tutorial, you’ll learn how to make your code reusable by using C# functions.

    Introduction to the C# functions
    Sometimes, you want to perform the same task multiple times in a program. To do so, you can copy and paste the code into various places. However, doing so makes the program very difficult to maintain.

    In programming, we have the Don’t Repeat Yourself (DRY) principle. It means that if you find yourself writing the same statements over and over again, you can turn those statements into a function.

    By definition, a function is a reusable named block of code that does one task.

    For example, the following defines the SayHi() function that outputs the "Hi" message to the console:

    void SayHi()
    {
        Console.WriteLine("Hi");
    }
    Code language: C# (cs)
    In this function:

    void keyword indicates that the SayHi function doesn’t return a value.
    The SayHi identifier is the function name. And you should name the function as descriptive as possible. By convention, the function name should start with a verb (do something specific).
    A function can have zero or more parameters specified in the parentheses that follow the function name. In this example, the SayHi function has no parameter. We’ll cover the parameters shortly.
    The block that follows the parentheses is the function body. A function body contains one or more statements.
    To use the SayHi() function, you call it like this:

    SayHi();
    Code language: C# (cs)
    Output:

    Hi
    Code language: C# (cs)
    When encountering a function call, the compiler will execute the statement inside that function. In this example, it executes the statement that outputs the "Hi" message.

    And you can call the SayHi() function as many times as you want like this:

    void SayHi()
    {
        Console.WriteLine("Hi");
    }

    SayHi();
    SayHi();
    SayHi();
    Code language: C# (cs)
    Output:

    Hi
    Hi
    Hi
    Code language: C# (cs)
    Passing information to functions
    To say hi to someone, you can modify the SayHi() function by adding the name parameter like this:

    void SayHi(string name)
    {
        Console.WriteLine($"Hi {name}");
    }
    Code language: C# (cs)
    The name is the input of the SayHi() function. Technically speaking, the name is a parameter of the SayHi() function.

    Defining a parameter is like declaring a variable. And you can access the parameter like a variable inside the function.

    When calling the SayHi() function, you need to specify a value for the name parameter as follows:

    SayHi("John");
    Code language: C# (cs)
    Output:

    Hi John
    Code language: C# (cs)
    Put it all together.

    void SayHi(string name)
    {
        Console.WriteLine($"Hi {name}");
    }

    SayHi("John");
    Code language: C# (cs)
    Parameters vs. arguments
    A function parameter is an identifier that you specify in the function definition while a function argument is a value that you pass to the function when calling it.

    In the previous example, the name is a parameter of the SayHi() function. When calling the SayHi() function, you pass the literal string "John" to it. This string value is called an argument.

    Sometimes, you’ll see the terms parameter and argument are used interchangeably. But it’s important to understand the difference between them.

    Returning a value
    The SayHi() function doesn’t return any value. Therefore, you use the void keyword. However, if a function returns a value, you need to specify the type of the return value instead.

    For example, the following new SayHi() function returns a string:

    string SayHi(string name)
    {
        return $"Hi {name}";
    }
    Code language: C# (cs)
    In this new SayHi() function, we use the string keyword as the return type of the function instead of void. Also, we use the return statement to return a string.

    The following code calls the SayHi() function, assigns the return value to the greeting variable, and prints it out:

    string SayHi(string name)
    {
        return $"Hi {name}";
    }

    string greeting = SayHi("John");
    Console.WriteLine(greeting);
    Code language: C# (cs)
    Output:

    Hi John
    Code language: C# (cs)
    The reason we return a string from the SayHi() function instead of outputting it directly to the console is that we want to reuse the SayHi() function in other applications such as web applications, not just console applications.

    Documenting C# functions with XML comments
    The following example defines the CalculateBMI() function that calculates the body mass index based on the weight in kilograms and height in meters:

    double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
    Code language: C# (cs)
    When calling the CalculateBMI() function, the Visual Studio (or any code editor) shows the function header:

    However, if you want it to show more information about the function, you can add comments to the function. like this:

    /// <summary>
    /// Calculate the body mass index (BMI) based on weight in kg and height in meter
    /// </summary>
    /// <param name="weight">
    /// The weight in kilogram
    /// </param>
    /// <param name="height">
    /// The height in meter
    /// </param>
    /// <returns>
    /// The body mass index
    /// </returns>
    double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
    Code language: C# (cs)
    To create a comment section for a function, you enter three forward slashes (///) right before the function header.

    The comment of the CalculateBMI function has three main tags: summary, param, and returns.

    The summary tag contains the function description
    The param tag describes the parameters
    The returns tag contains the information of the return value
    C# function example
    The following program calculates the BMI and displays the corresponding weight status:/

    /// <summary>
    /// Calculate the body mass index (BMI) based on weight in kg and height in meter
    /// </summary>
    /// <param name="weight">
    /// The weight in kilogram
    /// </param>
    /// <param name="height">
    /// The height in meter
    /// </param>
    /// <returns>
    /// The body mass index
    /// </returns>
    double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    /// <summary>
    /// Get the weight status based on the Body Mass Index (BMI)
    /// </summary>
    ///<params name="bmi">
    ///The body mass index
    ///</params>
    /// A text string that represents the weight status
    ///<returns>
    ///</returns>
    string GetWeightStatus(double bmi)
    {
        string weightStatus = "";

        switch (bmi)
        {
            case < 18.5:
                weightStatus = "Underweight";
                break;
            case >= 18.5 and <= 24.9:
                weightStatus = "Healthy Weight";
                break;
            case >= 25 and <= 29.9:
                weightStatus = "Overweight";
                break;
            case > 30:
                weightStatus = "Obesity";
                break;
        }
        return weightStatus;
    }

    // main program
    Console.WriteLine("Body Mass Index (BMI) Calculation");

    Console.WriteLine("Enter a weight (kg):");
    var weight = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter a height (m):");
    var height = Convert.ToDouble(Console.ReadLine());


    double bmi = CalculateBMI(weight, height);
    string weightStatus = GetWeightStatus(bmi);

    Console.WriteLine($"BMI: {bmi:0.#}");
    Console.WriteLine($"Weight status:{ weightStatus}");
    Code language: C# (cs)
    How it works.

    First, define the CalculateBMI() function that returns the BMI based on weight and height:

    /// <summary>
    /// Calculate the body mass index (BMI) based on weight in kg and height in meter
    /// </summary>
    /// <param name="weight">
    /// The weight in kilogram
    /// </param>
    /// <param name="height">
    /// The height in meter
    /// </param>
    /// <returns>
    /// The body mass index
    /// </returns>
    double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
    Code language: C# (cs)
    Next, define the GetWeightStatus() function that returns the weight status based on a BMI:


    /// <summary>
    /// Get the weight status based on the Body Mass Index (BMI)
    /// </summary>
    ///<params name="bmi">
    ///The body mass index
    ///</params>
    /// A text string that represents the weight status
    ///<returns>
    ///</returns>
    string GetWeightStatus(double bmi)
    {
        string weightStatus = "";

        switch (bmi)
        {
            case < 18.5:
                weightStatus = "Underweight";
                break;
            case >= 18.5 and <= 24.9:
                weightStatus = "Healthy Weight";
                break;
            case >= 25 and <= 29.9:
                weightStatus = "Overweight";
                break;
            case > 30:
                weightStatus = "Obesity";
                break;
        }
        return weightStatus;
    }
    Code language: C# (cs)
    Then, prompt users to input the height and weight:


    Console.WriteLine("Body Mass Index (BMI) Calculation");

    Console.WriteLine("Enter a weight (kg):");
    var weight = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter a height (m):");
    var height = Convert.ToDouble(Console.ReadLine());
    Code language: C# (cs)
    After that, call the CalculateBMI() and GetWeightStatus() function to calculate the BMI and weight status:

    double bmi = CalculateBMI(weight, height);
    string weightStatus = GetWeightStatus(bmi);
    Code language: C# (cs)
    Finally, show the output:

    Console.WriteLine($"BMI: {bmi:0.#}");
    Console.WriteLine($"Weight status:{ weightStatus}");
    Code language: C# (cs)
    Summary
    A function is a reusable named block of code that does one task.
    A function can have zero or more parameters and an optional return value.
    Use the return statement to return a value from a function.
    Use XML comments to document a function.
                 * 
                 * 
                 * 
                 * 
                 */
            }

            public class CsharpFunctionsMethods
        {
            // Difference between Function and methods.
            /*
             * 
             * When a function is a part of a class, it's called a method.

C# is an OOP language and doesn't have functions that are declared outside of classes, that's why all functions in C# are actually methods.

Though, beside this formal difference, they are the same...
             * 
             * 
             * A function is a piece of code that is called by name. It can be passed data to operate on (i.e. the parameters) and can optionally return data (the return value). All data that is passed to a function is explicitly passed.

A method is a piece of code that is called by a name that is associated with an object. In most respects it is identical to a function except for two key differences:

A method is implicitly passed the object on which it was called.
A method is able to operate on data that is contained within the class (remembering that an object is an instance of a class - the class is the definition, the object is an instance of that data).
(this is a simplified explanation, ignoring issues of scope etc.)
             * 
             * Both are same, there is no difference its just a different term for the same thing in C#.

Method:

In object-oriented programming, a method is a subroutine (or procedure or function) associated with a class.

With respect to Object Oriented programming the term "Method" is used, not functions.
             * 
             * In C#, they are interchangeable (although method is the proper term) because you cannot write a method without incorporating it into a class. If it were independent of a class, then it would be a function. Methods are functions that operate through a designated class.
             * 
             * There is no functions in c#. There is methods (typical method:public void UpdateLeaveStatus(EmployeeLeave objUpdateLeaveStatus)) link to msdn and functors - variable of type Func<>
             * 
             * 
             * 
             * From Object-Oriented Programming Concept:

If you have a function that is accessing/muttating the fields of your class, it becomes method. Otherwise, it is a function.

It will not be a crime if you keep calling all the functions in Java/C++ classes as methods. The reason is that you are directly/indirectly accessing/mutating class properties. So why not all the functions in Java/C++ classes are methods?
             * 
             * 
             * Programmers from structural programming language background know it as a function while in OOPS it's called a method.

But there's not any difference between the two.

In the old days, methods did not return values and functions did. Now they both are used interchangeably.
             * 
             * 
             * A method is on an object or is static in class.
A function is independent of any object (and outside of any class).

For Java and C#, there are only methods.
For C, there are only functions.

For C++ and Python it would depend on whether or not you're in a class.
But in basic English:

Function: Standalone feature or functionality.
Method: One way of doing something, which has different approaches or methods, but related to the same aspect (aka class).
             * 
             * 
             * Function → Free (Free means it can be anywhere, no need to be in an object or class)
               Method → Member (A member of an object or class)
             * 
             * 
            ///




        }







             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */
            // C# Functions
            /* Introduction to C# Functions
             * 
C# functions are the essential parts of the C# program that can be consisting of a number of elements, such as the function name that is used as the function’s reference, return types of the data operated in the functions, logical body of the function, parameters that can be passed as arguments for the function, and the Access Specifier for defining the accessibility of the function inside the program. The different types of functions that can be integrated into a C# program are a combination of functions with or without parameters, which can or cannot have the return values, depending on the requirement provided.

There are several components in functions that follow as-.

To make a function call, we have a unique name called Function name.
To specify the data type of return value, we will use the Return Type.
The block of statements that contains the executable statements is called Body.
We can pass the functions during the function call as a list of arguments called Parameters.
To specify the accessibility of function in the application, we can use the Access specifier.
Different C# Function
without parameters(arguments) and without return type
with parameters(arguments) but without return type
Using with parameters(arguments) and with return type
without parameters(arguments) and with the return value
C# Function Syntax

<access-specifier><return-type>FunctionName(<parameters>)
{
// function body
// return statement
}

In the above syntax, Return statements, parameters, and Access-specifier are optional.




             * 
             * 
             * In the above syntax, Return statements, parameters, and Access-specifier are optional.

 Functional Aspects	& Syntax(Function); -
With parameters and with return values	
            Declaration: int display ( int );
Function call: display ( value );

Function definition:
int display(int value)
{
statements;
return value;
}

With parameters and without return values	
Declaration: void display ( int );
Call: display (value);

Function definition:
void display ( int value)
{
statements;
}
             * 
             * 
             *  Without parameters and without
return values	
            Declaration: void display ();
Call: display ();

Definition:
void display ()
{
statements;
}

Without parameters and with
return values	
            Declaration: int display ( );
Call: display ( );

Definition:
int display ( )
{
statements;
return value;
}

If the return value of a function is “void” then, it cannot return any values to the calling function.
             * 
             * 
             * Note: If the return value of the function such as “int, double, float, string, etc.” is other than void then, it can return values to the calling function.
             * 
             * 
             * 
             * 1. Using Without Parameters and Without Return Type
The function with no parameter and no return type, a function that does not return any of the values here we specified as void type as a return type value. In this program, there should not be passed any values to the function call Display(), and also, there are no values that are returned from this function call to the main function. Let’s see the example with a function build without a return type and parameter,

Example

Code:

using System;
namespace FunctionSamples
{
class Program_A
{
// User defined function without return type and parameter
public void Display()
{
Console.WriteLine("Non Parameterized Function"); // No return statement
}
static void Main(string[] args) // Main Program
{
Program_A program = new Program_A (); // to create a new Object
program.Display(); // Call the Function
}
}
}

Output:

C# Functions 1
2. Using With Parameters (Arguments) and Without Return Type
In this program, a string is passed as a parameter to the function. This function’s return type is “void”, and no values can be returned from the function. The value of the string is manipulated and displayed inside the function itself.

Example

Code:

using System;
namespace FunctionSample
{
class Program_B
{
public void Display(string value) // User defined function without return type
{
Console.WriteLine("Hello " + value); // No return statement
}
static void Main(string[] args) // Main function
{
Program_B program = new Program_B(); // Creating Objec
program.Display("Welcome to C# Functions"); // Calling Function
}
}
}

Output:

C# Functions 2
3. Using With Parameters (Arguments) and with Return Type
In this program, a string is passed as a parameter to the function. The return type of this function is “string”, and the return value of the string can be returned from the function. The value of the string is manipulated and displayed inside the function itself.

Example

Code:

using System;
namespace FunctionsSample
{
class Program_C
{
// User defined function
public string Show(string message)
{
Console.WriteLine("Inside the Show Function Call");
return message;
}
// Main function
static void Main(string[] args)
{
Program_C program = new Program_C();
string message = program.Show("C# Functions");
Console.WriteLine("Hello "+message);
}
}
}

Output:

C# Functions 3
4. Using Without Parameters (Arguments) and with Return Value
In this program, there will be not passed any arguments or parameters to the function “calculate”, but to the main function, the values are returned from this calculate () function call. The variables a and b values are calculated in the function call “calculate”, and in the main function sum of these values is returned as a result.

Example

Code:

using System;
namespace FunctionsSample
{
class Program_D
{
public void calculate()
{
int a = 50, b = 80, sum;
sum = a + b;
Console.WriteLine("Calculating the given to values: " +sum);
}
static void Main(string[] args) // Main function
{
Program_D addition =new Program_D();
addition.calculate();
}
}
}

Output:

C# Functions 4
C# Passing Parameters to Methods
When we are creating a method with arguments/parameters in c#, we must pass arguments/parameters to that specified method when calling our application’s function. We have several ways to pass parameters to the method; let’s see the parameters/arguments.

Parameters	Description
Value Parameters	
            Value parameters are called the “input parameters”. Instead of the original parameters, the input parameters will pass a copy of the original value; due to that, there will not be any cause or changes made to the parameter during the called method, and it will not affect on original values while the control passes to the caller function.
Reference Parameters	
            Reference parameters are called the “input/output parameters”. The reference parameter will pass the reference memory of the original parameters. Thus, the changes/alteration made to the parameters in called method, while the control returns to the caller function, affects the original values.
Output Parameters

It is an “output parameter”; these are like the reference type parameters. The only difference is there is no need to initialize it before passing the data.

             * 
             * 
             * 
             */

            /*C# Methods / Functions with Examples
             * 
             * C# Methods / Functions with Examples

 https://www.tutlane.com/tutorial/csharp/csharp-methods-functions-with-examples

In c#, Method is a separate code block, and that contains a series of statements to perform particular operations. Methods must be declared either in class or struct by specifying the required parameters.

 

Generally, methods are useful to improve code reusability by reducing code duplication. If we have the same functionality to perform in multiple places, then we can create one method with the required functionality and use it wherever it is required in the application.

Syntax of C# Methods
As discussed, c# Methods must be declared either in a class or struct by specifying the required access level, return type, name of the method, and any method parameters like as shown below.

 

class class_name
{
    ...
    ...
    <Access_Specifier> <Return_Type> Method_Name()
    {
        // Statements to Execute
    }
    ...
    ...
}
If you observe the above syntax, we defined the method in a class with various parameters, those are

 

Access_Specifier - It is used to define an access level, either public or private, etc., to allow other classes to access the method. If we didn’t mention any access modifier, then by default, it is private. 
Return_Type - It is used to specify the type of value the method can return. If the method is not returning any value, then we need to mention void as the return type. 
Method_Name - It must be a unique name to identify the method in a class. 
Parameters - The method parameters are useful to send or receive data from a method, and these method parameters are enclosed within parentheses and are separated by commas. If no parameters are required for a method, we need to define a method with empty parentheses.
 In c#, both methods and functions are the same, there is no difference, and these are just different terms to do the same thing in c#.
Following are the examples of defining the different types of methods in the c# programming language.

 

class Users
{
    public void GetUsers() {
       // Statements to Execute
    }
    private void InsertUserDetails(string name, int age) {
       // Statements to Execute
    }
    protected string GetUserDetails(int userid)
    {
       // Statements to Execute
    }
}
If you observe the above example, we defined different methods with different access modifiers, return types, and different parameters based on our requirements.

 

Now we will see the complete example using the methods in the c# programming language.

C# Methods Example
Following is the example of using methods in the c# programming language.

 

using System;

namespace Tutlane
{
     class Program
     {
         static void Main(string[] args)
         {
             Program p = new Program();
             string result = p.GetUserDetails("Suresh Dasari", 31);
             Console.WriteLine(result);
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
         }
         public string GetUserDetails(string name, int age)
         {
             string info = string.Format("Name: {0}, Age: {1}", name, age);
             return info;
         }
     }
}
If you observe the above example, we created a GetUserDetails method and passing parameters to perform required operations. We are accessing the GetUserDetails method by creating an instance of the Program class in the Main method to show the result.

 

When we execute the above c# program, we will get the result as shown below.

 

C# Methods or Functions Example Result

 

This is how we can use methods in c# applications based on our requirements.

C# Static Methods
In c#, if we create methods with static, then we can directly invoke those methods from the class level without creating an object.

 

If you observe the above example, the Main method is static, and we are invoking the GetUserDetails method by creating an instance of the Program class. Instead, if we create a static method, we can directly access those methods in the Main() method without creating an instance of an object.

 

Following is the example of creating static methods to access those methods directly in the Main() method without creating an instance of an object in c#.

 

using System;

namespace Tutlane
{
     class Program
     {
         static void Main(string[] args)
         {
             string result = GetUserDetails("Suresh Dasari", 31);
             Console.WriteLine(result);
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
         }
         public static string GetUserDetails(string name, int age)
         {
             string info = string.Format("Name: {0}, Age: {1}", name, age);
             return info;
         }
     }
}
If you observe the above example, we created a method GetUserDetails() with static. Hence, we can access that method directly in the Main() method without creating an instance of a class object.

 

When we execute the above c# program, we will get the result as shown below.

 

C# Static Methods or Functions Example Result

 

This is how we can create static methods in c# applications to access without creating an instance of an object based on our requirements.
             * 
             */

        }


        public class CsharpStaticClass
        {
            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * Hint:
If you still have problems understanding what "static" means, think about it as of word "unique" or "one and only". Static class is unique class. You can't create more objects of that class and the one you already have doesn't need a name. Non static class is not unique. Many objects of that class can exist, but they all need to have names.

You can say that for Earth "moon" is static. As there are no other instances of earth's moon, it doesnt have a name. It's just a moon.
Mars have multiple moons, so whenever you say something about martian moon, you need to point which one. Martian moon class is not static.
             */

        }

        public class CsharpStaticMethod
        {


        }

        public class CsharpCallByavlueCallByReference
        {
            /*
             * 
             * C# Call By Value
In C# programming language, when we call a function, then it takes a parameter from the main function using the class object. Then the class object inside the main function will copy the function to parameter values. When we use call by value, even if some changes occur within the method that change will not be transferred to the original variable.

Example:

   class Program  
   {  
        public void square(int nmbr)  
        {  
           int nmbr = nmbr * nmbr;
           // Lets provide a return statement  
           Console.WriteLine("Square of the given number is  " + nmbr);   
          }  
          
         public static void Main(string[] args)  
         {  
            int nmbr = 2; // Value assigned before calling function
            Program pr = new Program(); // Creating a class Object  
          
            pr.square( nmbr); //calling the method and assigning the defined integer
            Console.WriteLine("The given number is  " + nmbr); //printing the value        
   
         }  
    }
}
So, if we execute the above program we will find the following output:

Square of the given number is 4
The given number is 2

Explanation

In the above example, we defined an integer variable “nmbr” with a value of 2. Then we called the square function by passing the variable as an argument. Hence, the variable that we passed changed into a multiplication of itself (due to operation of the function) and printed the result.

In the main function at the end, we print the variable that we defined earlier. As we can see, there has been no change in the variable value of the function (where it is defined) but it did change when we passed it as an argument for another function.

As we discussed earlier when we call by value any change that will occur to the variable in a method will not be transferred to the original variable. Hence, when we performed the print operation on the variable, it still gives us the previously defined output.

C# Call By Reference
C# offers a “ref” keyword for passing an argument as a reference type for a function. Unlike call by the value, it doesn’t pass the variable to the function after creating a copy of the variable.

It passes the reference of the original value to the function, hence any change that occurs in the referenced value is permanent and is reflected in the original value as well.

Let’s use the same example as earlier but instead of using call by the value we will be using call by reference:

   class Program  
  {  
        public void square(int nmbr)  
        {  
            int nmbr = nmbr * nmbr;
           // Lets provide a return statement  
           Console.WriteLine("Square of the given number is  " + nmbr);   
         }  
          
        public static void Main(string[] args)  
        {  
           int nmbr = 2; // Value assigned before calling function
           Program pr = new Program(); // Creating a class Object  
          
           pr.square( ref  nmbr); //calling by reference using ref keyword
           Console.WriteLine("The given number is  " + nmbr); //printing the value    
       
        }  
    }
}
So, if we execute the program we will find the following output:

Square of the given number is 4
The given number is 4

Explanation

In the above example, we defined an integer variable “nmbr” with a value of 2. Then we called the square function by passing the variable as an argument. So, the variable that we passed changed into a multiplication of itself (due to operation inside the function) and printed the result i.e. 4.

In the main function at the end, we print the variable that we defined earlier. As we can see that there have been changes in the variable value in the function where it was referenced and operated on. As the function performed the operation and variable value changed to 4, the same is reflected in console output.

As we discussed earlier when we call by reference any change that will occur to the variable in a method will be transferred to the original variable. Hence, when we performed the print operation on the variable, it will print the current output i.e. 4.
             * 
             * 
             * 
             * 
             * 
             * 
             */

        }

        public class ArraysOfStrings
        {
            /* C# | Arrays of Strings

Difficulty Level : Medium
Last Updated : 19 Nov, 2019
An array is a collection of the same type variable. Whereas a string is a sequence of Unicode characters or array of characters. Therefore arrays of strings is an array of arrays of characters. Here, string array and arrays of strings both are same term.

For Example, if you want to store the name of students of a class then you can use the arrays of strings. Arrays of strings can be one dimensional or multidimensional.

Declaring the string array: There are two ways to declare the arrays of strings as follows

Declaration without size:
Syntax:

String[] variable_name;

or

string[] variable_name;

Declaration with size:
Syntax:

String[] variable_name = new String[provide_size_here];

or

string[] variable_name = new string[provide_size_here];

Example:

// declaration using string keyword
string[] s1;

// declaration using String class object
// by giving its size 4
String[] s2 = new String[4];

Initialization of Arrays of Strings: Arrays can be initialized after the declaration. It is not necessary to declare and initialize at the same time using the new keyword. However, Initializing an Array after the declaration, it must be initialized with the new keyword. It can’t be initialized by only assigning values.

Example:

// Declaration of the array
string[] str1, str2;

// Initialization of array
str1 = new string[5]{ “Element 1”, “Element 2”, “Element 3”, “Element 4”, “Element 5” };

str2 = new string[]{ “Element 1”, “Element 2”, “Element 3”, “Element 4”, “Element 5” };

Note: Initialization without giving size is not valid in C#. It will give compile time error.

Example: Wrong Declaration for initializing an array

// compile-time error: must give size of an array
String[] str = new String[];

// error : wrong initialization of an array
string[] str1;
str1 = {“Element 1”, “Element 2”, “Element 3”, “Element 4” };

Accessing Arrays of Strings Elements: At the time of initialization, we can assign the value. But, we can also assign the value of array using its index randomly after the declaration and initialization. We can access an array value through indexing, placed index of the element within square brackets with the array name.

Example:

// declares & initializes string array
String[] s1 = new String[2];

// assign the value "Geeks" in array on its index 0
s1[0] = 10; 

// assign the value "GFG" in array on its index 1
s1[1] = 30;

// assign the value "Noida" in array on its index 2
s1[2] = 20;


// Accessing array elements using index
s1[0];  // returns Geeks
s1[2];  // returns Noida
Declaration and initialization of string array in a single line: String array can also be declared and initialized in a single line. This method is more recommended as it reduces the line of code.

Example:

String[] weekDays = new string[3] {"Sun", "Mon", "Tue", "Wed"}; 
Code#1: String array declaration, initialization and accessing its elements


// C# program to illustrate the String array 
// declaration, initialization and accessing 
// its elements
using System;
  
class Geeks {
      
    // Main Method
    public static void Main()
    {
        // Step 1: Array Declaration
        string[] stringarr; 
          
        // Step 2:Array Initialization
        stringarr = new string[3] {"Element 1", "Element 2", "Element 3"}; 
          
        // Step 3:Accessing Array Elements
        Console.WriteLine(stringarr[0]); 
        Console.WriteLine(stringarr[1]); 
        Console.WriteLine(stringarr[2]); 
    }
}
Output:

Element 1
Element 2
Element 3
Code#2: Array declaration and initialization in single line


// C# code to illustrate Array declaration
// and initialization in single line
using System;
  
class Geeks {
  
    // Main Method
    public static void Main()
    {
        // array initialization and declaration
        String[] stringarr = new String[] {"Geeks", "GFG", "Noida"}; 
  
        // accessing array elements
        Console.WriteLine(stringarr[0]);
        Console.WriteLine(stringarr[1]);
        Console.WriteLine(stringarr[2]);
    }
}
Output:

Geeks
GFG
Noida
Note:

In the public static void main(String[] args), String[] args is also an array of string.
Example: To show String[] args is an array of string.


// C# program to get the type of "args"
using System;
  
class GFG {
  
    // Main Method
    static public void Main (String[] args) {
          
        // using GetType() method to
        // get type at runtime
        Console.WriteLine(args.GetType());
    }
}
Output:

System.String[]
C# string array is basically an array of objects.
It doesn’t matter whether you are creating an array of string using string keyword or String class object. Both are same.
Example:


// C# program to get the type of arrays of 
// strings which are declared using 'string'
// keyword and 'String class object'
using System;
  
class GFG {
  
    // Main Method
    static public void Main (String[] args) {
  
        // declaring array of string 
        // using string keyword
        string[] s1 = {"GFG", "Noida"};
  
         // declaring array of string 
        // using String class object
        String[] s2 = new String[2]{"Geeks", "C#"};
  
        // using GetType() method to
        // get type at runtime
        Console.WriteLine(s1.GetType());
        Console.WriteLine(s2.GetType());
    }
}
Output:

System.String[]
System.String[]
             * 
             * 
             * 
             * 
             * 
             */
        }

        public class thisKeywordCS
        {
            /*
             * 
             * 
             * namaspace thiswordInCS{
             
             class Program
             {
//this keyword - It Eliminates Naming Conflict . It Indicate Current Instance.
2 variable Sometimes have same identifier . this Keyword Remove Confusion.
int a, b, c;
//instance variable
//10, 20, 30
public Program(int a, int b, int c) //parameter variable
            {
this .a = a;
//this.a=10
this.b = b;
//this.b=20
this.c = c;
//this. c=30
            //instance variable
//10, 20, 30
}

public void display(int a, int b, int c) //100 200 300
            {
Console.WriteLine(a + "\t" + b + "\t" + c);
Console. WriteLine(this.a + "\t" + this.b + "\t" + this.c);
//10 20 30
}
static void Main(string[] args)
            {
Program p = new Program(10, 20, 30) ;
p.display(100,200,300); // Argument to parameter variables
Console.readline();
            }
        }
            
    }
            * 
             * 
             * 
             */
        }

        public class AutoImplementedProperty
            {
            /***
             * 
             * C# auto implemented properties tutorial example explained

#C# #auto-implemented #properties

using System;

namespace MyFirstProgram
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //                                you only have to write get; and/or set; inside the property                             

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        public String Model {get; set;}

        public Car(String model)
        {
            this.Model = model;
        }
    }
}
             * 
             * 
             * 
             * 
             * 
             */

        }

    }

