Dictionary<string, int> inventory = new Dictionary<string, int>();
void AddItem(string itemName){
    if (inventory.ContainsKey(itemName))
        inventory[itemName]++;
    else
        inventory[itemName] = 1;
} 