using MelonLoader;

public static class Randomizer
{
    public static void Init()
    {
        List<Location> locations = LocationsManager.FetchLocations();
        List<Item> items = ItemsManager.FetchItems();

        MelonLogger.Msg("##-- Setting up items --##");

        foreach(Item item in items)
        {
            MelonLogger.Msg(item.item + " LOADED");
        }

        MelonLogger.Msg("##-- Setting up locations --##");

        foreach (Location location in locations)
        {
            MelonLogger.Msg(location.location + " LOADED");
            Check check = new Check { location = location, item = ItemsManager.PickItem(items) };
            ChecksManager.checks.Add(check);
        }

        MelonLogger.Msg("##-- This is the set-up for this run --##");
        ChecksManager.LogChecks();
        MelonLogger.Msg("##-- End set-up --##");
    }
}
