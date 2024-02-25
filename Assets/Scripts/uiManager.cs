using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject Pause;


    [SerializeField] private Button GameOverRestart;

    [SerializeField] private TextMeshProUGUI animals_fed;

    private gameManager gemu;

    private DestroyOutOfBounds destroyOutOfBoundsScrip;

    [SerializeField] private TextMeshProUGUI fedAnimalsGameOver;

    [SerializeField] private Button Lvl1;
    [SerializeField] private Button Lvl2;

    [SerializeField] private Button restart;
    [SerializeField] private Button resume;


    public void GameOverPanel(int fed)
    {
        GameOver.SetActive(true);
        fedAnimalsGameOver.text = $"has alimentado a: {fed}";
        animals_fed.text = "";
    }
    public void hidePanels()
    {
        GameOver.SetActive(false);
        menu.SetActive(false);
        Pause.SetActive(false);
        
    }

    public void showPanels()
    {
        menu.SetActive(true);
        GameOver.SetActive(false);
        Pause.SetActive(false);
        animals_fed.text = "";
    }
    

    private void Start()
    {
        gemu = FindObjectOfType<gameManager>();
        GameOverRestart.onClick.AddListener(() => { gemu.Restart(); });

        Lvl1.onClick.AddListener(() => { gemu.StartGame(1); });
        Lvl2.onClick.AddListener(() => { gemu.StartGame(2); });
        restart.onClick.AddListener(() => { gemu.Restart(); });
        resume.onClick.AddListener(() => { gemu.resume(); });

    }


    public void animasFedOnScreen(int fedScreen) 
    {
        animals_fed.text = $"has alimentado a: {fedScreen}";
    }

    public void hidePause()
    {
        Pause.SetActive(false);
    }

    public void showPause()
    {
        Pause.SetActive(true);
    }

}
