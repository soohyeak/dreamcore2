using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterManager : MonoBehaviour {
    public void GoToChapter2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
