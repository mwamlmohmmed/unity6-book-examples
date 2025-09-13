using TMPro;
public TextMeshProUGUI gameMessageText;
    void Start()
    {
      gameMessageText.color = Color.yellow;
      gameMessageText.text = "Press Space to change color!";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameMessageText.color = Color.magenta;
            gameMessageText.text = "Now it’s magenta!";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameMessageText.color = Color.white;
            gameMessageText.text = "Reset to white.";
        }
    }
