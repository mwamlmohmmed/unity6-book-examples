
using UnityEngine;
using TMPro;
using System.Collections.Generic;
public class EquipmentSwiper : MonoBehaviour
{
    public TextMeshProUGUI equipmentText;

    private List<string> equipmentList = new List<string> { "Sword", "Bow", "Magic Staff", "Dagger", "Shield" };
    private int currentIndex = 0;

    private Vector2 startTouchPosition;
    private bool swipeDetected = false;
    void Start()
    {
        UpdateEquipmentDisplay();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
                swipeDetected = true;
            }
            else if (touch.phase == TouchPhase.Ended && swipeDetected)
            {
                Vector2 endTouchPosition = touch.position;
                Vector2 swipeVector = endTouchPosition - startTouchPosition;

                if (Mathf.Abs(swipeVector.x) > Mathf.Abs(swipeVector.y) && swipeVector.magnitude > 50f)
                {
                    if (swipeVector.x > 0)
                    {
                        currentIndex--;
                        if (currentIndex < 0)
                            currentIndex = equipmentList.Count - 1;
                    }
                    else
                    {
                        currentIndex++;
                        if (currentIndex >= equipmentList.Count)
                            currentIndex = 0;
                    }

                    UpdateEquipmentDisplay();
                }

                swipeDetected = false;
            }
        }
    }

    void UpdateEquipmentDisplay()
    {
        equipmentText.text = "Equipped: " + equipmentList[currentIndex];
        Debug.Log("Now equipped: " + equipmentList[currentIndex]);
    }

}