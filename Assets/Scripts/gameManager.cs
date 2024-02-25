using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using TMPro;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{

    private DestroyOutOfBounds destroyOutOfBounds;
    private uiManager uiManager;
    public int animalsFedNum;
    public PlayerController playerControl;
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Start()
    {

        uiManager.showPanels();
        Time.timeScale = 0f;

    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Time.timeScale = 0f;
            uiManager.showPause();
        }

    }

    private void Awake()
    {
        uiManager = FindObjectOfType<uiManager>();
        uiManager.hidePanels();
        playerControl = FindObjectOfType<PlayerController>();

    }

    public void fedAnimalstext()
    {
        uiManager.GameOverPanel(animalsFedNum);
    }

    public void animalscount()
    {
        uiManager.animasFedOnScreen(animalsFedNum);

    }

    public void StartGame(int disparo)
    {
        uiManager.hidePanels();
        animalscount();
        Time.timeScale = 1f;
        playerControl.disparo = disparo;
    }


    public void resume()
    {
        uiManager.hidePause();
        Time.timeScale = 1f;
    }
      


}
