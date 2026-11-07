using UnityEngine;
public class SimpleBoat : MonoBehaviour {
    public float speed = 1f;
    void Update(){ transform.Translate(Vector3.forward * speed * Time.deltaTime); }
}
