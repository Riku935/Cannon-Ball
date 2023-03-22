using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject panelGame;
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
    }
}
