// Second CSharp
static void QuestionParser(bool input, bool correct, string right, string wrong)
{
    if (input == correct)
    {
        Console.Write(right);
    }
    if (!(input == correct))
    {
        Console.Write(wrong);
    } 
}

string sent = Console.ReadLine();
bool interpreted = bool.Parse(sent);
QuestionParser(interpreted, true, "Good job", "aww");
