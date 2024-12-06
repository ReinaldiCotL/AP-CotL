from typing import Dict, Any
from BaseClasses import ItemClassification, Region
from AutoWorld import World

from Items import CultOfTheLambItem, mop_items
from Locations import location_list
from Options import CultOfTheLambOptions
from Rules import SetRules
from Regions import region_list


class CultOfTheLambWorld(World):
    game = "Cult of the Lamb"
    option_definitions = CultOfTheLambOptions
