using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{
    public Text Wynik;
    public GameObject StartMenu;
    public GameObject AboutGame;

    private void Start()
    {
        Time.timeScale = 0f;
        StartMenu.gameObject.SetActive(true);
        AboutGame.gameObject.SetActive(false);
    }
    public void StartButton()
    {
        StartSCORM();
        Time.timeScale = 1f;
        StartMenu.gameObject.SetActive(false);
    }
    public void AboutGameButton()
    {
        AboutGame.gameObject.SetActive(true);
    }
    public void OKAboutGameButton()
    {
        AboutGame.gameObject.SetActive(false);
    }
    public void StartSCORM() { Application.ExternalCall("ScormProcessInitialize"); }
}
