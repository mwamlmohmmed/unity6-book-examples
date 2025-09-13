private SpriteRenderer sr;
void Start() {
    sr = GetComponent<SpriteRenderer>();
}
private IEnumerator FlashRed() {
    sr.color = Color.red;
    yield return new WaitForSeconds(0.1f);
    sr.color = Color.white;
}
public void TakeDamage(int amount) {
    currentHealth -= amount;
    currentHealth = Mathf.Max(currentHealth, 0);
    UpdateHealthUI();
    StartCoroutine(FlashRed());
    if (currentHealth <= 0) {
        Debug.Log("You have perished... 😵");
    }
}
