public class ItemsManager
{
    public enum Items
    {
        UNSET = -1,
        ITEM_LOG,
        ITEM_STONE,
        ITEM_BLACK_GOLD,
    }

    private static Random random = new Random();

    public static List<Item> FetchItems()
    {
        List<Item> items = new List<Item>();

        foreach (ItemsManager.Items item in Enum.GetValues(typeof(ItemsManager.Items)))
        {
            if (item.Equals(Items.UNSET)) continue;
            items.Add(new Item { item = item });
        }

        return items;
    }

    public static Item PickItem(List<Item> items)
    {
        int randomIndex = random.Next(items.Count);
        return items[randomIndex];
    }

    public static void Unlock(Item item)
    {
        // Unlock logic here.
    }
}
