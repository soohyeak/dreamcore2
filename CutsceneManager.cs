using UnityEngine;
using System.Collections;

public class CutsceneManager : MonoBehaviour {
    public Camera cutsceneCamera;
    public Transform[] cutscenePoints;
    public float duration = 4f;

    void Start() { StartCoroutine(PlayCutscene()); }

    IEnumerator PlayCutscene() {
        // Placeholder cutscene: move camera through a couple of points then enable player control
        if (cutsceneCamera == null || cutscenePoints.Length == 0) yield break;
        foreach (var t in cutscenePoints) {
            Vector3 start = cutsceneCamera.transform.position;
            Vector3 end = t.position;
            float elapsed = 0f;
            while (elapsed < duration) {
                cutsceneCamera.transform.position = Vector3.Lerp(start, end, elapsed / duration);
                elapsed += Time.deltaTime;
                yield return null;
            }
            cutsceneCamera.transform.position = end;
            yield return null;
        }
        // End cutscene: you would enable player control here
    }
}
