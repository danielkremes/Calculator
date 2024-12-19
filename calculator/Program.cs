Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Welcome");
    Console.WriteLine("What you like to do ?");
    Console.WriteLine("1 (Sum)");
    Console.WriteLine("2 (Subtraction)");
    Console.WriteLine("3 (Multiplication)");
    Console.WriteLine("4 (Division)");
    Console.WriteLine("0 (Quit)");
    Console.WriteLine("---------------");
    Console.WriteLine("Choose one option");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {

        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Multiplication(); break;
        case 4: Division(); break;
        case 0: System.Environment.Exit(0); break;
        default:
            Menu(); break;
    }
}

static void Sum()
{
    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double sum = valueOne + valueTwo;

    Console.WriteLine($"Value type it it was: {valueOne}");
    Console.WriteLine($"Value type it it was {valueTwo}");
    Console.WriteLine($"Value of sum is: {sum}");

    //Break application
    Console.ReadKey();
    Menu();
}

static void Subtraction()
{
    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double subtraction = valueOne - valueTwo;

    Console.WriteLine($"Value of subtraction is: {subtraction}");
    Console.ReadKey();
    Menu();
}

static void Multiplication()
{

    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double multiplication = valueOne * valueTwo;

    Console.WriteLine($"Value of multiplication is: {multiplication}");

    Console.ReadKey();
    Menu();
}

static void Division()
{
    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double division = valueOne / valueTwo;

    Console.WriteLine($"Value of division is: {division}");

    Console.ReadKey();
    Menu();
}

