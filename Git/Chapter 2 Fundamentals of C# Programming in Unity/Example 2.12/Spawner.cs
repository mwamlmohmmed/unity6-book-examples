    public GameObject objectToSpawn;
    public float spawnRange = 2.0f;
    void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        float x = Random.Range(-spawnRange, spawnRange);
        float y = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPosition = new Vector3(x, y, 0f);
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}