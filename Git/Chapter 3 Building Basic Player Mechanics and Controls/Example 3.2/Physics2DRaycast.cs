Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);

if (hit.collider != null) {
    Debug.Log("Clicked on: " + hit.collider.name);
}  