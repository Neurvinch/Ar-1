using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenCntrl : MonoBehaviour
{
    public void SwitchScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
