using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    int playSceneIndex = 1;
    [SerializeField]
    int creditsSceneIndex = 3;


    // Start is called before the first frame update
    public void PlayButton()
    {
        SceneManager.LoadScene(playSceneIndex);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene(creditsSceneIndex);
    }
}
