public delegate void HealthChanged();

public class Player : MonoBehaviour
{
    public int health = 100;
    public event HealthChanged OnHealthChanged;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player health: " + health);
        // Fire the evnt if someone is listening
        if (OnHealthChanged != null)
        {
            OnHealthChanged();
        }
    }
}