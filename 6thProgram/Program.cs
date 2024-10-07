// Title:
// Password Generator

// Description:
// A program that generates random passwords based on user preferences 
// (length, use of special characters, numbers, etc.). You can also add a feature to copy the generated password to the clipboard.

// By:
// LazyNoob

string ConsoleInput(string addingmessage)
{
    Console.Write(addingmessage + " ");
    string? sentvar = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(sentvar))
    {
        Console.Write(addingmessage + " ");
        sentvar = Console.ReadLine();
    }
    return sentvar;
}

int length = Convert.ToInt32(ConsoleInput("password length (number):"));
bool usespecialchars = Convert.ToBoolean(ConsoleInput("use special charactrs ('true' or 'false'):"));
bool usenumbers = Convert.ToBoolean(ConsoleInput("use numbers (use 'true' or 'false'):"));

string[] words = {"mustang", "pizzas", "woahblox", "coolkid"};
// Table description:
// mustang: 7L
// pizzas: 6L
// woahblox: 8L
// coolkid: 6L
// Total Words: 27

string[] specialchars = {"!","=","~",")"};
// Table Description:
// Each string in table is 1L
// Total: 4L

int[] numbers = {0,1,2,3,4,5,6,7,8,9};
// Table Description:
// Each string in table is 1N
// Total: 9N (9L)

string GenerateWord()
{
    Random random = new Random();
    int randomGotten = random.Next(0, words.Length);
    string randomGottenString = words[randomGotten];
    return randomGottenString;
}

string GenerateSpecialChar()
{
    Random random = new Random();
    int randomGotten = random.Next(0, specialchars.Length);
    string randomGottenString = specialchars[randomGotten];
    return randomGottenString;
}

int GenerateNumber()
{
    Random random = new Random();
    int randomGotten = random.Next(0, numbers.Length);
    int randomGottenNumber = numbers[randomGotten];
    return randomGottenNumber;
}

string TrimStringToLimit(string input, int limit)
{
    if (input.Length > limit)
    {
        return input.Substring(0, limit);
    }
    
    return input;
}


string GeneratePassword(int charlength, bool usespecialcharacters, bool usenumbertable)
{
    // structure: word (number) word (number) (specialchar)
    string firstword = GenerateWord();
    string secondword = GenerateWord();

    string specialchar = GenerateSpecialChar();

    int firstnumber = GenerateNumber();
    int secondnumber = GenerateNumber();

    string currentpass = "";

    currentpass = firstword;
    if (usenumbertable == true)
    {
        currentpass = currentpass + firstnumber + secondword + secondnumber;
    } else
    {
        currentpass = currentpass + secondword;
    }

    if (usespecialcharacters == true)
    {
        currentpass = currentpass + specialchar;
    }
    
    currentpass = TrimStringToLimit(currentpass, charlength);

    return currentpass;
}

string generatedpassword = GeneratePassword(length, usespecialchars, usenumbers);
Console.WriteLine($"your new password is: {generatedpassword}");
