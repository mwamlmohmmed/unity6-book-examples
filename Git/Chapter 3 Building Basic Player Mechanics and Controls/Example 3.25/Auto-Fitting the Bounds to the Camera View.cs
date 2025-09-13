float camHeight = Camera.main.orthographicSize;   

float camWidth = camHeight * Camera.main.aspect;

float clampedX = Mathf.Clamp(targetPos.x, minBounds.x + camWidth, maxBounds.x - camWidth);
float clampedY = Mathf.Clamp(targetPos.y, minBounds.y + camHeight, maxBounds.y - camHeight);