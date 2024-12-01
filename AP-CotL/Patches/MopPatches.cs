using HarmonyLib;
using MelonLoader;

[HarmonyPatch]
public class MopPatches
{
    [HarmonyPatch(typeof(PlayerChoreXPBarController), "LevelUpChores", new Type[] { typeof(PlayerFarming) })]
    [HarmonyPostfix]
    public static void PostfixLevelUpChores(PlayerFarming playerFarming)
    {
        MelonLogger.Msg("Leveled up Mop: " + DataManager.Instance.ChoreXPLevel);

        switch(DataManager.Instance.ChoreXPLevel)
        {
            case 0:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_2);
                break;
            case 1:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_3);
                break;
            case 2:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_4);
                break;
            case 3:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_5);
                break;
            case 4:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_6);
                break;
            case 5:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_7);
                break;
            case 6:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_8);
                break;
            case 7:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_9);
                break;
            case 8:
                ChecksManager.Complete(LocationsManager.Locations.MOP_LEVEL_10);
                break;
        }
    }
} 
