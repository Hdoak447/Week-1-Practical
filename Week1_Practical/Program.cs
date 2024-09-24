//Task1();
//Task2();
//Task3();
//Task4();
Task5();
void Task1()
{
    Console.WriteLine("Please enter your name: ");
    String name = Console.ReadLine();
    Console.WriteLine("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine()) + 5;
    Console.WriteLine("Hello {0}, you will be {1} in 5 years.", name, age);
}

void Task2()
{
    Console.WriteLine("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age > 110)
    {
        Console.WriteLine("Incorrect Age");
    }
    else if (age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age > 12 && age < 20)
    {
        Console.WriteLine("You are a Teen");
    }
    else if (age > 19)
        Console.WriteLine("You are an Adult");
}
void Task3()
{
    Console.WriteLine("Please enter number: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb == 0)
    {
        Console.WriteLine("Number is 0");
    }
    else if (numb < 0)
    {
        Console.WriteLine("Number is negative");
    }
    else if (numb > 0)
    {
        Console.WriteLine("Number is positive");
    }
}

void Task4()
{
    Console.WriteLine("Please enter year: ");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year < 0)
    {
        Console.WriteLine("Year is incorrect");
    }
    else if (year % 4 == 0)
    {
        Console.WriteLine("Year is a leap year");
    }
    else if (year % 4 != 0)
    {
        Console.WriteLine("Year is not a leap year");
    }
}

void Task5()
{
    Console.WriteLine("Please enter number: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb % 2 == 0)
    {
        Console.WriteLine("Even number");
    }
    else if (numb % 2 != 0)
    {
        Console.WriteLine("Odd Number");
    }
}

