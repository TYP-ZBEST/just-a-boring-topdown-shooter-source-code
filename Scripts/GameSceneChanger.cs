using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneChanger : MonoBehaviour
{
    [SerializeField]
    private int takeItBackSceneIndex = 3;
    [SerializeField]
    private int mainMenuSceneIndex = 0;

    public void TakeItBackButton()
    {
        SceneManager.LoadScene(takeItBackSceneIndex);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneIndex);
    }
    

}
