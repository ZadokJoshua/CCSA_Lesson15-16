using Exceptions;

Console.WriteLine("******************************************");
Console.WriteLine("What kind of exception do you want to try?");
Console.WriteLine("1. Divide By Zero Exception");
Console.WriteLine("2. Index out of bound Exception");
Console.WriteLine("3. Invalid Cast Exception");
//Console.WriteLine("4. Null Reference Exception");
//Console.WriteLine("5. Array Type Mismatch Exception");
//Console.WriteLine("6. IO Exception");
//Console.WriteLine("7. Argument Exception");
//Console.WriteLine("8. User Defined Exception One");
//Console.WriteLine("9 User Defined Exception Two");
Console.WriteLine("4. User Defined Exception Test");
Console.WriteLine("******************************************");
Console.Write("Your Option: ");
int option = Convert.ToInt32(Console.ReadLine());

DemoClass demoClass = new DemoClass();

switch (option)
{
    case 1:
        demoClass.DividedbyZero();
        break;

    case 2:
        demoClass.IOutBException();
        break;

    case 3: 
        demoClass.InvalidCasException();
        break;
    case 4:
        demoClass.DataSub();
        break;
}
