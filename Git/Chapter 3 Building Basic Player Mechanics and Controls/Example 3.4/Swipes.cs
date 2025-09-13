Vector2 startPos;                                Example 3.4
bool swipeDetected = false;
if (Input.touchCount > 0) {
    Touch touch = Input.GetTouch(0);

    if (touch.phase == TouchPhase.Began) {
        startPos = touch.position;
        swipeDetected = true;
    }
else if (touch.phase == TouchPhase.Ended && swipeDetected) {
        Vector2 endPos = touch.position;
        Vector2 swipeVector = endPos - startPos;
        if (swipeVector.magnitude > 50f){
            Debug.Log("Swipe detected! Direction: " + swipeVector.normalized);
        }
        swipeDetected = false;
    }
}
