public InputAction jumpAction;              
void OnEnable() {
    jumpAction.Enable();
}
void OnDisable() {
    jumpAction.Disable();
}
void Update() {
    if (jumpAction.triggered)
    {
        Debug.Log("Jump action triggered!");
    }
}