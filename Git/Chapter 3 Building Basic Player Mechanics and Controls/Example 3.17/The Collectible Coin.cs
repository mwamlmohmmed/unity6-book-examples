void OnTriggerEnter2D(Collider2D other) {       
      if (other.CompareTag("Player")) {
        Debug.Log("Coin collected!");
        Destroy(gameObject);
    }
}
