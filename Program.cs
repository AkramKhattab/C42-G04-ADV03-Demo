using System.Reflection.Metadata.Ecma335;

namespace C42_G04_ADV03_Demo
{

    //Class
    //Struct
    //enun
    //interface

    // Step 0: Declare Delegate

    public delegate int StringsFuncDelegate(string str);
    // NEW DELEGATE (CLASS) , Referance From Delegate ==> Can Refere To Function Or More [Pointer To Function]
    // These Must Be Has The Same Signature Of Delegate: int(string)
    // Regardless Functions Naming [Function Names Or Parameter Names], Access Modifiers




    //public delegate bool ConditonsFuncDelegate(int A);
    //public delegate bool ConditonsFuncDelegateV02(string A);

    public delegate bool ConditonsFuncDelegate<T>(T A);


    internal class Program
    {


        //        {
        //        List<T> Result = new List<T>();

        //        if (list is not null) 
        //        {

        //            for (int i = 0; i < list.Count; i++)
        //            {
        //                if (reference.Invoke(list[i]))
        //                {
        //                    Result.Add(list[i]);
        //                }
        //            }
        //        }






        //static List<T> FindElements<T>(List<T> list, ConditonsFuncDelegate<T> reference)
        //{
        //    List<T> Result = new List<T>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //static List<int> FindNumbers(List<int> list, ConditonsFuncDelegate reference)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}

        //static List<string> FindElements(List<string> list, ConditonsFuncDelegateV02 reference)
        //{
        //    List<string> Result = new List<string>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}



        //static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckOdd(list[i])) // Odd
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}


        //static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckEven(list[i])) // Even
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}

        //static List<int> FindDivisableBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckDivisableBy4(list[i])) // Divisable By 4
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}


        //static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 != 0) // Odd
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}


        //static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0) // Even
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}

        //static List<int> FindDivisableBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0) // Divisable By 4
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }


        //    return Result;
        //}


        static void Main()
        {
            //================ Overview ================//
            //Delegate : C# Languague Feature
            //Pure OOP
            //Usages :
            // 1. Functional Programming
            // 2. Event-Driven Programming
            // JAVA = Pure OOP
            //=========================================//


            //AnonymousMethodAndLambda();
            //DelegateFeatureCSharp10();
            //FunctionReturnsFunction();


            #region Delegate Ex01


            //Step 01: Declare Reference From Type StingsDuncDelegate[Delegate]
            //StringsFuncDelegate X = StringsFunctions.GetCountOfUpperCaseChar;

            //StringsFuncDelegate reference = new StringsFuncDelegate(StringsFunctions.GetCountOfUpperCaseChar);
            //StringsFuncDelegate refrence = StringsFunctions.GetCountOfUpperCaseChar; // Syntax Sugar

            //refrence = StringsFunctions.Print; // Invalid

            //refrence = StringsFunctions.GetCountOfLowerCaseChar;

            //refrence += StringsFunctions.GetCountOfLowerCaseChar;


            //Step 02: Use[Functions] Through Reference
            //int Result = X.Invoke("Hello World");
            //int Result = refrence.Invoke("Hello World");
            //int Result = refrence("Hello World");


            //Console.WriteLine(Result);

            #endregion

            #region Delegate Ex 02
            // int[] Numbers = { 9, 8, 7, 6, 5, 1, 2, 3, 4, };

            //Bubble Sort

            //SortingAlgorithms.BubbleSort(Numbers);
            //SortingAlgorithms.BubbleSortAscending(Numbers);
            //SortingAlgorithms.BubbleSortDescnding(Numbers);

            //ConditionFuncDelegate Ref = SortingFunctions.CompareGtr;

            ////SortingAlgorithms.BubbleSort(Numbers, Ref); // Sort Ascending



            ////Ref = SortingFunctions.CompareGtr;
            //Ref = SortingFunctions.CompareLess;


            //SortingAlgorithms.BubbleSort(Numbers, Ref); // Sorting Descending


            //SortingAlgorithms.BubbleSort(Numbers, SortingFunctions.CompareGtr); // Sorting Ascending
            //SortingAlgorithms.BubbleSort(Numbers, SortingFunctions.CompareLess); // Sorting Descending

            //SortingAlgorithms.BubbleSort(Numbers, SortingFunctions.SortAscending); // Sorting Ascending
            //SortingAlgorithms.BubbleSort(Numbers, SortingFunctions.SortDescending); // Sorting Descending

            //foreach (int item in Numbers) 
            //{
            //    Console.Write(item + " ");
            //}


            //string[] Names = { "Mahmoud", "Ahmed", "Ali", "Omar", "Mariam", "Aya" };


            //SortingAlgorithms.BubbleSort(Names, SortingFunctions.SortAscending);
            //SortingAlgorithms.BubbleSort(Names, SortingFunctions.SortDescending);

            //foreach (string item in Names)
            //{
            //    Console.WriteLine(item);
            //}



            //SortingAlgorithms.BubbleSort(Numbers, SortingFunctions.SortDescending);

            //foreach (int item in Numbers)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Delegate Ex03
            //List<int> list = Enumerable.Range( 1, 100 ).ToList(); // 1 , 2 , 3 , ... , -----> 100

            //List<int> OddNumbers = FindOddNumbers(list);
            //List<int> EvenNumbers = FindEvenNumbers(list);
            //List<int> DivisableBy4Numbers = FindDivisableBy4Numbers(list);

            //List<int> OddNumbers = FindNumbers(list, ConditionsFunctions.CheckOdd);
            //List<int> EvenNumbers = FindNumbers(list, ConditionsFunctions.CheckEven);
            //List<int> DivisableBy4Numbers = FindNumbers(list, ConditionsFunctions.CheckDivisableBy4);

            //foreach (int item in DivisableBy4Numbers)
            //{
            //    Console.Write(item + " ");
            //}


            //List<string> Names = new List<string> { "Mahmoud", "Ahmed", "Ali", "Omar", "Mariam", "Aya" };

            // List<string> Result = FindElements(Names, ConditionsFunctions.CheckLength);

            //foreach (string item in Result) 
            //{
            //    Console.Write(item + " ");
            //}




            //private static List<string> FindElements(List<string> names, Func<string, bool> checkLength)
            //{
            //    throw new NotImplementedException();
            //}


            // Predicate - Func - Action


            // ========== PERDICATE ==========//
            //Predicate<int> predicate = ConditionsFunctions.CheckEven;


            // Func
            //Func<int, bool> func = ConditionsFunctions.CheckEven;


            //============================================//


            #endregion

            #region Anonymous Method and Lambda Expression
            //static void AnonymousMethodAndLambda()
            //{
            //    // Declare a delegate
            //    Func<int, int, int> mathOperation;

            //    // Anonymous Method
            //    mathOperation = delegate (int a, int b)
            //    {
            //        return a + b;
            //    };
            //    Console.WriteLine($"Anonymous Method Result: {mathOperation(5, 3)}");

            //    // Lambda Expression
            //    mathOperation = (a, b) => a * b;
            //    Console.WriteLine($"Lambda Expression Result: {mathOperation(5, 3)}");
            //}
            // Explanation:
            // - Anonymous Method:
            //   - Uses the 'delegate' keyword followed by the parameter list and method body.
            //   - Allows for more complex logic within the method body.
            //   - Syntax: delegate(parameters) { method body }
            // - Lambda Expression:
            //   - A more concise way to write anonymous methods.
            //   - Uses the '=>' operator (read as "goes to").
            //   - Syntax: (parameters) => expression or { statement block }
            //   - For single expressions, curly braces and 'return' keyword can be omitted.
            #endregion

            #region New Feature at Delegate in C# 10.0
            //delegate void PrintMessage(string message);

            //static void DelegateFeatureCSharp10()
            //{
            //    // Traditional delegate creation
            //    PrintMessage traditionalDelegate = new PrintMessage(Console.WriteLine);
            //    traditionalDelegate("Traditional delegate");

            //    // New in C# 10.0: Delegate creation with method group
            //    PrintMessage newDelegate = Console.WriteLine;
            //    newDelegate("New delegate syntax");

            //    // Using with custom methods
            //    static void CustomPrint(string msg) => Console.WriteLine($"Custom: {msg}");
            //    PrintMessage customDelegate = CustomPrint;
            //    customDelegate("Using custom method");
            //}
            // Explanation:
            // - C# 10.0 simplified delegate creation by allowing direct assignment of methods.
            // - Previously, you had to use the 'new' keyword and explicitly invoke the delegate constructor.
            // - Now, you can directly assign a method to a delegate variable.
            // - This works with both built-in methods (like Console.WriteLine) and custom methods.
            // - The compiler automatically creates the delegate instance, improving code readability.
            #endregion

            #region Function Returns Function - FP Feature
            //static void FunctionReturnsFunction()
            //{
            //    // Get a function that performs arithmetic operations
            //    Func<int, int, int> add = GetOperation("add");
            //    Func<int, int, int> multiply = GetOperation("multiply");

            //    Console.WriteLine($"5 + 3 = {add(5, 3)}");
            //    Console.WriteLine($"5 * 3 = {multiply(5, 3)}");
            //}

            //// Function that returns another function
            //static Func<int, int, int> GetOperation(string operationType)
            //{
            //    switch (operationType.ToLower())
            //    {
            //        case "add":
            //            return (a, b) => a + b;
            //        case "multiply":
            //            return (a, b) => a * b;
            //        default:
            //            return (a, b) => 0; // Default operation
            //    }
            //}
            // Explanation:
            // - This example demonstrates a function (GetOperation) that returns another function.
            // - The returned function is of type Func<int, int, int>, which takes two int parameters and returns an int.
            // - GetOperation acts as a factory, producing different arithmetic operations based on the input string.
            // - This is a powerful functional programming concept, allowing for:
            //   1. Higher-order functions (functions that take or return other functions)
            //   2. Dynamic function creation based on runtime conditions
            //   3. Improved code modularity and reusability
            // - The returned functions are lambda expressions, showcasing the synergy between functional programming concepts and C#'s lambda syntax.
            #endregion





            //class StringsFunctions
            //{
            //    //Class Member Function
            //    public static int GetCountOfUpperCaseChar(string Word)
            //    {
            //        int count = 0;
            //        if (!string.IsNullOrEmpty(Word))
            //        {
            //            for (int i = 0; i < Word.Length; i++)
            //            {
            //                if (char.IsUpper(Word[i]))
            //                {
            //                    count++;
            //                }
            //            }
            //        }


            //        return count;
            //    }

            //    public static int GetCountOfLowerCaseChar(string Word)
            //    {
            //        int count = 0;
            //        if (!string.IsNullOrEmpty(Word))
            //        {
            //            for (int i = 0; i < Word.Length; i++)
            //            {
            //                if (char.IsLower(Word[i]))
            //                {
            //                    count++;
            //                }
            //            }
            //        }


            //        return count;
            //    }



            //    public static void Print(String s)
            //    {

            //    Console.WriteLine(s);
            //    }


            //}

            //class ConditionsFunctions
            //{
            //    public static bool CheckOdd(int x) { return x % 2 == 0; }
            //    public static bool CheckEven(int x) { return x % 2 != 0; }
            //    public static bool CheckDivisableBy4(int x) { return x % 4 == 0; }
            //    public static bool CheckDivisableBy7(int x) { return x % 7 == 0; }
            //    public static bool IsPrime(int x) { return x % 7 == 0; }
            //    public static bool CheckLength(string S) { return S.Length > 3; }
        }
    }
}