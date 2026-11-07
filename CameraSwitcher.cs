using UnityEngine;

public class CameraSwitcher : MonoBehaviour {
    public Camera firstPersonCam;
    public Camera thirdPersonCam;
    private bool isFirstPerson = true;

    public void ToggleView() {
        isFirstPerson = !isFirstPerson;
        if (firstPersonCam) firstPersonCam.enabled = isFirstPerson;
        if (thirdPersonCam) thirdPersonCam.enabled = !isFirstPerson;
    }
}
