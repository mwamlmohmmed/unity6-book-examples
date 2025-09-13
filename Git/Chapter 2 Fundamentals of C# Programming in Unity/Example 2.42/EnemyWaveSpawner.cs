public class EnemyWaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    private Queue<GameObject> enemyQueue = new Queue<GameObject>();

    void Start()
    {
        // Preload 5 enemies and keep them inactive
        for (int i = 0; i < 5; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.SetActive(false);
            enemyQueue.Enqueue(enemy);
        }
        // Begin spawning every 2 seconds
        InvokeRepeating(nameof(SpawnNextEnemy), 1f, 2f);
    }
    void SpawnNextEnemy()
    {
        if (enemyQueue.Count > 0)
        {
            GameObject nextEnemy = enemyQueue.Dequeue();
            nextEnemy.transform.position = spawnPoint.position;
            nextEnemy.SetActive(true);
            Debug.Log("Spawned an enemy! Remaining in queue: " + enemyQueue.Count);
        }
        else
        {
            Debug.Log("All enemies have been spawned!");
        }
    }
}