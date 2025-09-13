using UnityEngine;                           
public class EnemyFlasher : MonoBehaviour {
    void Update() {
        if (Input.GetKeyDown(KeyCode.H)) {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies) {
                SpriteRenderer sr = enemy.GetComponent<SpriteRenderer>();
                if (sr != null) {
                    sr.color = Color.red;
                }
            }
     Invoke(nameof(ResetColor), 1f); // reset after 1 second
        }
    }
    void ResetColor() {
    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

   foreach (GameObject enemy in enemies) {
   SpriteRenderer sr = enemy.GetComponent<SpriteRenderer>();
            if (sr != null) {
                sr.color = Color.white;
            }
        }
    }
}
