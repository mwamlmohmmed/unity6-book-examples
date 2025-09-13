[CreateAssetMenu(fileName = “NewWeaponData”, menuName = 
“Game Data/Weapon”)]
public class WeaponData : ScriptableObject {
    public string weaponName;
    public int damage;
    public float attackSpeed;
    public Sprite icon;
}
