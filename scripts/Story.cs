using System;
using System.Collections.Generic;

class ZenithStory
{
    static void Main()
    {
        IntroScreen();
        GameLoop();
    }

    static void IntroScreen()
    {
        Console.WriteLine("""
        ╔════════════════════════════════════════════════════════════╗
        ║        ZENITH THE NUMBAT - A PAST MEMORY                  ║
        ║                                                            ║
        ║  An interactive story by Hydri-ibn                        ║
        ║  Created in C# for learning purposes in 2025              ║
        ╚════════════════════════════════════════════════════════════╝
        """);

        Console.WriteLine("In this story, you control a pivotal moment from Zenith's past.");
        Console.WriteLine("A young numbat, once a leader, now broken and lost.");
        Console.WriteLine("\nWarning: This story contains mature themes.");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("""
        You awake with a pounding headache. Your forehead feels like it might split in half.
        The taste of blood lingers in your mouth. Your fur is matted. Your body aches.
        
        You smell metal - iron perhaps. And earth. The pungent aroma of a forest after rain.
        
        As your eyes adjust to the dim light filtering through the canopy above,
        you notice dried blood beside you. An injury? A fight? Your memory is hazy.
        
        The forest is eerily quiet. Watching. Waiting.
        
        What do you do?
        """);
    }

    static int ShowChoice(string prompt, List<string> options)
    {
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("What will you do?\n");

        for (int i = 0; i < options.Count; i++)
        {
            Console.WriteLine($"{i + 1}.) {options[i]}");
        }

        while (true)
        {
            Console.Write("\n> ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= options.Count)
            {
                return choice;
            }
            Console.WriteLine("Please enter a valid number!");
        }
    }

    static void GameLoop()
    {
        bool gameRunning = true;

        while (gameRunning)
        {
            var initialChoices = new List<string>
            {
                "Search for water to drink - your throat is parched",
                "Investigate the forest - find out where you are",
                "Rest against a nearby tree - gather your strength",
                "Follow the strange sounds in the distance"
            };

            int choice = ShowChoice("The pain pulses through your head as you consider your options...", initialChoices);

            Console.Clear();

            switch (choice)
            {
                case 1:
                    PathWater();
                    gameRunning = false;
                    break;
                case 2:
                    PathForest();
                    gameRunning = false;
                    break;
                case 3:
                    PathRest();
                    gameRunning = false;
                    break;
                case 4:
                    PathSounds();
                    gameRunning = false;
                    break;
            }
        }

        Console.WriteLine("\n\nPress Enter to exit...");
        Console.ReadLine();
    }

    static void PathWater()
    {
        Console.WriteLine("""
        You stumble through the undergrowth, desperately searching for water.
        The trees seem to guide you deeper, closer to the sounds of running water.
        
        Your vision blurs. Is it the pain? The dehydration? Or something else?
        
        You find a stream, clear and cold. You kneel and drink.
        But as you look at your reflection, you barely recognize the numbat staring back.
        
        Haunted. Broken. Lost.
        """);
        Console.WriteLine("\n[THE END - Reflection Ending]");
    }

    static void PathForest()
    {
        Console.WriteLine("""
        You push deeper into the forest, searching for answers or escape.
        The trees loom overhead, their branches like skeletal fingers.
        
        You find something in the underbrush. Torn fabric. More blood.
        Recent. Fresh.
        
        A darker realization dawns on you. This wasn't an accident.
        You were brought here. Or you ran.
        """);

        var forestChoices = new List<string>
        {
            "Follow the trail of blood deeper",
            "Turn back before it's too late"
        };

        int choice = ShowChoice("Do you want to know what happened?", forestChoices);

        if (choice == 1)
        {
            Console.Clear();
            Console.WriteLine("""
            You follow the trail. It leads to a clearing.
            In the center, you find the remnants of a camp.
            Your camp. Your followers abandoned it.
            
            Abandoned YOU.
            
            The realization hits harder than any physical blow.
            """);
            Console.WriteLine("\n[THE END - Abandon Ending]");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("""
            You stop. You refuse to follow this path further.
            Some truths are better left buried.
            
            You turn back toward the forest's edge, toward the light.
            """);
            Console.WriteLine("\n[THE END - Denial Ending]");
        }
    }

    static void PathRest()
    {
        Console.WriteLine("""
        You collapse against a nearby tree, the exhaustion finally winning.
        The pain in your head dulls to a constant throb.
        
        As you rest, memories flash through your mind.
        Fragments of what was. What you had. What you lost.
        
        The forest grows darker around you. Or perhaps your consciousness is fading.
        """);

        var restChoices = new List<string>
        {
            "Sleep and hope for clarity when you wake",
            "Stay awake and face the darkness"
        };

        int choice = ShowChoice("Do you surrender to sleep or resist?", restChoices);

        if (choice == 1)
        {
            Console.Clear();
            Console.WriteLine("""
            Sleep comes. Deep. Dreamless. Endless.
            
            Perhaps that's mercy.
            """);
            Console.WriteLine("\n[THE END - Slumber Ending]");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("""
            You fight it. You stay awake through the night.
            The darkness closes in, but you remain conscious.
            Aware. Suffering. But alive.
            
            As dawn breaks, you realize the worst is always facing yourself.
            """);
            Console.WriteLine("\n[THE END - Vigil Ending]");
        }
    }

    static void PathSounds()
    {
        Console.WriteLine("""
        The sounds grow louder as you push through the underbrush.
        Footsteps. Voices. Coming closer.
        
        You realize too late - it's your old followers.
        They've been searching.
        
        Or have they been hunting?
        """);

        var soundChoices = new List<string>
        {
            "Face them - demand answers",
            "Hide and listen to what they say about you"
        };

        int choice = ShowChoice("Do you confront them or hide?", soundChoices);

        if (choice == 1)
        {
            Console.Clear();
            Console.WriteLine("""
            You step out from the trees, bloodied and beaten.
            
            They stop. Their faces shift from concern to fear to... disgust.
            
            Without a word, they turn and leave.
            
            A leader who cannot lead. A friend who was never a friend.
            Just a numbat. Alone.
            """);
            Console.WriteLine("\n[THE END - Rejection Ending]");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("""
            From your hiding place, you hear them.
            
            "He's dead, surely."
            "Good riddance. He was weak."
            "Better this way. We can start fresh without him."
            
            The words cut deeper than any blade.
            You were never the leader they needed.
            You were never enough.
            """);
            Console.WriteLine("\n[THE END - Bitter Truth Ending]");
        }
    }
}