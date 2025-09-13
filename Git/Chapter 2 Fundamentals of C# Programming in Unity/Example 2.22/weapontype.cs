string currentWeapon = "Bow";                  
switch (currentWeapon) {
    case "Sword":
        Debug.Log("You slash the enemy!");
        break;
    case "Bow":
        Debug.Log("You shoot an arrow!");
        break;
    case "Magic":
        Debug.Log("You cast a spell!");
        break;
    default:
        Debug.Log("Unarmed… run!");
        break;
}