// See https://aka.ms/new-console-template for more information

using System;
using System.IO;


// Get and set the character's name 
class Character
{
    public string Name { get; set; }

    public Character(string name)
    {
        Name = name;
    }

    // Greet the character
    public void Greet()
    {
        Console.WriteLine("Good luck " + Name + " !!! ");
    }
}

class TextAdventureGame
{
    static void Main(string[] args)
    {
        // simple loop to keep the game going.
        bool playAgain = true;

        while (playAgain)
        {
            // CharacterName if no input
            string characterName = "John Doe";

            Console.WriteLine("Welcome to the Text Adventure Game!");

            // backstory
            Console.WriteLine("Welcome to Dragon Slayer Interactive Text Game ....... Let's embark on an adventure into the depths of a dragon cave");
            Console.WriteLine("What is your character's name? ");

            characterName = Console.ReadLine();

            // Write character name to file
            WriteCharacterNameToFile(characterName);

            // Set the new Character and greet them
            Character player = new Character(characterName);
            player.Greet();

            // Start the Game
            StartGame();

            Console.WriteLine("Thanks for playing!");

            Console.WriteLine("---------------------------------------------");

            // Ask if the player wants to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = (playAgainInput == "yes");

        }


    }

    private static void WriteCharacterNameToFile(string name)
    {
        string fileName = "CharacterName.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName, true)) // Append mode
            {
                writer.WriteLine("Character's Name: " + name);
            }

            Console.WriteLine("Character's name written to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
        }
    }

    private static void StartGame()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Start Story");
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine("You Find yourself at the entrance of a dark cave.");
        Console.WriteLine("You hear a faint sound coming from deep inside the cave.");
        Console.WriteLine("What do you do?");

        Console.WriteLine("");

        Console.WriteLine("1. Enter the cave?");
        Console.WriteLine("2. Stay outside and watch from a distance?");
        Console.WriteLine("3. Call out to see if anyone or anything is inside?");

        Console.WriteLine("Enter which option you choose (1, 2, 3) ... ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            EnterCave();
        }
        else if (choice == "2")
        {
            StayOutOfCave();
        }
        else if (choice == "3")
        {
            CallOutToCave();
        }
        else
        {
            // If the user inputs an invalid choice show this error and restart section
            Console.WriteLine("\nPlease enter a valid choice.");
            StartGame();
        }
    }

    // Diffrent Game Options 
    private static void EnterCave()
    {
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("As you enter the cave, A sound echoes through the darkness.");
        Console.WriteLine("You keep walking deeper and deeper into the cave.");
        Console.WriteLine("Until you encounter two paths. One leads left and the other right.");
        Console.WriteLine("You don't know where each path will take you.");
        Console.WriteLine("Which path do you choose? (left/right)");

        string choice = Console.ReadLine().ToLower();

        Console.WriteLine("");

        if (choice == "left")
        {
            Console.WriteLine("As you walk left you find a part of the cave filled with all kinds of precious rocks.");
            Console.WriteLine("You reach to pick one up the ground starts rumbling beneath your feet. ");
            Console.WriteLine("You hear loud footsteps getting closer and closer. ");
            Console.WriteLine("Before you know, there is a dragon right in front of you.");
            Console.WriteLine("You drop the rock and run out of the cave");
            Console.WriteLine("You barely escape with your life, and never returned again.");

            Console.WriteLine("");

            Console.WriteLine("The End...");

        }
        else if (choice == "right")
        {
            Console.WriteLine("As you walk right you see small flickers of firelight.");
            Console.WriteLine("You creep forward, trying not to make any noise.");
            Console.WriteLine("You then see this massive dragon asleep in the cave.");
            Console.WriteLine("As you walk closer and closer you try to touch the dragon.");
            Console.WriteLine("The dragon wakes up and looks right at you.");
            Console.WriteLine("You try to talk to the dragon, and for a moment it appears to understand you.");
            Console.WriteLine("He then lay down again and went back to sleep. ");

            Console.WriteLine("");

            Console.WriteLine("You couldn't believe what you had just seen. After some time you left the dragon. ");
            Console.WriteLine("And he was never seen again.");

            Console.WriteLine("");

            Console.WriteLine("The End...");
        }
        else
        {
            // If the user inputs an invalid choice show this error and restart section
            Console.WriteLine("\nPlease enter a valid choice.");
            EnterCave();
        }
    }

    private static void StayOutOfCave()
    {
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("You decide to stay outside the cave. As you watch, you notice a small rumbling sound from within the cave. ");
        Console.WriteLine("As you lean a little closer the rumbling grows louder, and you can feel the ground vibrating beneath your feet. ");
        Console.WriteLine("Suddenly, out of the darkness appears a massive dragon standing right in front of you.");

        Console.WriteLine("");

        Console.WriteLine("What do you do? ");

        Console.WriteLine("1. Stay perfectly still and hope the dragon doesn't see you.");
        Console.WriteLine("2. Slowly move away and hide behind a tree.");
        Console.WriteLine("3. Run as fast as you can. ");

        Console.WriteLine("Enter which option you choose (1, 2, 3) ... ");

        string choice = Console.ReadLine();

        Console.WriteLine("");

        if (choice == "1")
        {
            Console.WriteLine("You hold your breath as you try to stay perfectly still.");
            Console.WriteLine("But the dragon spots you straight away and walks right up to you.");
            Console.WriteLine("His attention is drawn to something deeper in the cave.");
            Console.WriteLine("The dragon disappears back into the dark cave.");

            Console.WriteLine("");

            Console.WriteLine("The End...");

        }
        else if (choice == "2")
        {
            Console.WriteLine("You slowly move behind a nearby tree.");
            Console.WriteLine("The dragon follows you and looks you in the eyes.");
            Console.WriteLine("He sniffs you then turns around and goes back into the cave.");
            Console.WriteLine("You start questioning why he didn't eat you.");
            Console.WriteLine("You then decide to follow him into the cave. ");

            Console.WriteLine("");

            EnterCave();
        }
        else if (choice == "3")
        {
            Console.WriteLine("You run as fast as you can, but the dragon is right behind you");
            Console.WriteLine("Eventually, you find a cliff with water at the bottom.");
            Console.WriteLine("Just as the dragon is about to get you, you jump. ");
            Console.WriteLine("You land in the water and you are safe from the dragon...");

            Console.WriteLine("");

            Console.WriteLine("The End...");
        }
        else
        {
            // If the user inputs an invalid choice show this error and restart section
            Console.WriteLine("\nPlease enter a valid choice.");
            StayOutOfCave();
        }

    }

    private static void CallOutToCave()
    {
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("You walk a little closer to the cave and say 'Hello? Is anyone there?' ");
        Console.WriteLine("At first you hear a loud growl, but then it's complete silence. ");
        Console.WriteLine("Suddenly, you see two glowing eyes right in front of you.");
        Console.WriteLine("You try to shine a torch on the dragon but you only make it angry.");
        Console.WriteLine("");
        Console.WriteLine("The dragon was angry and tried to burn you with its fiery breath. ");
        Console.WriteLine("You ran as fast and you could, until you found a place that was safe from the dragon");

        Console.WriteLine("");

        Console.WriteLine("The End...");
    }
}
