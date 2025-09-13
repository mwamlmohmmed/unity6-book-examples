using UnityEngine;
using TMPro;

public class ObjectTracker : MonoBehaviour
{
 public TextMeshProUGUI objectPositionText;
 public Transform targetObject;

 void Update()
    {
   Vector3 objectPos = targetObject.position;
  objectPositionText.text = "Object Position: " + objectPos.ToString();
    }
}