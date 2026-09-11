using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{   
    public static uiManager instance;

    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject finishPanel;

    bool oyunDuraklatildiMi = false;


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseDurumDegistir();
        }
    }

    private void PauseDurumDegistir()
    {
        oyunDuraklatildiMi = !oyunDuraklatildiMi;

        if (oyunDuraklatildiMi)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void PauesePaneliAc()
    {
        if (!oyunDuraklatildiMi)
        {
            PauseDurumDegistir();
        }
    }

    public void PausePanelKapat()
    {
        if (oyunDuraklatildiMi)
        {
            PauseDurumDegistir();
        }
    }

    public void GameOverPAneliAc()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void FinishPanelAc()
    {
        finishPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void AnaMenuyeDon()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("AnaMenu");
    }
}