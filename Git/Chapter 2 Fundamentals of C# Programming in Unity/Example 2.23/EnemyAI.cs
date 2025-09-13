public enum EnemyState {
    Idle,
    Patrolling,
    Chasing,
    Attacking
}
public class EnemyAI : MonoBehaviour {
    public EnemyState currentState;
    void Update() {
        switch (currentState) {
            case EnemyState.Idle:
                Debug.Log("Enemy is resting.");
                break;
            case EnemyState.Patrolling:
                Debug.Log("Enemy is walking the area.");
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