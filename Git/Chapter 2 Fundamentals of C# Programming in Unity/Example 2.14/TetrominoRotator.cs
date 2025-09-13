 public float moveSpeed = 5f;                  Example 2.14
    public enum RotationState {
        ZeroDegrees,   
        NinetyDegrees, 
        OneEighty,      
        TwoSeventy      
    }
public RotationState currentRotation = RotationState.ZeroDegrees;
   
    void Update() {
     float moveX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.UpArrow))  {
            RotateTetromino();
        }
     Vector3 moveDirection = new Vector3(moveX, 0f, 0f);
     transform.position += moveDirection * moveSpeed * Time.deltaTime;

    }

    void RotateTetromino() {
        currentRotation++;
        if ((int)currentRotation > 3)
            currentRotation = RotationState.ZeroDegrees;
        float angle = (int)currentRotation * 90f;
     transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

