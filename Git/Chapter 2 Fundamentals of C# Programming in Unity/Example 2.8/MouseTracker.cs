using UnityEngine;
using TMPro; 

public class MouseTracker : MonoBehaviour
{
    public TextMeshProUGUI mousePositionText;

    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        mousePositionText.text = "Mouse Position: " + mousePos.ToString();
    }
}