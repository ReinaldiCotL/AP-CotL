public class LocationsManager
{
    public enum Locations
    {
        UNSET = -1,
        MOP_LEVEL_2,
        MOP_LEVEL_3,
        MOP_LEVEL_4,
        MOP_LEVEL_5,
        MOP_LEVEL_6,
        MOP_LEVEL_7,
        MOP_LEVEL_8,
        MOP_LEVEL_9,
        MOP_LEVEL_10,
    }

    public static List<Location> FetchLocations()
    {
        List<Location> locations = new List<Location>();

        foreach (LocationsManager.Locations location in Enum.GetValues(typeof(LocationsManager.Locations)))
        {
            if (location.Equals(Locations.UNSET)) continue;
            locations.Add(new Location { location = location });
        }

        return locations;
    }
}
