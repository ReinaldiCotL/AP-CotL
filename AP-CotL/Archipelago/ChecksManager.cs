using static LocationsManager;

public class ChecksManager
{
    public static List<Check> checks = new List<Check>();

    public static Check FindCheckByLocation(LocationsManager.Location location)
    {
        Check the_check = null;

        foreach(Check check in checks)
        {
            if (check.location.Equals(location))
            {
                the_check = check;
                break;
            }
        }

        // Check not found.
        return the_check;
    }

    public static Check FindCheckByItem(ItemsManager.Item item)
    {
        Check the_check = null;

        foreach (Check check in checks)
        {
            if (check.item.Equals(item))
            {
                the_check = check;
                break;
            }
        }

        // Check not found.
        return the_check;
    }
}
