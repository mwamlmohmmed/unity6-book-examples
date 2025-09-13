public GameObject coinPrefab;               
void Start() {
    for (int i = 0; i < 10; i++) {
     Vector3 position = new Vector3(i * 2f, 0f, 0f);
     Instantiate(coinPrefab, position, Quaternion.identity);
    }
}
