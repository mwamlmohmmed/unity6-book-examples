using System.Collections.Generic;           
public class DynamicEnemySpawner : MonoBehaviour {
    public GameObject enemyPrefab;
    public List<GameObject> activeEnemies = new List<GameObject>();
    public Transform spawnPoint;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnEnemy();
        }
      // Example: Remove enemies that fall below a certain point
       for (int i = activeEnemies.Count - 1; i >= 0; i--)  {
          if (activeEnemies[i].transform.position.y < -5f)
          {
                Destroy(activeEnemies[i]);
                activeEnemies.RemoveAt(i);
            }
        }
    }
    void SpawnEnemy() {
        GameObject newEnemy = Instantiate(enemyPrefab, 
spawnPoint.position, Quaternion.identity);
        activeEnemies.Add(newEnemy);
        Debug.Log("Spawned! Total enemies: " + activeEnemies.Count);
    }
}
