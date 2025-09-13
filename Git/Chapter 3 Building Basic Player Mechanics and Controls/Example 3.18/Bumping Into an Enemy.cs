void OnCollisionEnter(Collision collision){    
    if (collision.gameObject.CompareTag("Enemy"))  {
        Debug.Log("Ouch! You hit an enemy!");
        // Maybe reduce player health here
    }
}