public enum CameraMode {                    
    FirstPerson,
    ThirdPerson,
    TopDown,
    Cinematic
}
public CameraMode camMode;
void SwitchCamera(){
    switch (camMode) {
        case CameraMode.FirstPerson:
            ActivateFirstPerson();
            break;
        case CameraMode.ThirdPerson:
            ActivateThirdPerson();
            break;
        case CameraMode.TopDown:
            ActivateTopDown();
            break;
        case CameraMode.Cinematic:
            PlayCinematicView();
            break;
    }
}
