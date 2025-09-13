public class Weapon : MonoBehaviour
{
    public WeaponData weaponData;
    void Start() {
        Debug.Log("Equipped: " + weaponData.weaponName);
        Debug.Log("Damage: " + weaponData.damage);
    }
    public void Attack(){
        Debug.Log(weaponData.weaponName + " attacks with " + weaponData.damage + " damage!");
    }                                   

}