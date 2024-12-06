from BaseClasses import Item, ItemClassification

class CultOfTheLambItem(Item):
    game: str = "Cult of the Lamb"

mop_items = {
    "poop": (ItemClassification.filler, 9)

}

item_dict = {
    **mop_items
}