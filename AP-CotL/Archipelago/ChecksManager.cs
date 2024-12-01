using MelonLoader;

public class ChecksManager
{
    public static List<Check> checks = new List<Check>();

    public static Check FindCheckByLocation(LocationsManager.Locations location)
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

    public static Check FindCheckByItem(ItemsManager.Items item)
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

    public static void Complete(LocationsManager.Locations location)
    {
        Check check = FindCheckByLocation(location);

        if (check == null)
        {
            return;
        }

        if (check.is_completed)
        {
            return;
        }

        check.is_hinted = true;
        check.is_completed = true;

        ItemsManager.Unlock(check.item);

        MelonLogger.Msg("Check COMPLETE! | Location: " + check.location + " | Item: " + check.item);
    }
}
