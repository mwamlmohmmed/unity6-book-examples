public class EnemyAI : MonoBehaviour {         

    private PlayerHealth playerHealth;

    void Start() {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void Update()  {
        if (Vector3.Distance(transform.position, playerHealth.transform.position) < 3f) {
            playerHealth.TakeDamage(5);
        }
    }
}