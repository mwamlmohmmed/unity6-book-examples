using UnityEngine;
public class PublicPrivateExample : MonoBehaviour
{
    public int playerScore = 0;
    private int secretCode = 1234;
    void Start()
    {
        Debug.Log("Player score:"  + playerScore);
        Debug.Log("Secret code: " + secretCode);
    }
}