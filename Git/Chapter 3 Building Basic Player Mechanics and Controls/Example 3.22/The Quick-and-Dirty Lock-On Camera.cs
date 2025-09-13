  public Transform player;
 void LateUpdate()  {
   // Stick to the player’s position — except Z stays fixed!
        transform.position = new Vector3(
            player.position.x,
            player.position.y,
            transform.position.z);
    }
