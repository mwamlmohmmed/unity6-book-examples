public class EnemyLineController : MonoBehaviour
{
    public GameObject[] enemies;   // Array to hold all enemies
    public float[] speeds;       // Array to store each enemy’s speed
    void Start()
    {
        // Initialize speeds if you want random variation
        speeds = new float[enemies.Length];
        for (int i = 0; i < speeds.Length; i++)
        {
            speeds[i] = Random.Range(1f, 3f);
        }
    }
    void Update()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                enemies[i].transform.position += Vector3.down *
         speeds[i] * Time.deltaTime;
            }
        }
    }
}