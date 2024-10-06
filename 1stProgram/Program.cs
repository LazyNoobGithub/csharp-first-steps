static void SigmaCheck(bool sigmabool)
{
    if (sigmabool == false)
    {
        Console.Write("ya failed");
    }
    if (sigmabool == true)
    {
        Console.Write("ok sigma");
    }
}

Console.Write("Welcome to the sigma test 9000 \n");
Console.Write("This will test if your sigma or not. \n");
Console.Write("Awnser with 'true' or 'false' ONLY. (no quotes when you do) \n");
Console.Write("So the question is: \n");
Console.Write("Is skibidi toilet goated? \n");
Console.Write("Awnser: ");
bool whathesaid = bool.Parse(Console.ReadLine());
SigmaCheck(whathesaid);
