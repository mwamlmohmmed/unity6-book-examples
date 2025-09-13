public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Set the initial color
        spriteRenderer.color = Color.green;
    }
    void Update()
    {
        // Press Space to change to red
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.color = Color.red;
        }
        // Press R to reset to white
        if (Input.GetKeyDown(KeyCode.R))
        {
            spriteRenderer.color = Color.white;
        }
    }
}