using Characters;
using Common;
using Items;

namespace The_legend_of_Kunz;

public class Game
{
    private ICharacter? _player;
    private CharacterFactory _characterFactory;
    private bool _isRunning;
    private bool _firstLoad;
    
    public void Start(CharacterFactory characterFactory)
    {
        Console.WriteLine("Loading....");
        _characterFactory = characterFactory;

        CreateCharacter();

        _firstLoad = true;
        _isRunning = true;
        while (_isRunning)
        {
            DisplayMainMenu();

            string choice = Console.ReadLine();
            if (choice != null && choice.StartsWith("!"))
            {
                var newChoice = choice.Remove(choice.IndexOf("!", StringComparison.Ordinal), 1);
                var words = newChoice.Split(" ");
                if (words[0] == "give" && words[1] == "item")
                {
                    var item = (ItemEnum)Enum.Parse(typeof(ItemEnum), words[2]);
                    if (item == ItemEnum.Gold)
                    {
                        var quantity = int.Parse(words[3]);
                        _player.Inventory.GiveItem(item, quantity);
                    }
                    else
                    {
                        _player.Inventory.GiveItem(item);
                    }
                }
            }
            else
            {
                HandleMainMenuChoice(choice);
            }
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
            case "5":
                CreateSkeleton();
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
        var items = _player?.Inventory.Items;
        if (items!.Count == 0)
        {
            Console.WriteLine("You do not have anything in your inventory");
        }

        Console.WriteLine("\nYour inventory contains: ");
        items.ToList().ForEach(x => Console.WriteLine(x.Value.GetDescription()));
        
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
        Console.WriteLine("5. Create skeleton");
    }

    private void CreateCharacter()
    {
        _player = _characterFactory.CreateCharacter(CharacterEnum.Player, null);
    }

    private ICharacter? CreateSkeleton()
    {
        var skellie =  _characterFactory.CreateCharacter(CharacterEnum.Skeleton, _player);
        Console.WriteLine(skellie.ToString());
        skellie!.Inventory.Items.ToList().ForEach(x => Console.WriteLine(x.Value.GetDescription()));
        
        return skellie;
    }

    private void Continue()
    {
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}