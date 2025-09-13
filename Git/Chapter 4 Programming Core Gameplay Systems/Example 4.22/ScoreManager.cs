using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int currentScore = 0;
    public TextMeshProUGUI scoreText; // Assign this in the Inspector
    void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()  {
        UpdateScoreUI();
    }

    public void AddScore(int amount)  {
        currentScore += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI() {
        if (scoreText != null)
            scoreText.text = "Score: " + currentScore.ToString();
    }
}
