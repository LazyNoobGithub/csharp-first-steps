using System;

class Adventurer
{
    public string Name = "Adventurer";
}

class Program
{
    static void Main(string[] args)
    {
        // TBA: Text-Based-Adventure!
        // By LazyNoob
        // IMPORTANT NOTE: run with this:
        // dotnet run [YOUR NAME HERE]

        #pragma warning disable


        Adventurer plr = new Adventurer();
        string sentvar = null;
        string ConsoleInput(string addingmessage)
        {
            Console.Write(addingmessage + " ");
            sentvar = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(sentvar))
            {
                Console.Write(addingmessage + " ");
                sentvar = Console.ReadLine();
            }
            return sentvar;
        }
        static void Ending(string endingname)
        {
            string sigma = endingname.ToUpper();
            Console.Write($"ENDING: {sigma}");
        }

        Console.WriteLine("---- NOTES & WELCOME ---------");
        Console.WriteLine("Welcome to gtbag, generic text based adventure.");
        Console.WriteLine("Here you can do anything (by what ive coded) and unlock endings.");
        Console.WriteLine("Your progress doesnt save, but you can re-add progress with cheat codes.");
        Console.WriteLine("-------- MAIN GAME ----------"); 
        Console.WriteLine("sup man, whats ya name?");

        string name = ConsoleInput("my name is:");
        plr.Name = name;

        Console.WriteLine($"ok, hello {plr.Name}!");
        Console.WriteLine($"so, {plr.Name}, where do you want to go?");
        Console.WriteLine("either the mall, the bed, or the grass");
        Console.WriteLine($"what do you choose, {plr.Name}?");

        string choice = ConsoleInput("my choice (only 'mall', 'bed', 'grass'):");

        if (choice == "mall")
        {
            // mall ending
            Console.WriteLine("Welcome to {MALL NAME}!");
            Console.WriteLine("Where do you wanna go now?");
            
            string mallc = ConsoleInput("i wanna go to (banana, appel, golden bear plushie):");

            if (mallc == "banana")
            {
                Console.WriteLine("You picked up a banana.");
                Console.WriteLine("OH MY GOD! IT COSTS 2000$ FOR THIS BANANA!");
                Console.WriteLine("You shouldnt even be holding this! Put it down, QUICK!");
                string down = ConsoleInput("just do 'down' as quick as you can: ");
                if (down == "down")
                {
                    // down code here
                    Console.WriteLine("Phew! that was a expensive banana! Juding by these prices, lets just go home.");
                    Ending("savior");
                } else
                {
                    Console.WriteLine("You are now 2000$ dollars in debt.");
                    Console.WriteLine("Please, PLEASE put down the banana quicker next time.");
                    Ending("Debt");
                }
            } else if (mallc == "appel")
            {
                Console.WriteLine("You approach a apple.");
                string inspectingstring = ConsoleInput("Inspect apple (Y/N)?:");
                if (inspectingstring == "Y")
                {
                    Console.WriteLine("Why is there a onion next to this apple?");
                    Ending("Good Apple?");
                } else if (inspectingstring == "N")
                {
                    Console.WriteLine("This is one bad apple I say, lets go home.");
                    Ending("Bad Apple");
                }
            } else if (mallc == "golden bear plushie")
            {
                Console.WriteLine("What is this?");
                Console.WriteLine("...A plushie?");
                Console.WriteLine("*golden freddy jumspcare sound*");
                Console.WriteLine("OOOFGHJFHOJDFJAOAAOOAOOAOOOOOAOAOAAOOAOAAAH");
                Ending("Golden Fredbear");
            }
        } else if (choice == "bed")
        {
            // sleep ending
            Console.WriteLine("Its 7am in the morning, your still tired? You went to bed at 6 PM.");
            string bedc = ConsoleInput("you gonna sleep? (Y/N):");
            if (bedc == "Y")
            {
                Console.WriteLine($"Alright, goodnight {plr.Name}.");
                Ending("sleepy boy");
            } else if (bedc == "N")
            {
                Console.WriteLine($"Nice save, {plr.Name}, but it is too late.");
                Console.WriteLine("-10 Health! You've been shot with a pistol.");
                Ending("america");
            }
        } else if (choice == "grass")
        {
            // grass ending
            Console.WriteLine("...");
            Console.WriteLine($"You, {plr.Name}, want to touch grass?");
            Console.WriteLine($"Look around, {plr.Name}, this is just a computer game.");
            Console.WriteLine($"So just know, {plr.Name}, that while you chose to touch grass,");
            Console.WriteLine("Someone else did too, but without the computer.");
            Ending("failure");
        } else
        {
            Console.WriteLine("I dont understand that.");
            Console.WriteLine("ERR: SGSFGKSDGJKDSJGKJFSDKGJKDGJSKJGSPJGDJGPDSJGKAPkgjPAJGKJAFPGDSJ ERROR 9001!!! ITS OVER 9000!!!!");
            Ending("computer malfunction");
        }
    }
}
