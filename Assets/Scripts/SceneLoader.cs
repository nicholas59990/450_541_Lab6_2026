using UnityEngine;
using UnityEngine.SceneManagement; // Needed for SceneManager

public class SceneLoader : MonoBehaviour
{

    /* 
    Public so a Button can call it
    The scene must be in the Build Profiles scene list or Unity will refuse to load it
    */
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame(){
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
