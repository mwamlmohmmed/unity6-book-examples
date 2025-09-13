using UnityEngine;                         
public class CircleMover : MonoBehaviour {
    public float moveSpeed = 3f;
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}