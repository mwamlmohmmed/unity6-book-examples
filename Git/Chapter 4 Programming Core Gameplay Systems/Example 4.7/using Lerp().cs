public float fillSpeed = 5f;                    
private float targetValue;
void Update() {
    if (healthSlider != null)  {
        healthSlider.value = Mathf.Lerp(healthSlider.value, targetValue, fillSpeed * Time.deltaTime);
    }
}
void UpdateHealthBar() {
    if (healthSlider != null) {
        targetValue = currentHealth;
    }
}
