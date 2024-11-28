using MelonLoader;
using static UnityEngine.InputSystem.InputRemoting;

public class ItemsManager
{
    public enum Types
    {
        UNSET = -1,
        ITEM_BLACK_GOLD,
        BUILDING_BEDS,
    }

    public static void Unlock(Types type, string player)
    {
        string message;

        switch(type)
        {
            case ItemsManager.Types.ITEM_BLACK_GOLD:
                Inventory.AddItem(InventoryItem.ITEM_TYPE.BLACK_GOLD, 100, false);
                message = "Received 100 Gold from " + player;
                break;
            case ItemsManager.Types.BUILDING_BEDS:
                UpgradeSystem.UnlockAbility(UpgradeSystem.Type.Building_Beds, false);
                DataManager.Instance.MostRecentTreeUpgrade = UpgradeSystem.Type.Building_Beds;
                message = "Received Building: Beds from " + player;
                break;
            default:
                message = "Received unsupported item from " + player;
                break;
        }

        NotificationCentre.Instance.PlayGenericNotification(message);
        MelonLogger.Msg(message);
    }
}
