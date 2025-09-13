    public List<string> items = new List<string>();
    public void AddItem(string itemName){
        items.Add(itemName);
        Debug.Log("Added: " + itemName);
    } 