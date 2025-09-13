public class SimpleMover : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
} 