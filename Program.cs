Console.WriteLine("Welcome to the Number Analyzer!");
bool programLoop = true;

while (programLoop)
{
    //getting number
    Console.WriteLine("Please enter an integer between 1 and 100 inclusive to be analyzed.");
    int num = int.Parse(Console.ReadLine());
    while (num <= 0 || num > 100)
    {
        Console.WriteLine("Invalid number. Please enter an integer between 1 and 100 inclusive.");
        num = int.Parse(Console.ReadLine());
    }

    //checking if even or odd
    bool isEven;
    if (num % 2 == 0)
    {
        isEven = true;
    }
    else
    {
        isEven = false;
    }

    // list of if statements
    if (isEven)
    {
        if (num <= 24)
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (num >= 26 && num <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else
        {
            Console.WriteLine("Even and greater than 60.");
        }
    }
    else
    {
        if (num < 60)
        {
            Console.WriteLine("Odd and less than 60.");
        }
        else
        {
            Console.WriteLine("Odd and greater than 60.");
        }
    }

    Console.WriteLine("Would you like to continue? y/n");
    string answer = Console.ReadLine();
    if (answer == "y")
    {
        programLoop = true;
    }
    else
    {
        programLoop = false;
    }
}
Console.WriteLine("Thank you for using the Number Analyzer.");