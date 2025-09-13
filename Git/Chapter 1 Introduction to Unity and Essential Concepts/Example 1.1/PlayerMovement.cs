using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

   Vector3 moveDirection = new Vector3(moveX, moveY, 0f);
   transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}