using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
    public GameObject panelGame;
    public GameObject gamePanel;
    public GameObject settingsPanel;
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        panelGame.SetActive(false);
        GameManager.obj.gameReady = true;
        gamePanel.SetActive(true);
    }
    public void OptionsGame()
    {
        gamePanel.SetActive(false);
        settingsPanel.SetActive(true);

    }
    public void CloseOptions()
    {
        gamePanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
