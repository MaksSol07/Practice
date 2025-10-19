/*
WELCOME TO C#!

In here you will learn basics of C# that will help you get started with programming in C# an also in .NET
C# is used for building varius web applications, desktop applications, mobile applications, games and much more.

Let's start with the traditional "Hello World!" program.
*/

Console.WriteLine("Hello World!");

//  to run the progrram press Ctrl + F5 or press the green play button on the top.

/*
    To determine variables we use the following syntax:
    <data_type> <variable_name> = <value>;

    Example:
*/

int number = 5;

//  We created variable number that coontainsa a simple intiger value of 5.
/*
    Other basic data types in C# are:
    - string: for text
    - bool: for true/false values
    - double: for decimal numbers
    - char: for single characters
    - float: for decimal numbers with less precision
*/

/*
    Now let's print the value of our variable to the console.
    We can join text and variables using the + operator like this so the output is more eye catching.
*/

Console.WriteLine("The value of number is: " + number);

/*
    Bascic arithmetic operations in C# are:
    + : addition
    - : subtraction
    * : multiplication
    / : division
    % : modulus (remainder of division)

   Basic equation operators:
    = : assignment
    += : addition assignment
    -= : subtraction assignment
    *= : multiplication assignment
    /= : division assignment
    %= : modulus assignment

    Basic comparison operators:
    == : equal to
    != : not equal to
    > : greater than
    < : less than
    >= : greater than or equal to
    <= : less than or equal to
    === : strict equal to (compares both value and type)
*/


// The if instructioon syntax in C# is as follows:
/*
    if (condition)
    {
        // code to be executed if condition is true
    }
    else if (condition)
    {
        // code to be executed if condition is true
    }
    else
    {
        // code to be executed if condition is false
    } 
*/

Console.Write("Enter any number: ");
string input = Console.ReadLine();
int usrNumber = int.Parse(input);
if (usrNumber % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}
/*
    This program takes a number input from the user and checks if it is even or odd using the modulus operator (%).
    If the remainder when divided by 2 is 0, it is even; otherwise, it is odd.
*/
