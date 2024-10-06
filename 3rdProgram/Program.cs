// Calculator
bool doingcalculator = true;
bool doingaddition = false;
bool doingsubtraction = false;
bool doingmultiplication = false;

static int Add(int num1, int num2)
{
    return num1 + num2;
}

static int Subtract(int num1, int num2)
{
    return num1 - num2;
}

static int Multiply(int num1, int num2)
{
    return num1 * num2;
}

static int[] ConvertStringToArguments(string input)
{
    // Split the string by comma and trim whitespace, then convert to integers
    string[] parts = input.Split(',');
    int[] numbers = new int[parts.Length];

    for (int i = 0; i < parts.Length; i++)
    {
        numbers[i] = int.Parse(parts[i].Trim()); // Convert and trim each part
    }

    return numbers;
}

while (doingcalculator == true)
{
    #pragma warning disable CS8600
    string currentcommand = Console.ReadLine();
    #pragma warning restore CS8600

    #pragma warning disable CS8604
    if (doingaddition == true)
    {
        int[] gotten = ConvertStringToArguments(currentcommand);
        int whatimado = Add(gotten[0], gotten[1]);

        Console.WriteLine($"output: {whatimado}");
        doingaddition = false;
    }
    else if (doingsubtraction == true)
    {
        int[] gotten = ConvertStringToArguments(currentcommand);
        int whatimado = Subtract(gotten[0], gotten[1]);

        Console.WriteLine($"output: {whatimado}");
        doingsubtraction = false;
    }
    else if (doingmultiplication == true)
    {
        int[] gotten = ConvertStringToArguments(currentcommand);
        int whatimado = Multiply(gotten[0], gotten[1]);

        Console.WriteLine($"output: {whatimado}");
        doingmultiplication = false;
    }
    #pragma warning restore CS8604

    if (currentcommand == "stopcalc")
    {
        doingcalculator = false;
    }
    else if (currentcommand == "add")
    {
        doingaddition = true;
    }
    else if (currentcommand == "subtract")
    {
        doingsubtraction = true;
    }
    else if (currentcommand == "multiply")
    {
        doingmultiplication = true;
    }
}
