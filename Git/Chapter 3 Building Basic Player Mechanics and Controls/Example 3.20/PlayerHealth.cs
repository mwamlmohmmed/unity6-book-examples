using UnityEngine;                    
public class PlayerHealth : MonoBehaviour {
    public float knockbackForce = 5f;        
           private Rigidbody2D rb;
    private bool isInvincible = false;
    void Start()  {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)  {
if (collision.gameObject.CompareTag("Enemy") && !isInvincible) {
            Vector2 hitDirection = (transform.position - collision.transform.position).normalized;
            rb.AddForce(hitDirection * knockbackForce, ForceMode2D.Impulse);
            // Reduce health (not shown here)
            StartCoroutine(TemporaryInvincibility());
        }
    }
 private IEnumerator TemprryInvincibility() {
        isInvincible = true;
        // Optionally flash sprite or disable collider to show invincibility
        yield return new WaitForSeconds(1f);
        isInvincible = false;
    }
}
