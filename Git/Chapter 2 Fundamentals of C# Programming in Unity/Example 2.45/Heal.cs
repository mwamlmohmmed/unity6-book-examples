public void Heal() {
    Debug.Log("Healed for a default amount!");
}
public void Heal(int amount) {
    Debug.Log("Healed for " + amount + " points!");
}
public void Heal(int amount, string source) {
    Debug.Log("Healed for " + amount + " points from " + source + “!”);
} 