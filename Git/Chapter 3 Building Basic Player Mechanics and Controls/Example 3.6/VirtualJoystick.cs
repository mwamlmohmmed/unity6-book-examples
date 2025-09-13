public class VirtualJoystick : MonoBehaviour, IDragHandler, 
IPointerUpHandler, IPointerDownHandler {
    public Image joystickBg;
    public Image joystickHandle;
    private Vector2 inputDirection = Vector2.zero;
    public Vector2 GetInputDirection() {
        return inputDirection;
    }
    public void OnDrag(PointerEventData ped) {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
     joystickBg.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
    pos.x = (pos.x / joystickBg.rectTransform.sizeDelta.x);
    pos.y = (pos.y / joystickBg.rectTransform.sizeDelta.y);

         inputDirection = new Vector2(pos.x * 2, pos.y * 2);
         inputDirection = (inputDirection.magnitude > 1) ? inputDirection.normalized : inputDirection;
            // Move handle
            joystickHandle.rectTransform.anchoredPosition =
                new Vector2(inputDirection.x * (joystickBg.
rectTransform.sizeDelta.x / 2),
                            inputDirection.y * (joystickBg.
rectTransform.sizeDelta.y / 2));
        }
    }
    public void OnPointerDown(PointerEventData ped) {
        OnDrag(ped);
    }
    public void OnPointerUp(PointerEventData ped) {
        inputDirection = Vector2.zero;
        joystickHandle.rectTransform.anchoredPosition = Vector2.zero;
    }
} 