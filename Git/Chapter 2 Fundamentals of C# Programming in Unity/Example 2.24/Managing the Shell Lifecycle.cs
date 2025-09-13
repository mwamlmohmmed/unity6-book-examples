using UnityEngine;
public class Shell : MonoBehaviour {
    void Start() {
        // Destroy this shell after 5 seconds.
        Destroy(gameObject, 5f);
    }
}