
using System;

#region PART A
// .csproj: contains the project's configuration and settings.
// Program.cs: contains the C# code of the application.
// obj/: contains temporary files generated during build.
// bin/: contains the compiled output of the application.

Console.WriteLine("=== PART A: Project & Structure ===");
#endregion

#region PART B - Variables, Types & Casting

Console.WriteLine("=== PART B: Variables, Types & Casting ===");

RunTypesDemo();

void RunTypesDemo()
{
    #region Variables and types
    int number = 17;
    long bigNumber = 100000;
    double doubleNumber = 15.5;
    decimal decimalNumber = 20.50m;
    bool isStudent = true;
    char letter = 'M';
    string name = "Malak";
    var inferredNumber = 50;

    Console.WriteLine($"int: {number}, Type: {number.GetType()}");
    Console.WriteLine($"long: {bigNumber}, Type: {bigNumber.GetType()}");
    Console.WriteLine($"double: {doubleNumber}, Type: {doubleNumber.GetType()}");
    Console.WriteLine($"decimal: {decimalNumber}, Type: {decimalNumber.GetType()}");
    Console.WriteLine($"bool: {isStudent}, Type: {isStudent.GetType()}");
    Console.WriteLine($"char: {letter}, Type: {letter.GetType()}");
    Console.WriteLine($"string: {name}, Type: {name.GetType()}");
    Console.WriteLine($"var: {inferredNumber}, Type: {inferredNumber.GetType()}");

    #endregion

    #region Implict Conversion
    int num = 10;
    long longNum = num; // Implict Converson from int to long.
    Console.WriteLine($"int -> long: {longNum}");

    char grade = 'A';
    int gradeVaue = grade; // Implict Conversion from char to int.
    Console.WriteLine($"char -> int : {gradeVaue}");

    #endregion

    #region Explicit Conversion
    double doubleValue = 9.78;
    int castResult = (int)doubleValue; // Explict Conversion from double to int.
    int convertResult = Convert.ToInt32(doubleValue); // Explict Conversion using Convert class.

    Console.WriteLine($"double -> int : {castResult}"); // 9
    Console.WriteLine($"double -> int : {convertResult}"); // 10

    #endregion

    #region Integer Division

    int integerDivision = 5 / 2;
    double doubleDivision = 5.0 / 2;

    Console.WriteLine($"5 / 2 = {integerDivision}");
    Console.WriteLine($"5.0 / 2 = {doubleDivision}");

    // int / int gives integer division, while using a double gives a decimal result.

    #endregion

    #region Boxing and Unboxing

    int value = 30;
    object boxedValue = value; // Boxing : Convering value type to reference type.
    Console.WriteLine($"After boxing: {boxedValue}");

    int unboxedValue = (int)boxedValue; // Unboxing : Converting reference type to value type.
    Console.WriteLine($"After boxing: {unboxedValue}");
    #endregion

    #region Parse -- TryParse

    string text = "123";
    int parsedValue = int.Parse(text);
    Console.WriteLine($"Parsed value : {parsedValue}");


    string invalidText = "abc";
    bool isSucces = int.TryParse(invalidText, out int result);

    if (!isSucces)
        Console.WriteLine("Parsing failed  - _ - ");

    else
        Console.WriteLine($"Parsed value using TryParse : {result}");

    #endregion

    #region float to decimal Conversion
    float floatNumber = 3.14f;
    //decimal decimalValue = floatNumber;    // This does not compile because float -> decimal is not an implicit conversion.

    decimal decimalValue = (decimal)floatNumber;
    Console.WriteLine($"float: {floatNumber}");
    Console.WriteLine($"decimal: {decimalValue}");

    #endregion
}
#endregion

#region PART C - Value vs. Reference Types

Console.WriteLine("=== PART C: Value vs. Reference Types ===");

RunValueVsReferenceDemo();

void RunValueVsReferenceDemo()
{
    #region Experiment 1 - Struct copy semantics
    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;

    p2.X = 99;

    Console.WriteLine($"p1.X = {p1.X}");
    Console.WriteLine($"p2.X = {p2.X}");

    // Structs are value types, so assigning p1 to p2 copies the values.
    // Changing p2 does not affect p1.
    #endregion

    #region Experiment 2 - Class reference semantics

    Order o1 = new Order
    {
        OrderId = 101,
        CustomerName = "Sara",
        Quantity = 3,
        UnitPrice = 250m,
        TotalPrice = 0m,
        IsPaid = false,
        DiscountPercent = 20,
        ShippingCity = "Giza",
        Priority = 'M',
        ItemCode = 987654L

    };

    o1.CalculateTotal();

    Order o2 = o1;

    o2.IsPaid = true;

    Console.WriteLine($"o1.IsPaid = {o1.IsPaid}");
    Console.WriteLine($"o2.IsPaid = {o2.IsPaid}");

    // o1 and o2 refer to the same object, so changing o2 also changes o1.

    object boxedOrder = o1;

    Order o3 = (Order)boxedOrder;

    Console.WriteLine($"ReferenceEquals(o1, o3): {object.ReferenceEquals(o1, o3)}");

    o2.PrintSummary();

    // Value types copy the value.
    // Reference types copy the reference.
    // o1 and o2 point to the same object on the heap.
    #endregion
}
#endregion

#region PART D - Scope & Operators

#region D1 — Scope
ScopeDemo scopeDemo = new ScopeDemo();

scopeDemo.ShowField();
scopeDemo.ShowFieldAgain();
scopeDemo.MethodScopeDemo();
scopeDemo.BlockScopeDemo();
#endregion

#region D2 - Composite (compound assignment) operators
int total = 100;

total += 10;
Console.WriteLine($"After += : {total}");

total -= 20;
Console.WriteLine($"After -= : {total}");

total *= 2;
Console.WriteLine($"After *= : {total}");

total /= 4;
Console.WriteLine($"After /= : {total}");

total %= 6;
Console.WriteLine($"After %= : {total}");

// total += 10; is equivalent to: total = total + 10;

#endregion

#region D3 -  Bitwise operators
int a = 12;
int b = 10;

Console.WriteLine($"12 & 10 = {a & b}");
Console.WriteLine($"12 | 10 = {a | b}");
Console.WriteLine($"12 ^ 10 = {a ^ b}");

//&& stops evaluating when the left operand is false
//while & evaluates both operands even when the left operand is false.

#endregion
#endregion

#region PART D (class ScopeDemo) 
class ScopeDemo
{
    private int fieldValue = 10;

    public void ShowField()
    {
        Console.WriteLine($"Field: {fieldValue}");
    }

    public void ShowFieldAgain()
    {
        Console.WriteLine($"Field again: {fieldValue}");
    }

    public void MethodScopeDemo()
    {
        int localVariable = 40;

        Console.WriteLine($"Local variable: {localVariable}");
    }

    public void BlockScopeDemo()
    {
        for (int i = 0; i < 3; i++)
        {
            int insideLoop = i * 2;
            Console.WriteLine($"Inside loop: {insideLoop}");

        }
    }

}
#endregion




