﻿using The_legend_of_Kunz.Character;

namespace The_legend_of_Kunz;

public class Game
{
    private Character.Character _player;
    private bool _isRunning;
    private bool _firstLoad;
    
    public void Start()
    {
        Console.WriteLine("Loading....");

        CreateCharacter();

        _firstLoad = true;
        _isRunning = true;
        while (_isRunning)
        {
            DisplayMainMenu();

            string choice = Console.ReadLine();
            HandleMainMenuChoice(choice);
        }
    }

    private void HandleMainMenuChoice(string? choice)
    {
        switch (choice)
        {
            case "1":
                Explore();
                break;
            case "2":
                Inventory();
                break;
            case "3":
                Stats();
                break;
            case "4":
                Exit();
                break;
            default:
                Console.WriteLine("Invalid choice, try again");
                break;
        }
    }

    private void Exit()
    {
        Console.WriteLine("Thank you for playing");
        _isRunning = false;
    }

    private void Stats()
    {
        Console.WriteLine("\nYour stats is: ");
        Console.WriteLine($"Health: {_player.Class.Health}");
        Console.WriteLine($"Defence: {_player.Class.Defence}");
        Console.WriteLine($"Attack: {_player.Class.Attack}");
        Console.WriteLine($"Mana: {_player.Class.Mana}");
        
        Continue();
    }

    private void Inventory()
    {
        var items = _player.Inventory.Items;
        var weapons = _player.Inventory.Weapons;
        if (items.Count == 0
            && weapons.Count == 0)
        {
            Console.WriteLine("You do not have anything in your inventory");
        }

        Console.WriteLine("\nYour inventory contains: ");
        items.ToList().ForEach(x => Console.WriteLine(x.Value.ToString()));
        weapons.ToList().ForEach(x => Console.WriteLine(x.Value.ToString()));
        
        Continue();
    }

    private void Explore()
    {
        Exploration.ExploreArea();
    }

    private void DisplayMainMenu()
    {
        if (_firstLoad)
        {
            Console.WriteLine("\nWelcome adventurer, what would you like to do?");
            _firstLoad = false;
        }

        Console.WriteLine("\n1. Explore");
        Console.WriteLine("2. View inventory");
        Console.WriteLine("3. View stats");
        Console.WriteLine("4. Exit game");
    }

    private void CreateCharacter()
    {
        _player = CharacterFactory.CreateCharacter(CharacterEnum.Player);
    }

    private void Continue()
    {
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}