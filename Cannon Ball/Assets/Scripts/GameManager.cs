using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager obj;
    public bool gameReady = false;
    private void Awake()
    {
        obj = this;
    }
    public int endGame = 0;
    public GameObject[] enemys;
    void Start()
    {
        enemys = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void Update()
    {
        FinishGame();
    }
    void FinishGame()
    {
        if(endGame == enemys.Length)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
