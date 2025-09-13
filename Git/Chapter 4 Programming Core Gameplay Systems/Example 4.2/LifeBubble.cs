 public int healAmount = 2;                 
    void OnTriggerEnter2D(Collider2D other)  {
   PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)  {
            player.Heal(healAmount);
     Debug.Log("✨ Life bubble collected! + " + healAmount);
            Destroy(gameObject);
        }
    }
