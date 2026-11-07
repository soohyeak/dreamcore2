using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour {
    public float moveSpeed = 2.5f;
    public float gravity = -9.81f;
    public bool isCrouching = false;
    private CharacterController cc;
    private Vector3 velocity;

    void Start() { cc = GetComponent<CharacterController>(); }

    void Update() {
        Vector2 input = TabletInput.GetMove();
        Vector3 move = (transform.forward * input.y + transform.right * input.x).normalized * moveSpeed;
        velocity.y += gravity * Time.deltaTime;
        cc.Move((move + new Vector3(0, velocity.y, 0)) * Time.deltaTime);
    }

    public void SetCrouch(bool crouch) {
        isCrouching = crouch;
        // Simple height change placeholder (requires character collider adjustments in a real scene)
    }
}
