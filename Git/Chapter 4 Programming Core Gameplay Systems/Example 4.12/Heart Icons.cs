public Image[] lifeIcons; // Drag UI images into this in Inspector
public Sprite fullHeart;
public Sprite emptyHeart;

void UpdateLivesUI(int currentLives)
{
    for (int i = 0; i < lifeIcons.Length; i++)
    {
        if (i < currentLives)
            lifeIcons[i].sprite = fullHeart;
        else
            lifeIcons[i].sprite = emptyHeart;
    }
}