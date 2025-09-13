public int playerScore = 0;                 
public TextMeshProUGUI scoreText;
void Update() {
    scoreText.text = "Score: " + playerScore;
    if (playerScore >= 100)  {
        scoreText.color = Color.green;
    }
    else {
        scoreText.color = Color.red;
    }
}
