#Placeholder
def has_Anura_Access(state, player):
    return (state.can_reach("Anura", "Region", player))

def has_Temple(state, player):
    return (state.has("Temple", player))