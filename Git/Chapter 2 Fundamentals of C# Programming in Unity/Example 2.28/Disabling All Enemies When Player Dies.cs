void DisableAllEnemies() {                    
 GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    foreach (GameObject enemy in enemies) {
        enemy.SetActive(false);
    }
}