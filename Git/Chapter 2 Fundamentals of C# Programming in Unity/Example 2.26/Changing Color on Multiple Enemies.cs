public GameObject[] enemies;              
void Start() {
    for (int i = 0; i < enemies.Length; i++) {
enemies[i].GetComponent<SpriteRenderer>().color = Color.red;
    }
}