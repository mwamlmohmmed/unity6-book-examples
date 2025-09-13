public enum EnemyState {                       
    Idle,
    Patrolling,
    Chasing,
    Attacking
}
public class EnemyAI : MonoBehaviour {
    public EnemyState currentState = EnemyState.Idle;

    void Update()  {
        switch (currentState)  {
            case EnemyState.Idle:
                Debug.Log("Enemy is idle.");
                break;
            case EnemyState.Patrolling:
                Debug.Log("Enemy is patrolling.");
                break;
            case EnemyState.Chasing:
                Debug.Log("Enemy is chasing the player!");
                break;
            case EnemyState.Attacking:
                Debug.Log("Enemy is attacking!");
                break;
        }
    }
}
