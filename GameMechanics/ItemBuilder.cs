namespace TheWorld.GameMechanics;
using static TheWorld.Helpers;

public record ItemBuilder
{
    private Item _item = null!;
    
    public static ItemBuilder FromName(string name) => new() { _item = new Item(name, string.Empty) };
    public ItemBuilder WithDescription(string description) => this with { _item = _item with { Description = description } };

    public string? Build(GameData gameData)
    {
        if (gameData.TryAddItem(_item))
        {
            return _item.Name;
        }
        return null;

    }
    
    private ItemBuilder() { }
    
}