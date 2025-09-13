public enum Difficulty {
    Easy,
    Normal,
    Hard,
    Nightmare
}
public Difficulty currentDifficulty = Difficulty.Normal;
void StartGame() {
    switch (currentDifficulty) {
        case Difficulty.Easy:
            enemyHealth = 50;
            break;
        case Difficulty.Normal:
            enemyHealth = 100;
            break;
        case Difficulty.Hard:
            enemyHealth = 150;
            break;
        case Difficulty.Nightmare:
            enemyHealth = 300;
            break;
    }
}
