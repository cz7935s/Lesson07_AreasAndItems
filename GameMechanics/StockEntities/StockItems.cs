namespace TheWorld.GameMechanics.StockEntities;

public class StockItems
{
    public static string? Knife(GameData gameData) =>
        ItemBuilder.FromName("Knife")
            .WithDescription("A Big Foookin Knife")
            .Build(gameData);
}