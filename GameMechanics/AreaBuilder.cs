namespace TheWorld.GameMechanics;
using static TheWorld.Helpers;

public record AreaBuilder
{
    
    private AreaBuilder() { }
    private Area _area;

    public static AreaBuilder FromName(string name) => new() { _area = new Area(name) };

    public AreaBuilder WithItem(String name) => this with
    {
        _area = _area with { Items = [.. _area.Items, name] }
    };
    //
    // private string _name;
    // private string _description;
    // private IReadOnlyList<string> _creatures;
    // private IReadOnlyList<string> _items;
    // private IReadOnlyList<string> _neighbors;
    //
    //
    // public static ItemBuilder FromName(string name) => new() { _name = ValidateString(name) };
    // public ItemBuilder WithDescription(string description) => this with { _description = ValidateString(description) };
    // public ItemBuilder WithCreatures(string description) => this with { _description = ValidateString(description) };
    //
    //
    // public string Build(GameData gameData)
    // {
    //     var item = new Item(_name, _description);
    //     gameData.TryAddItem(item);
    //     return _name;
    //
    // }
}