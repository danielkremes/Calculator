Sum();
Subtraction();
Multiplication();

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

    //Break program
    Console.ReadKey();
}

static void Subtraction (){
    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double subtraction = valueOne - valueTwo;

    Console.WriteLine($"Value of subtraction is: {subtraction}");
    
    //Break program
    Console.ReadKey();
}

static void Multiplication(){

    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double multiplication = valueOne * valueTwo;

    Console.WriteLine($"Value of multiplication is: {multiplication}");

    //Break program
    Console.ReadKey();
}

static void Division(){
    Console.Clear();

    Console.WriteLine("First value");
    double valueOne = Double.Parse(Console.ReadLine());

    Console.WriteLine("Second Value ");
    double valueTwo = double.Parse(Console.ReadLine());

    //Operation
    double division = valueOne / valueTwo;

    Console.WriteLine($"Value of division is: {division}");

    //Break program
    Console.ReadKey();
}

