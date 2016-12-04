using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public void GoToScene(string sceneName)
    {
        Debug.Log("Change scene button was clicked");
        SceneManager.LoadScene(sceneName);
    }
}
