private bool canTakeDamage = true;           
public float damageCooldown = 1f;
private IEnumerator DamageCooldown() {
    canTakeDamage = false;
    yield return new WaitForSeconds(damageCooldown);
    canTakeDamage = true;
}

private void OnCollisionEnter2D(Collision2D collision) {
    if (collision.collider.CompareTag("Enemy") && canTakeDamage)  {
        TakeDamage(1);
        Debug.Log("Ouch! Hit by enemy.");
        StartCoroutine(DamageCooldown());
    }
}
