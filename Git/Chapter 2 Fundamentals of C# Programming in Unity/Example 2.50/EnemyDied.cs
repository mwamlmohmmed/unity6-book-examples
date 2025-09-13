public delegate void EnemyDied();
public event EnemyDied OnEnemyDied;

public void Die() {
    Debug.Log("Enemy has fallen!");
    if (OnEnemyDied != null) {
        OnEnemyDied();
    }
}