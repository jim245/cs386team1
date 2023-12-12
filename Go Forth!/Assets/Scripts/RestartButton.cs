using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void OnRestartButtonClick()
    {
        LoadStartScene();
    }

    private void LoadStartScene()
    {
        SceneManager.LoadScene("TitleScreen"); // Load your game scene by name
    }
}
