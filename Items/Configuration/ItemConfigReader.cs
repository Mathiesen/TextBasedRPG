using System.Text.Json;
using Common;

namespace Items.Configuration;

public class ItemConfigReader
{
    private Dictionary<string, ItemConfig>? _config;

    public ItemConfigReader()
    {
        _config = ReadConfig();
    }
    
    private Dictionary<string, ItemConfig>? ReadConfig()
    {
        var json = File.ReadAllText("Items.json");
        return JsonSerializer.Deserialize<Dictionary<string, ItemConfig>>(json);
    }

    public ItemConfig GetConfigFor(ItemEnum item)
    {
        var config = _config![item.ToString()];
        return config;
    }
}

public class ItemConfig
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public int[] Color { get; set; }
    public string Description { get; set; }
    public string Quality { get; set; }
    public int DropChance { get; set; }
}