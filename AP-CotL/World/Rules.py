#Placeholder

from GenericRules import add_item_rule, add_rule, location_item_name
from Items import item_dict
from Locations import CultOfTheLambLocation
from BaseClasses import CollectionState, Location
from AutoWorld import World
import Logic

def SetRules(multiworld, player):
    access_rules = {
        #empty currently
    }
    for loc in multiworld.get_locations(player):
        if loc.name in access_rules:
            add_rule(loc, access_rules[loc.name])