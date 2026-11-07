using UnityEngine;
using System.Collections;

public class CCTVController : MonoBehaviour {
    public Camera cctvCamera;
    public MonoBehaviour playerController;

    public void StartWatch(){
        if (cctvCamera != null) cctvCamera.enabled = true;
        if (playerController != null) playerController.enabled = false;
        // Start 15s watch timer
        CoroutineRunner.StartCoroutine(WatchDuration(15f, this));
    }

    System.Collections.IEnumerator WatchDuration(float seconds, MonoBehaviour self){
        yield return new WaitForSeconds(seconds);
        if (cctvCamera != null) cctvCamera.enabled = false;
        if (playerController != null) playerController.enabled = true;
        yield break;
    }
}
