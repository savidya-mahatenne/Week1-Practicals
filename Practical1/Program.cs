void Task1()
{
    Console.WriteLine("Please enter your name:");
    String name = Console.ReadLine();

    Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Hello {name}, you will be {age + 5} in 5 years.");
}

void Task2()
{
    // Enter user's age
    Console.WriteLine("Please enter your age:");
    int userAge = Convert.ToInt32(Console.ReadLine());

    // Ensure age is between 0 and 110
    while (userAge <= 0 || userAge >= 110)
    {
        Console.WriteLine("Please enter a valid age.");
        userAge = Convert.ToInt32(Console.ReadLine());
    }

    // Check whether they are a child, teenager or adult
    if (userAge < 13)
    {
        Console.WriteLine("You are a child.");
    }
    else if (userAge >= 13 && userAge <= 19)
    {
        Console.WriteLine("You are a teenager.");
    }
    else
    {
        Console.WriteLine("You are an adult.");
    }
}

void Task3()
{
    // Prompt user to enter integer
    Console.WriteLine("Please enter an integer:");
    int number = Convert.ToInt32(Console.ReadLine());

    // Check if number is positive, negative or zero
    // Print appropriate message
    if (number < 0)
    {
        Console.WriteLine("This is a negative number.");
    }
    else if (number == 0)
    {
        Console.WriteLine("This is zero.");
    }
    else
    {
        Console.WriteLine("This is a positive number");
    }
}

void Task4()
{
    // Prompt user to enter a year.
    Console.WriteLine("Please enter a year");
    int year = Convert.ToInt32(Console.ReadLine());

    // Handle negative year input.
    while (year <= 0)
    {
        Console.WriteLine("Please enter a valid year.");
        year = Convert.ToInt32(Console.ReadLine());
    }

    // Check if the year is a leap year or not. 
    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    {
        Console.WriteLine($"{year} is a leap year.");
    } else
    {
        Console.WriteLine($"{year} is NOT a leap year.");
    }
}

void Task5()
{
    // prompt user to enter a number
    Console.WriteLine("Please enter a number:");
    int num = Convert.ToInt32(Console.ReadLine());

    // determine if the number is even or odd
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} is an even number.");
    }
    else
    {
        Console.WriteLine($"{num} is an odd number.");
    }
}

// Task1();
// Task2()
// Task3();
// Task4();
Task5();