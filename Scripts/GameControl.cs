using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public GameObject QuestionBankSecondLayout;
    public GameObject RestartButton;
    public GameObject GoodAndBadAnswerSecondLayer;
    public Toggle FirstAnswerToggleSecondLayer;
    public Toggle SecondAnswerToggleSecondLayer;
    private Scene Mainlvl;
    public Text wynik;
    public Text textBox;
    public Image endGame;
    public Text endGameText;
    public GameObject endGamePoints;
    public Sprite loseGameOver;
    public GameObject heart1, heart2, heart3, GameOver;
    public static int health;

    void Start()
    {
        Mainlvl = SceneManager.GetActiveScene();
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }
    private void Update()
    {
        if (health > 3)        
            health = 3;
        switch(health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                GameOver.gameObject.SetActive(true);
                endGame.sprite = loseGameOver;
                endGameText.text = "Niestety straciłeś wszystkie życia. Spróbuj Ponownie!";
                endGamePoints.SetActive(false); 
                Time.timeScale = 0f;
                break;
        }
    
    }
    public void Restart()
    {
        
        NextQuestionScript.lvl = 0;
        gamePoint.wynik = 0;
        health = 3;
        GameOver.gameObject.SetActive(false);
        QuestionBankSecondLayout.SetActive(false);
        StartCoroutine(TimerDead());
    }
    IEnumerator TimerDead()
    {
        textBox.gameObject.SetActive(true);
        Time.timeScale = 0f;
        float timestart = 3f;
        float step = 1;
        while (timestart > 0)
        {
            textBox.text = timestart.ToString("n0");
            timestart -= step;
            yield return new WaitForSecondsRealtime(step);
            while (timestart == 0)
            {
                timestart -= step;
                textBox.text = "GO!";
                yield return new WaitForSecondsRealtime(step);
            }
        }
        textBox.gameObject.SetActive(false);
        GoodAndBadAnswerSecondLayer.gameObject.SetActive(false);
        FirstAnswerToggleSecondLayer.isOn = false;
        SecondAnswerToggleSecondLayer.isOn = false;
        Time.timeScale = 1f;
    }
}
